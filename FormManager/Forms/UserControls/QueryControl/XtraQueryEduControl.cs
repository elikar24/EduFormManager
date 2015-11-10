using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using EduFormManager.Forms.Reports;
using EduFormManager.Properties;
using Models;
using Models.Repo;
using PopupMenuShowingEventArgs = DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public partial class XtraQueryEduControl : XtraBaseControl, ISupportDocumentActions
    {
        private QuerySummaryModelCollection<QueryEduSummaryModel> _querySummaryModelCollection;
        private form _selectedForm;
        private int _selectedYear;
        private bool _isOnlyPassport;

        private bool _isManualChecking = true;
        public XtraQueryEduControl(WindowsUIView view, Repository repo) 
            : base(view, repo)
        {
            InitializeComponent();
            Init();
            InitializeEventHandlers();

            this.flyoutPanelMenu.OwnerControl = view.Manager.ContainerControl;
        }

        public IList<int> YearDataSource
        {
            set
            {
                this.comboBoxYear.DataSource = value;
                if (value.Any()) _selectedYear = value.FirstOrDefault();
            }
        }
        public IList<query_head_part> QueryPartHeadDataSource
        {
            set { this.queryControl.QueryPartHeadDataSource = value; }
        }

        private void InitializeEventHandlers()
        {
            this.formBindingSource.DataSourceChanged += (sender, args) =>
            {
                var forms = (ICollection<form>)formBindingSource.DataSource;
                this.comboBoxForm.DataSource = forms;
                this.comboBoxForm.DisplayMember = "name";
                if (forms.Any()) 
                    _selectedForm = forms.FirstOrDefault();
            };

            this.checkBoxOnlyPassport.CheckStateChanged += (s, e) =>
            {
                this.comboBoxForm.Enabled = !this.checkBoxOnlyPassport.Checked;
                this.comboBoxYear.Enabled = !this.checkBoxOnlyPassport.Checked;
            };
            this.popupQuerySummaryModel.QueryResultValue += (sender, args) =>
            {
                _isOnlyPassport = this.checkBoxOnlyPassport.Checked;
                _selectedForm = _isOnlyPassport 
                    ? new form { form_id = 0, name = "Паспорт" } 
                    : (form)this.comboBoxForm.SelectedItem;
                _selectedYear = _isOnlyPassport 
                    ? 0 
                    : (int) this.comboBoxYear.SelectedItem;
                OnIndexChangedSetDataSourceFor();
                args.Value = _querySummaryModelCollection.Current;
            };

            this.buttonClosePopup.Click += (sender, args) => this.popupQuerySummaryModel.ClosePopup();

            this.buttonMenuFlyout.Click += (sender, eventArgs) =>
            {
                if (this.flyoutPanelMenu.IsPopupOpen)
                {
                    this.flyoutPanelMenu.HidePopup();
                    (sender as SimpleButton).Text = "Меню";
                }
                else
                {
                    this.flyoutPanelMenu.ShowPopup();
                    (sender as SimpleButton).Text = "Закрыть";
                }
            };

            this.gridViewEdu.SelectionChanged += (sender, args) =>
            {
                if (!_isManualChecking) return;
                try
                {
                    if (args.ControllerRow < 0) return;
                    var edu = (edu) this.gridViewEdu.GetRow(args.ControllerRow);
                    if (edu == null) return;
                    switch (args.Action)
                    {
                        case CollectionChangeAction.Add:
                            _querySummaryModelCollection.Current.EduList.Add(edu);
                            break;
                        case CollectionChangeAction.Remove:
                            _querySummaryModelCollection.Current.EduList.Remove(edu);
                            break;

                    }
                    ResetGridViews();
                }
                catch
                {
                    // ignored
                }
            };

            this.queryControl.SelectionChanged += (sender, args) =>
            {
                if (!_isManualChecking) return;
                try
                {
                    var query = this.queryControl.Queries[args.ControllerRow];
                    switch (args.Action)
                    {
                        case CollectionChangeAction.Add:
                            _querySummaryModelCollection.Current.QueryList.Add(query);
                            break;
                        case CollectionChangeAction.Remove:
                            _querySummaryModelCollection.Current.QueryList.Remove(query);
                            break;
                    }
                    ResetGridViews();
                }
                catch { }
            };
        }
        private void Init()
        {
            _querySummaryModelCollection = new QuerySummaryModelCollection<QueryEduSummaryModel>();
            this.querySummaryModelBindingSource.DataSource = _querySummaryModelCollection;
        }

        private async void OnIndexChangedSetDataSourceFor()
        {
            this.queryControl.QueryDataSource = await Repo.GetQueries(_selectedForm.form_id);
            IList<edu> eduList = null;
            if (Authentication.Credentials.IsAdmin || Authentication.Credentials.IsMinistry)
            {
                eduList = _isOnlyPassport ?
                    await Repo.GetEdus() :
                    await Repo.GetEdusHaveFormData(_selectedForm.form_id, _selectedYear);
            }
            else if (Authentication.Credentials.IsMunicipality)
            {
                var munitId = Authentication.Credentials.MunitId;
                eduList = _isOnlyPassport
                    ? await Repo.GetEdus(munitId)
                    : await Repo.GetEdusHaveFormData(_selectedForm.form_id, _selectedYear, munitId);
            }
            else if (Authentication.Credentials.IsEdu)
            {
                var eduId = Authentication.Credentials.EduId;
                var edu = _isOnlyPassport
                    ? await Repo.GetEdu(eduId)
                    : await Repo.GetEduHaveFormData(_selectedForm.form_id, _selectedYear, eduId);
                eduList = new List<edu> { edu };
            }
            this.eduBindingSource.DataSource = eduList;
            ChangeCurrentQuerySummaryModel();
            CheckItemsFromSummaryModel();
        }

        private void CheckItemsFromSummaryModel()
        {
            _isManualChecking = false;
            gridViewEdu.ClearSelection();
            var model = _querySummaryModelCollection.Current;
            foreach (var edu in model.EduList)
            {
                var idx = this.eduBindingSource.List.IndexOf(edu);
                var row = this.gridViewEdu.GetRowHandle(idx);
                this.gridViewEdu.SelectRow(row);
            }
            this.queryControl.SelectRange(model.QueryList);
            _isManualChecking = true;
        }

        private void ChangeCurrentQuerySummaryModel()
        {
            if (!_querySummaryModelCollection.Contains(_selectedForm, _selectedYear))
                _querySummaryModelCollection.Add(new QueryEduSummaryModel(_selectedForm, _selectedYear));
            _querySummaryModelCollection.Current = _querySummaryModelCollection[_selectedForm, _selectedYear];
        }

        private void ResetGridViews()
        {
            var view = (GridView) gridControlQuerySummary.MainView;
            var rowHandle = view.GetRowHandle(this.querySummaryModelBindingSource.IndexOf(_querySummaryModelCollection.Current));
            this.querySummaryModelBindingSource.ResetBindings(false);
            view.SetMasterRowExpanded(rowHandle, true);
        }

        private bool CanShowQueryReport(Document doc)
        {
            return _querySummaryModelCollection.All(t => t.EduList.Any() && t.QueryList.Any());
        }

        async private void ShowQueryReport(Document doc)
        {
            try
            {
                ProgressDialog.ShowTop(this.ParentForm, description: "Формирую отчеты");

                IList<QueryEduSummaryModel> nonQuerableModels =
                    _querySummaryModelCollection.Where(t => !t.EduList.Any() || !t.QueryList.Any()).ToList();
                if (nonQuerableModels.Any())
                {
                    var message = @"Отчеты по формам{0}{1}{2}не будут выполнены так как не выбрано либо ни одной ОО, либо ни одного запроса.";
                    var stringForms = string.Join(", ", nonQuerableModels.Select(t => string.Format("{0} за {1} год", t.Form.name, t.Year)));
                    var messageFormat = string.Format(message, Environment.NewLine, stringForms, Environment.NewLine);

                    this.ShowFlyoutMessageBox("Информация", messageFormat, FlyoutCommand.OK);
                }

                var querableModels = _querySummaryModelCollection.Where(t => t.EduList.Any() && t.QueryList.Any());
                var queryContainer = (TabbedGroup) this.View.ContentContainers.Single(t => t.Name == "tabbedGroupQueryReports");
                queryContainer.Items.Clear();
                var oldReportDocuments = this.View.Documents.Find(t => t.ControlTypeName == typeof (XtraReportViewControl).Name).ToArray();
                this.View.Documents.RemoveRange(oldReportDocuments);
                
                foreach (var queryModel in querableModels)
                {
                    //XtraReportViewControl reportControl = new XtraReportViewControl(this.View) {Report = report};
                    //из-за такого создания документа с контролом при переходе "назад" дублируются кнопки в onquerydocumentactions евенте.
                    //поэтому нужно создавать пустой документ и подгружать контрол в querycontrol эвенте
                    await ReportFactory.CreateQueryReportAsync(queryModel);
                    var reportDocument = (Document) this.View.AddDocument("Запрос", "Query");
                    reportDocument.ControlTypeName = typeof (XtraReportViewControl).Name;
                    reportDocument.Caption = string.Format("Запросы к форме<br>{0}", queryModel.Form.name) + (queryModel.Year > 0 ? "<br>за " + queryModel.Year + " год" : "");
                    queryContainer.Items.Add(reportDocument);
                }
                queryContainer.Parent = View.ActiveContentContainer;
                this.View.ActivateContainer(queryContainer);
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", ex.Message, FlyoutCommand.OK);
            }
            finally
            {
                ProgressDialog.HideTop();
            }
        }

        private void view_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow && e.HitInfo.InDataRow && e.MenuType == GridMenuType.Row)
            {
                e.Menu.Items.Clear();
                var deleteItem = new DXMenuItem("Убрать", (o, args) =>
                {
                    var view = (GridView)sender;
                    var row = e.HitInfo.RowHandle;

                    if (view.Name == this.gridViewSummary.Name)
                    {
                        var model = (QueryEduSummaryModel) view.GetRow(row);
                        if (model == _querySummaryModelCollection.Current)
                        {
                            this.gridViewEdu.ClearSelection();
                            this.queryControl.UnselectAll();
                        }
                    }
                    else
                    {
                        var model = (QueryEduSummaryModel) view.SourceRow;
                        if (model == _querySummaryModelCollection.Current)
                        {
                            if (view.Name == this.gridViewSummaryEdu.Name)
                            {
                                var edu = (edu) view.GetRow(row);

                                var datasourceIndex = this.eduBindingSource.IndexOf(edu);
                                var eduRow = this.gridViewEdu.GetRowHandle(datasourceIndex);
                                this.gridViewEdu.UnselectRow(eduRow);
                            }
                            else if (view.Name == this.gridViewSummaryQuery.Name)
                            {
                                var query = (query) view.GetRow(row);
                                this.queryControl.UnselectItem(query);
                            }
                        }
                    }
                    view.DeleteRow(row);
                });
                e.Menu.Items.Add(deleteItem);
            }
            else
            {
                e.Allow = false;
            }
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(CanShowQueryReport, ShowQueryReport) { Caption = "Вывести отчет", Image = Resources.glyphicons_119_table });

            this.windowsUIButtonPanelActions.Buttons.Clear();
            var showReportButton = new WindowsUIButton()
            {
                Caption = "Вывести отчет",
                Image = Resources.glyphicons_119_table
            };
            showReportButton.Click += (sender, eventArgs) =>
            {
                if (CanShowQueryReport(args.Document))
                    ShowQueryReport(args.Document);
            };
            this.windowsUIButtonPanelActions.ButtonClick += (sender, eventArgs) => this.flyoutPanelMenu.HidePopup();
            this.windowsUIButtonPanelActions.Buttons.Add(showReportButton);
        }

        private void gridViewSummary_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = e.RelationIndex == 0 ? "Организации" : "Запросы";
        }
    }
}