using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using EduFormManager.Forms.Reports;
using EduFormManager.Properties;
using Models;
using Models.Repo;
using PopupMenuShowingEventArgs = DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public partial class XtraQueryControl : XtraBaseControl, ISupportDocumentActions
    {
        private QuerySummaryModelCollection _querySummaryModelCollection;
        private form _selectedForm;
        private int _selectedYear;
        private bool _isOnlyPassport;

        private bool _isManualChecking = true;
        public XtraQueryControl(WindowsUIView view, Repository repo) 
            : base(view, repo)
        {
            InitializeComponent();
            Init();
            InitializeEventHandlers();
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
                if (forms.Any()) _selectedForm = forms.FirstOrDefault();
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
                OnIndexChangedSetDataSourceFor(sender);
                args.Value = _querySummaryModelCollection.Current;
            };

            this.buttonClosePopup.Click += (sender, args) => this.popupQuerySummaryModel.ClosePopup();

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
                catch (Exception) { }
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
            _querySummaryModelCollection = new QuerySummaryModelCollection();
            this.querySummaryModelBindingSource.DataSource = _querySummaryModelCollection;
        }

        private async void OnIndexChangedSetDataSourceFor(object sender)
        {
            int credId = Authentication.Credentials.CredId;
            if (Authentication.Credentials.IsMinistry)
            {
                credId = (await Repo.GetCredential("admin")).credentials_id;
            }
            this.queryControl.QueryDataSource = await Repo.GetQueries(credId, _selectedForm.form_id);
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
                int idx = this.eduBindingSource.List.IndexOf(edu);
                int row = this.gridViewEdu.GetRowHandle(idx);
                this.gridViewEdu.SelectRow(row);
            }
            this.queryControl.SelectRange(model.QueryList);
            _isManualChecking = true;
        }

        private void ChangeCurrentQuerySummaryModel()
        {
            if (!_querySummaryModelCollection.Contains(_selectedForm, _selectedYear))
                _querySummaryModelCollection.Add(new QuerySummaryModel(_selectedForm, _selectedYear));
            _querySummaryModelCollection.Current = _querySummaryModelCollection[_selectedForm, _selectedYear];
        }

        private void ResetGridViews()
        {
            var view = (GridView) gridControlQuerySummary.MainView;
            int rowHandle = view.GetRowHandle(this.querySummaryModelBindingSource.IndexOf(_querySummaryModelCollection.Current));
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

                IList<QuerySummaryModel> nonQuerableModels =
                    _querySummaryModelCollection.Where(t => !t.EduList.Any() || !t.QueryList.Any()).ToList();
                if (nonQuerableModels.Any())
                {
                    string message = @"Отчеты по формам{0}{1}{2}не будут выполнены так как не выбрано либо ни одной ОО, либо ни одного запроса.";
                    string stringForms = string.Join(", ", nonQuerableModels.Select(t => string.Format("{0} за {1} год", t.Form.name, t.Year)));
                    string messageFormat = string.Format(message, Environment.NewLine, stringForms, Environment.NewLine);

                    this.ShowFlyoutMessageBox("Информация", messageFormat, FlyoutCommand.OK);
                }

                IEnumerable<QuerySummaryModel> querableModels = _querySummaryModelCollection.Where(t => t.EduList.Any() && t.QueryList.Any());
                TabbedGroup queryContainer = (TabbedGroup) this.View.ContentContainers.Single(t => t.Name == "tabbedGroupQueryReports");
                queryContainer.Items.Clear();
                BaseDocument[] oldReportDocuments = this.View.Documents.Find(t => t.ControlTypeName == typeof (XtraReportViewControl).Name).ToArray();
                this.View.Documents.RemoveRange(oldReportDocuments);
                
                foreach (QuerySummaryModel queryModel in querableModels)
                {
                    XtraReport report = await ReportFactory.CreateQueryReportAsync(queryModel);

                    //XtraReportViewControl reportControl = new XtraReportViewControl(this.View) {Report = report};
                    //из-за такого создания документа с контролом при переходе "назад" дублируются кнопки в obquerydocumentactions.
                    //поэтому нужно создавать пустой документ и подгружать контрол в querycontrol эвенте
                    Document reportDocument = (Document) this.View.AddDocument("Запрос", "Query");
                    reportDocument.ControlTypeName = typeof (XtraReportViewControl).Name;
                    reportDocument.Caption = string.Format("Запросы к форме<br>{0}", queryModel.Form.name) + (queryModel.Year > 0 ? "<br>за " + queryModel.Year + " год" : "");
                    queryContainer.Items.Add(reportDocument);
                }

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
                    int row = e.HitInfo.RowHandle;

                    if (view.Name == this.gridViewSummary.Name)
                    {
                        var model = (QuerySummaryModel) view.GetRow(row);
                        if (model == _querySummaryModelCollection.Current)
                        {
                            this.gridViewEdu.ClearSelection();
                            this.queryControl.UnselectAll();
                        }
                    }
                    else
                    {
                        var model = (QuerySummaryModel) view.SourceRow;
                        if (model == _querySummaryModelCollection.Current)
                        {
                            if (view.Name == this.gridViewSummaryEdu.Name)
                            {
                                var edu = (edu) view.GetRow(row);

                                int datasourceIndex = this.eduBindingSource.IndexOf(edu);
                                int eduRow = this.gridViewEdu.GetRowHandle(datasourceIndex);
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
        }

        private void gridViewSummary_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = e.RelationIndex == 0 ? "Организации" : "Запросы";
        }
    }
}