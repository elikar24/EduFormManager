using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraReports.Templates;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Menu;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Properties;
using EduFormManager.Utilities;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryTemplateControl : XtraBaseControl, ISupportDocumentActions
    {
        private bool _isEditingMode;
        private List<templated_form_data> _editedTemplates;
        private templated_form_data _lastSelectedTemplate;


        public XtraDictionaryTemplateControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();

            layoutControlItemTemplate.Enabled = _isEditingMode = true;
            layoutControlItemForm.Enabled = false;

            _editedTemplates = new List<templated_form_data>();
        }

        public override List<templated_form_data> TemplatedFormDataDataSource
        {
            set
            {
                templatedFormDataBindingSource.DataSource = value;
                UpdateData();
            }
        }

        public byte[] GetDocumentBytes()
        {
            byte[] data;
            using (var ms = new MemoryStream())
            {
                spreadsheetTemplate.SaveDocument(ms, DocumentFormat.OpenXml);
                data = ms.ToArray();
            }
            return data;
        }

        public void New()
        {
            New(null);
        }
        protected override void New(Document doc)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.ShowDialog(this);
                    if (string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        return;
                    }
                    spreadsheetTemplate.LoadDocument(openFileDialog.FileName);
                    spreadsheetTemplate.Document.History.IsEnabled = true;

                    var data = this.GetDocumentBytes();
                    templated_form_data template = null;
                    if (!_isEditingMode)
                    {
                        template = Repo.Db.templated_form_data.Create();
                        template.file_data = data;
                        template.form = (form)formBindingSource.Current;

                        formBindingSource.Remove(template.form);
                        templatedFormDataBindingSource.Add(template);
                    }
                    else
                    {
                        if (templatedFormDataBindingSource.Current != null)
                        {
                            template = (templated_form_data) templatedFormDataBindingSource.Current;
                            template.file_data = data;
                        }
                    }
                    if (template != null && !_editedTemplates.Contains(template))
                    {
                        _editedTemplates.Add(template);
                        this.listBoxTemplatedForm.Invalidate();
                        this.RefreshTemplateList();
                    }
                }
            }
            catch (IOException ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не удалось открыть файл шаблона");
            }
        }
        public bool CanNew()
        {
            return CanNew(null);
        }
        protected override bool CanNew(Document doc)
        {
            return true;
        }
        public void Save()
        {
            Save(null);
        }
        protected override async void Save(Document doc)
        {
            try
            {
                templatedFormDataBindingSource.EndEdit();
                ProgressDialog.ShowTop(this.ParentForm, description: "Сохраняю");
                foreach (var template in _editedTemplates)
                {
                    if (template == null) continue;
                    //var formId = template.form.form_id;
                    //if ((await Repo.Db.templated_form_data.CountAsync(t => t.form_id == formId)) == 0)
                    //    Repo.Db.templated_form_data.Add(template);

                    if (template.templated_form_data_id == 0)
                        Repo.Db.templated_form_data.Add(template);
                }
                await Repo.Db.SaveChangesAsync();
                _editedTemplates.Clear();
                ProgressDialog.HideTop();
                this.ShowFlyoutMessageBox("", "Сохранено");

                this.RefreshTemplateList();
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не удалось сохранить один или несколько шаблонов");
            }
        }

        public bool CanSave()
        {
            return CanSave(null);
        }
        protected override bool CanSave(Document doc)
        {
            return templatedFormDataBindingSource.Current != null && spreadsheetTemplate.Document != null;
        }
        public void Remove()
        {
            Remove(null);
        }
        protected override async void Remove(Document doc)
        {
            var template = (templated_form_data) templatedFormDataBindingSource.Current;
            Repo.Db.templated_form_data.Remove(template);
            templatedFormDataBindingSource.Remove(template);
            templatedFormDataBindingSource.EndEdit();
            await Repo.Db.SaveChangesAsync();
            UpdateData();
        }
        public bool CanRemove()
        {
            return CanRemove(null);
        }
        protected override bool CanRemove(Document doc)
        {
            return this.listBoxTemplatedForm.SelectedItem != null;
        }

        protected async void UpdateData()
        {
            templatedFormDataBindingSource.DataSource = await Repo.GetTemplates();
            formBindingSource.DataSource = await Repo.GetFormsWithoutTemplates();
        }

        async private void listBoxTemplatedForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var template = this.listBoxTemplatedForm.SelectedItem as templated_form_data;
            if (template == null || (_lastSelectedTemplate != null && template.form == _lastSelectedTemplate.form))
            {
                return;
            }
            _lastSelectedTemplate = template;

            var excelData = template.file_data;
            if (excelData == null)
            {
                return;
            }
            this.formulaEditControl1.Text = string.Empty;
            using (var ms = new MemoryStream(excelData))
            {
                var format = DocumentFormat.OpenXml;
                spreadsheetTemplate.LoadDocument(ms, format);
                spreadsheetTemplate.Document.History.IsEnabled = true;
            }
            var form = template.form;
            var checkData = form.check_file_data;
            this.layoutControl1.Enabled = false;
            if (checkData != null)
            {
                var textContent = await Task.Run(() =>
                {
                    var crc = FileUtility.GetCRC32AsHexString(checkData);
                    var encoding = Encoding.UTF8;
                    return crc.Equals(form.check_file_md5) ? encoding.GetString(checkData) : null;
                });
                if (textContent != null)
                {
                    this.formulaEditControl1.Text = textContent;
                }
                else
                {
                    this.formulaEditControl1.Text = string.Empty;
                    this.ShowFlyoutMessageBox("Ошибка загрузки формул", "Ошибка целостности данных", FlyoutCommand.OK);
                }
            }
            try
            {
                this.layoutControl1.Enabled = true;
            }
            catch (NullReferenceException)
            {
                //похоже на баг в компонентах Devexpress
            }
        }

        private void ToggleEditingMode(Document doc)
        {
            _isEditingMode = !_isEditingMode;
            layoutControlItemForm.Enabled = !_isEditingMode;
            layoutControlItemTemplate.Enabled = _isEditingMode;
            formulaEditControl1.Enabled = _isEditingMode;
            if (!_isEditingMode)
            {
                comboBoxRemainingTemplatedForm_SelectedIndexChanged(this.comboBoxRemainingTemplatedForm, new EventArgs());
            }
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentCheckAction(() => !_isEditingMode, ToggleEditingMode) { Caption = "Новый", Image = Resources.glyphicons_432_plus });
            args.DocumentActions.Add(new DocumentAction(New)                { Caption = "Открыть файл", Image = Resources.glyphicons_144_folder_open });
            args.DocumentActions.Add(new DocumentAction(CanSave, Save)      { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(CanRemove, Remove)  { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }

        private void comboBoxRemainingTemplatedForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxRemainingTemplatedForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.spreadsheetTemplate.CreateNewDocument();
            this.formulaEditControl1.Text = string.Empty;
            this.listBoxTemplatedForm.ClearSelected();
        }

        private void spreadsheetTemplate_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                e.Menu.Items.Clear();
                var ranges = this.spreadsheetTemplate.GetSelectedRanges();
                var itemAddLeft         = new SpreadsheetMenuItem("Добавить cлева", (o, args) => this.formulaEditControl1.AddToLeftPart(ranges));
                var itemReplaceLeft     = new SpreadsheetMenuItem("Заменить слева", (o, args) => this.formulaEditControl1.ReplaceLeftPart(ranges));
                var itemAddRight        = new SpreadsheetMenuItem("Добавить справа", (o, args) => this.formulaEditControl1.AddToRightPart(ranges));
                var itemReplaceRight    = new SpreadsheetMenuItem("Заменить справа", (o, args) => this.formulaEditControl1.ReplaceRightPart(ranges));

                itemAddLeft.BeginGroup = true;
                e.Menu.Items.Add(itemAddLeft);
                e.Menu.Items.Add(itemReplaceLeft);
                itemAddRight.BeginGroup = true;
                e.Menu.Items.Add(itemAddRight);
                e.Menu.Items.Add(itemReplaceRight);
            }
        }

        private void listBoxTemplatedForm_Format(object sender, ListControlConvertEventArgs e)
        {
            var template = (templated_form_data) e.ListItem;
            if (_editedTemplates.Contains(template))
                e.Value = template.form.name + "*";
            else
                e.Value = template.form.name;
        }

        private void formulaEditControl1_Leave(object sender, EventArgs e)
        {
            if (!this.formulaEditControl1.TextModified) return;
            var template = this.listBoxTemplatedForm.SelectedItem as templated_form_data;
            if (template == null) return;
            var form = template.form;
            var encoding = Encoding.UTF8;
            form.check_file_data = encoding.GetBytes(this.formulaEditControl1.Text);
            form.check_file_md5 = FileUtility.GetCRC32AsHexString(form.check_file_data);

            if (!_editedTemplates.Contains(template))
            {
                _editedTemplates.Add(template);
                this.RefreshTemplateList();
            }

        }

        public void RefreshTemplateList()
        {
            this.listBoxTemplatedForm.DataSource = null;
            this.listBoxTemplatedForm.DataSource = templatedFormDataBindingSource;
        }

        private void spreadsheetTemplate_Leave(object sender, EventArgs e)
        {
            UpdateTemplate();
        }

        private void spreadsheetTemplate_ActiveSheetChanged(object sender, ActiveSheetChangedEventArgs e)
        {
            UpdateTemplate();
        }

        private void UpdateTemplate()
        {
            if (!this.spreadsheetTemplate.Modified) return;
            var template = this.listBoxTemplatedForm.SelectedItem as templated_form_data;
            if (template == null) return;
            template.file_data = this.GetDocumentBytes();

            if (!_editedTemplates.Contains(template))
            {
                _editedTemplates.Add(template);
                this.RefreshTemplateList();
            }
        }
    }
}