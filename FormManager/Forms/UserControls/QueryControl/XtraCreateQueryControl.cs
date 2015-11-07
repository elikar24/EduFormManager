using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Menu;
using EduFormManager.Properties;
using EduFormManager.Utils;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public partial class XtraCreateQueryControl : XtraBaseControl, ISupportDocumentActions
    {
        private form _selectedForm;
        private XtraDictionaryEditQueryControl _editQueryControl;
        private Point _splitterLocation;
        private new List<query> _editedList;

        public List<query_autocomplete_part> QueryAutocomletePartSource
        {
            set { _editQueryControl.QueryAutocompletePartSource = value; }
        }

        public List<query_head_part> QueryHeadPartSource
        {
            set { _editQueryControl.QueryHeadPartSource = value; }
        }

        public XtraCreateQueryControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();
            InitializeProps();
            _editedList = new List<query>();
        }

        private void InitializeProps()
        {
            this.listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox1.MeasureItem += GuiUtility.lst_MeasureItem;
            this.listBox1.DrawItem += GuiUtility.lst_DrawItem;

            this.queryBindingSource.AllowNew = true;

            this.queryBindingSource.ListChanged += (s, e) => 
            {
                if (e.ListChangedType == ListChangedType.ItemChanged)
                {
                    var query = (query) this.queryBindingSource.Current;
                    if (!_editedList.Contains(query))
                        _editedList.Add(query);
                }
            };
            _editQueryControl = (XtraDictionaryEditQueryControl) this.flyoutPanel1.Controls.Find("xtraDictionaryEditQueryControl1", false).First();
            _editQueryControl.Repo = this.Repo;
            _editQueryControl.QueriesCreated += async (s, e) =>
            {
                if (!e.Canceled)
                {
                    var queryList = e.QueryList;
                    ProgressDialog.ShowTop(this.ParentForm, description: "Сохранение");
                    await SaveQueries(queryList, false, true);
                    ProgressDialog.HideTop();
                    this.queryBindingSource.ResetBindings(false);
                    this.listBox1.ResetBindings();
                }
                this.flyoutPanel1.HidePopup();
            };
            _editQueryControl.CellAddressClicked += (s, e) =>
            {
                var cellAddress = e.Value;
                SetActiveWorksheetFromCell(cellAddress);
            };
            this.flyoutPanel1.Shown += (s, e) =>
            {
                _splitterLocation = this.splitterItem1.Location;
                _editQueryControl.Clear();
                this.splitterItem1.Location = new Point(_editQueryControl.Width - this.splitterItem1.Width, _splitterLocation.Y);
            };
            this.flyoutPanel1.Hidden += (s, e) =>
            {
                this.splitterItem1.Location = _splitterLocation;
            };
        }

        private void SetActiveWorksheetFromCell(string cellReference)
        {
            var worksheetRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_WORKSHEET_REGEXP);
            var worksheetMatch = worksheetRegex.Match(cellReference);
            if (worksheetMatch.Success)
            {
                var worksheetName = worksheetMatch.Groups["Workbook"].Value;
                if (!string.IsNullOrEmpty(worksheetName))
                {
                    var worksheet = this.spreadsheetControlQueries.Document.Worksheets[worksheetName];
                    this.spreadsheetControlQueries.Document.Worksheets.ActiveWorksheet = worksheet;

                    var cellRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_CELL_REGEXP);
                    var cellMatch = cellRegex.Match(cellReference);
                    if (cellMatch.Success)
                    {
                        var cellAddress = cellMatch.Groups["Cell"].Value;
                        if (!string.IsNullOrEmpty(cellAddress))
                        {
                            worksheet.SelectedCell = worksheet.Cells[cellAddress];
                        }
                    }
                }
            }
        }

        private Task SaveQueries(List<query> queryList, bool clearSourceList = false, bool addToBindingSource = false)
        {
            return Task.Run(() =>
            {
                var queryListToSave = new List<query>();
                foreach (var query in queryList)
                {
                    if (query.form != null && !string.IsNullOrEmpty(query.title) &&
                        !string.IsNullOrEmpty(query.content))
                    {
                        query.credential = Repo.GetCredentialSync(Authentication.Credentials.CredId);
                        queryListToSave.Add(query);
                        if (addToBindingSource) this.queryBindingSource.Add(query);
                    }
                }
                Repo.AddRange(queryListToSave);
                Repo.SaveChanges();
                if (clearSourceList) queryList.Clear();
            });
        }

        public void Save()
        {
            Save(null);
        }

        async protected override void Save(Document doc)
        {
            if (!CanSave(doc))
            {
                this.ShowFlyoutMessageBox("Информация", "Не все поля заполнены", FlyoutCommand.OK);
                return;
            }
            ProgressDialog.ShowTop(this.ParentForm, description: "Сохраняю");
            await SaveQueries(_editedList, true);
            ProgressDialog.HideTop();
        }

        public bool CanSave()
        {
            return CanSave(null);
        }

        protected override bool CanSave(Document doc)
        {
            return queryBindingSource.Current != null && 
                this.comboBoxForm.SelectedItem != null && 
                !string.IsNullOrEmpty(textBoxCreateQueryName.Text) && 
                !string.IsNullOrEmpty(textBoxCreateQueryCell.Text);
        }

        public void New()
        {
            New(null);
        }

        protected override void New(Document doc)
        {
            _editQueryControl.SelectedForm = ((templated_form_data) this.comboBoxForm.SelectedItem).form;
            this.flyoutPanel1.ShowPopup();
        }

        public bool CanNew()
        {
            return CanNew(null);
        }

        protected override bool CanNew(Document doc)
        {
            return true;
        }

        public void Remove()
        {
            Remove(null);
        }

        public bool CanRemove()
        {
            return CanRemove(null);
        }

        protected override async void Remove(Document doc)
        {
            if (!CanRemove(doc))
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не выбран объект для удаления", FlyoutCommand.OK);
                return;
            }
            var query = (query)queryBindingSource.Current;
            Repo.Remove(query);
            await Repo.SaveChangesAsync();
            queryBindingSource.Remove(query);
            queryBindingSource.EndEdit();
        }

        protected override bool CanRemove(Document doc)
        {
            return queryBindingSource.Current != null;
        }

        private void spreadsheetControlQueries_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                e.Menu.Items.Clear();
                var i = new SpreadsheetMenuItem("Использовать в запросе", (o, args) =>
                {
                    string cellAddress = spreadsheetControlQueries.ActiveWorksheet.SelectedCell.GetReferenceA1(ReferenceElement.IncludeSheetName | ReferenceElement.RowAbsolute | ReferenceElement.ColumnAbsolute);
                    if (this.flyoutPanel1.IsPopupOpen)
                    {
                        _editQueryControl.SetCellAddressToCurrentQuery(cellAddress);
                    }
                    else
                    {
                        var query = (query) this.queryBindingSource.Current;
                        if (query != null)
                        {
                            textBoxCreateQueryCell.Text = cellAddress;
                            query.content = cellAddress;
                            if (!_editedList.Contains(query))
                                _editedList.Add(query);
                        }
                    }
                });
                e.Menu.Items.Add(i);
            }
        }

        async private void comboBoxCreateQueryForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox) sender;
            var template = (templated_form_data) combo.SelectedItem;
            if (template == null)
            {
                return;
            }
            var fileData = template.file_data;
            using (var ms = new MemoryStream(fileData))
            {
                var format = DocumentFormat.OpenXml;
                this.spreadsheetControlQueries.LoadDocument(ms, format);
            }
            _selectedForm = template.form;

            this.Enabled = false;
            var queries = await Repo.GetQueries(template.form_id);
            queryBindingSource.DataSource = queries;
            this.Enabled = true;
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(New) { Caption = "Создать", Image = Resources.glyphicons_432_plus });
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(Remove) { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (query) this.listBox1.SelectedItem;
            if (query != null)
            {
                var cellAddress = query.content;
                SetActiveWorksheetFromCell(cellAddress);
            }
        }

        private void comboBoxForm_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((templated_form_data) e.ListItem).form.name;
        }

        
    }
}
