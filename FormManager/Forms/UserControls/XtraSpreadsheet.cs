using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSpreadsheet;
using EduFormManager.Forms.UserControls.MunicipalityFormulaPeek;
using EduFormManager.Properties;
using EduFormManager.Utilities;
using EduFormManager.Utils;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraSpreadsheet : XtraBaseControl, ISupportDocumentActions, ISupportNavigation
    {
        public enum ControlMode
        {
            New, Edit, Disabled
        }

        public enum FormSource
        {
            File, Template
        }

        public ControlMode Mode { get; set; }
        public FormSource Source { get; set; }
        public bool IsLocalSaved { get; private set; }
        public bool IsSaved { get; private set; }

        private form _selectedForm;
        private form _originalForm;
        private IForm _formData;
        private DateTime _selectedDate;

        public IForm FormData
        {
            get { return _formData; }
            set
            {
                if (value == null) return;
                _selectedForm = value.form;
                _originalForm = value.form;
                _formData = value;
            }
        }

        public XtraSpreadsheet(WindowsUIView view, Repository repo) 
            : base(view, repo)
        {
            InitializeComponent();
            InitializeProps();
            this.flyoutPanelActions.OwnerControl = view.Manager.ContainerControl;
        }

        private void InitializeProps()
        {
            this.Source = FormSource.Template;
            
            IsSaved = false;
            IsLocalSaved = false;

            this.spreadsheetControl.DocumentLoaded += (s, e) => 
                this.spreadsheetControl.Document.Worksheets.ActiveWorksheet = this.spreadsheetControl.Document.Worksheets.FirstOrDefault();

            this.formBindingSource.DataSourceChanged += (s, e) => 
            {
                var formList = this.formBindingSource.List as List<form>;
                CreateFormMenuStrip(formList);
            };

            this.buttonMenuFlyout.Click += (sender, eventArgs) =>
            {
                if (this.flyoutPanelActions.IsPopupOpen)
                {
                    this.flyoutPanelActions.HidePopup();
                    ((SimpleButton) sender).Text = "Меню";
                }
                else
                {
                    this.flyoutPanelActions.ShowPopup();
                    ((SimpleButton) sender).Text = "Закрыть";
                }
            };

            this.flyoutPanelActions.ButtonClick += (sender, args) =>
            {
                if (args.Button.Tag.ToString() == "Close")
                    this.flyoutPanelActions.HidePopup();
            };

            var dateList = new List<DateTime> {  DateTime.Now, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(-2)};
            this.comboBoxDate.DataSource = dateList;
            this.comboBoxDate.DisplayMember = "Year";
            this.comboBoxDate.ValueMember = "Date";

            this.comboBoxDate.SelectedIndexChanged += (sender, args) =>
            {
                _selectedDate = (DateTime) this.comboBoxDate.SelectedItem;
            };

            _selectedDate = DateTime.Now;
        }

        private void CreateFormMenuStrip(ICollection<form> formList)
        {
            var group = formList.GroupBy(x => x.form_type);
            foreach (var groupItem in group)
            {
                if (groupItem.Key == null)
                    continue;
                var typeToolItem = new ToolStripMenuItem()
                {
                    Text = groupItem.Key.name,
                    Tag = groupItem.Key
                };
                toolStripDropDownButtonForms.DropDownItems.Add(typeToolItem);
                foreach (var item in groupItem)
                {
                    var formToolItem = new ToolStripMenuItem()
                    {
                        Text = item.name,
                        Tag = item
                    };
                    formToolItem.Click += (ts, te) =>
                    {
                        try
                        {
                            var menuItem = (ToolStripMenuItem)ts;
                            _selectedForm = (form)menuItem.Tag;
                            this.toolStripDropDownButtonForms.Text = this.ActiveForm.name;
                            if (this.Mode == ControlMode.New && this.Source == FormSource.Template)
                                LoadTemplateAsync(_selectedForm);
                            this.View.ActiveContentContainer.Caption = _selectedForm.ToString();
                        }
                        catch (Exception ex)
                        {
                            this.ShowFlyoutMessageBox("Ошибка", ex.Message, FlyoutCommand.OK);
                        }
                    };
                    typeToolItem.DropDownItems.Add(formToolItem);
                }
            }
            _selectedForm = formList.FirstOrDefault();
            if (_selectedForm != null)
                this.View.ActiveContentContainer.Caption = _selectedForm.name;
        }

        private void SetEditEnabled(bool enabled)
        {
            //this.spreadsheetControl.ReadOnly = !enabled;
            this.layoutControlItem6.Visibility = enabled ? LayoutVisibility.Never : LayoutVisibility.Always;
            var saveButton = this.windowsUIButtonPanelActions.Buttons.SingleOrDefault(t => ((WindowsUIButton)t).Tag.ToString() == "Save") as WindowsUIButton;
            if (saveButton != null)
            {
                saveButton.Enabled = enabled;
            }
        }

        public void LoadDocument()
        {
            if (this.FormData == null)
                throw new ArgumentException("FormData was not specified", "FormData");

            this.spreadsheetControl.CreateNewDocument();
            byte[] fileContents = this.FormData.file.contents;

            DocumentFormat documentFormat = this.FormData.document_format.IsOpenXml()
                ? DocumentFormat.OpenXml
                : DocumentFormat.Xls;
            this.spreadsheetControl.LoadDocument(fileContents, documentFormat);
            this.spreadsheetControl.Document.Worksheets.ActiveWorksheet = this.spreadsheetControl.Document.Worksheets.FirstOrDefault();
        }

        public void LoadDocument(IForm formData)
        {
            this.FormData = formData;
            this.LoadDocument();
        }

        public Status FormStatus { get; set; }

        public form ActiveForm
        {
            set
            {
                if (value != null && this.formBindingSource.List.Contains(value))
                {
                    this._selectedForm = value;
                    this.toolStripDropDownButtonForms.Text = value.name;
                    this.View.ActiveContentContainer.Subtitle = value.ToString();
                    if (this.Mode == ControlMode.New && this.Source == FormSource.Template)
                        LoadTemplateAsync(value);
                }
            }
            get
            {
                return _selectedForm;
            }
        }

        public void SaveLocal()
        {
            SaveLocal(null);
        }

        public void SaveLocal(Document doc)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.FileName = string.Format("{0}-{1}-{2}.xlsx", Authentication.Credentials.Name, ActiveForm, DateTime.Now.ToString("yy-MM-dd"));
                saveFileDialog.Filter = "Excel 2007-2013 (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog(this) != DialogResult.OK) 
                    return;
                try
                {
                    using (Stream fs = saveFileDialog.OpenFile())
                    {
                        this.spreadsheetControl.SaveDocument(fs, DocumentFormat.OpenXml);
                        this.ShowFlyoutMessageBox("Информация", "Файл сохранен.", FlyoutCommand.OK);
                        this.IsLocalSaved = true;
                    }
                }
                catch (Exception ex)
                {
                    this.ShowFlyoutMessageBox("Ошибка", "Не удалось сохранить файл\n" + ex.Message, FlyoutCommand.OK);                    
                }
 
            }
        }

        private void ExecuteUpload(Document doc, form form, int year, Status status)
        {
            switch (doc.ControlName)
            {
                case "UploadSheetFromFile":
                case "UploadSheetFromTemplate":
                    this.UploadNewFormData(form, year, status);
                    break;
                case "FormData":
                case "FormData1":
                case "FormData2":
                    this.UploadEduFormDataChanges(form, year, status);
                    break;
                case "FormData3":
                case "FormData4":
                    this.UploadMunitFormDataChanges(form, year, status);
                    break;
                default:
                    this.ShowFlyoutMessageBox("Информация", "Нечего отправлять.", FlyoutCommand.OK);
                    break;
            }
        }

        public void Save()
        {
            Save(null);
        }
        protected override void Save(Document doc)
        {
            if (ActiveForm == null)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не выбрана форма для отправки", FlyoutCommand.OK);
                return;
            }
            if (this.spreadsheetControl.Document == null)
            {
                this.ShowFlyoutMessageBox("Информация", "Нечего отправлять", FlyoutCommand.OK);
                return;
            }
            var continueToSave = this.ShowFlyoutMessageBox(
                    "Подтверждение",
                    String.Format("Будет загружена форма {0} из {1}. Продолжить загрузку на сервер?", ActiveForm.name, 
                        Source == FormSource.File ? "файла" : 
                        Source == FormSource.Template ? "шаблона" : "ниоткуда"),
                    FlyoutCommand.Yes, FlyoutCommand.No);
            if (continueToSave == DialogResult.No)
                return;
            var formStatus = Status.OK;
            if (spreadsheetControl.Tag.ToString() != "Checked")
            {
                continueToSave = this.ShowFlyoutMessageBox(
                    "Информация",
                    "Форма заполнена с ошибками или не была проверена.\nПеред загрузкой на сервер необходимо, чтобы заполненная форма не содержала ошибок.\nПродолжить загрузку на сервер?",
                    FlyoutCommand.Yes, FlyoutCommand.No);
                if (continueToSave == DialogResult.Yes)
                {
                    formStatus = Status.WithErrors;
                }
                else
                {
                    return;
                }
            }
            var dateToExpire = ActiveForm.submission_date;
            
            if (DateTime.Now.Year == _selectedDate.Year)
            {
                dateToExpire = new DateTime(DateTime.Now.Year, dateToExpire.Month, dateToExpire.Day);
                if (dateToExpire < DateTime.Now)
                {
                    this.ShowFlyoutMessageBox("Информация", "Срок сдачи формы просрочен. Форма будет загружена с соответствующей пометкой.", FlyoutCommand.OK);
                    formStatus = formStatus == Status.OK 
                        ? Status.Expired 
                        : Status.WithErrors | Status.Expired;
                }
            }
            ExecuteUpload(doc, ActiveForm, _selectedDate.Year, formStatus);
        }

        public bool CanSave()
        {
            return CanSave(null);
        }

        protected override bool CanSave(Document doc)
        {
            return ActiveForm != null;
        }

        public void Check()
        {
            Check(null);
        }
        async public void Check(Document doc)
        {
            if (ActiveForm == null)
            {
                return;
            }
            var checkdata = ActiveForm.check_file_data;

            if (checkdata == null)
            {
                this.ShowFlyoutMessageBox("Ошибка", 
                    string.Format("Для формы {0} не загружен файл с формулами.\nОбратитесь к администратору.", ActiveForm.name), 
                    FlyoutCommand.OK);
                return;
            }
            var encoding = Encoding.UTF8;
            var crc = FileUtility.GetCRC32AsHexString(checkdata);
            if (!crc.Equals(ActiveForm.check_file_md5))
            {
                this.ShowFlyoutMessageBox("Ошибка", 
                    string.Format("Ошибка целостности данных в файле проверки для формы {0}.\nОбратитесь к Администратору.", ActiveForm.name), 
                    FlyoutCommand.OK);
                return;
            }
            ProgressDialog.ShowTop(this.ParentForm, description: "Проверка формы...");

            var resultList = await FormulaUtility.GetCheckResultsAsync(checkdata, encoding, this.spreadsheetControl.Document);
            ProgressDialog.HideTop();
            if (resultList.Count > 0)
            {
                spreadsheetControl.Tag = "Unchecked";
                this.ShowFlyoutMessageBox("Информация",
                    "Форма заполнена с ошибками." +
                    (CheckExpressionParser.IsLastCheckFileHadErrors ? "\nФайл с формулами содержит ошибки, проверка выполнена частично." : string.Empty), 
                    FlyoutCommand.OK);
                var resultForm = new CheckResultSummaryForm();
                resultForm.SetData(resultList);
                resultForm.Show(this);
            }
            else
            {
                if (CheckExpressionParser.IsLastCheckFileHadErrors)
                {
                    this.ShowFlyoutMessageBox("Информация", "Файл с формулами содержит ошибки, проверка выполнена частично.\nОбратитесь к администратору.", FlyoutCommand.OK);
                }
                else
                {
                    spreadsheetControl.Tag = "Checked";
                    DialogResult continueToSave = this.ShowFlyoutMessageBox("Информация",
                        string.Format("Форма {0} не содержит ошибок. Загрузить на сервер?", ActiveForm.name),
                        FlyoutCommand.Yes, FlyoutCommand.No);
                    if (continueToSave == DialogResult.Yes)
                    {
                        var formStatus = Status.OK;
                        var dateToExpire = ActiveForm.submission_date;
                        
                        if (DateTime.Now.Year == _selectedDate.Year)
                        {
                            dateToExpire = new DateTime(DateTime.Now.Year, dateToExpire.Month, dateToExpire.Day);
                            if (dateToExpire < DateTime.Now)
                            {
                                this.ShowFlyoutMessageBox("Информация", "Срок сдачи формы просрочен. Форма будет загружена с соответствующей пометкой.", FlyoutCommand.OK);
                                formStatus = Status.Expired;
                            }
                        }
                        ExecuteUpload(doc, ActiveForm, _selectedDate.Year, formStatus);
                    }
                }
            }
        }
        public bool CanCheck()
        {
            return CanCheck(null);
        }
        public bool CanCheck(Document doc)
        {
            return ActiveForm != null;
        }

        async private void UploadNewFormData(form form, int year, Status status)
        {
            try
            {
                IForm formData = null;
                IForm possibleFormData = null;
                byte[] bytes = null;
                document_format documentFormat;
                var cred = Authentication.Credentials;
                using (new MarqueeProgressDialog(this.ParentForm, description: "Обработка"))
                {
                    if (cred.IsEdu)
                        possibleFormData = await Repo.FindEduFormData(form.form_id, cred.EduId, year);
                    else if (cred.IsMunicipality)
                        possibleFormData = await Repo.FindMunicipalityFormData(form.form_id, cred.MunitId, year);

                    bytes = await Task.Run(() => this.spreadsheetControl.Document.SaveDocument(DocumentFormat.OpenXml));
                    documentFormat = await Repo.GetDocumentFormat_("xlsx");
                    
                }
                if (possibleFormData != null)
                {
                    var message = string.Format("Форма {0} {1} уже загружена и датируется {2}. Форма будет заменена.\nПродолжить?",
                        possibleFormData.form.name,
                        cred.IsEdu
                            ? string.Format("для организации {0}", cred.Name)
                            : string.Format("для муниципалтета {0}", cred.Name),
                        possibleFormData.send_date.ToString("d MMMM yyyy"));
                    var answer = this.ShowFlyoutMessageBox("Информация", message, FlyoutCommand.OK, FlyoutCommand.Cancel);
                    switch (answer)
                    {
                        case DialogResult.OK:
                            possibleFormData.document_format = documentFormat;
                            possibleFormData.send_date = _selectedDate;
                            possibleFormData.status = (int)status;
                            possibleFormData.file.contents = bytes;
                            formData = possibleFormData;
                            break;
                        default:
                            this.ShowFlyoutMessageBox("Информация", "Форма не загружена.", FlyoutCommand.OK);
                            return;
                    }
                }
                else
                {
                    if (cred.IsEdu)
                    {
                        formData = Repo.Create<edu_form_data>();
                    }
                    else if (cred.IsMunicipality)
                    {
                        formData = Repo.Create<municipality_form_data>();
                    }
                    formData.document_format = documentFormat;
                    formData.file = new file()
                    {
                        contents = bytes, 
                        code_page = Encoding.UTF8.CodePage
                    };
                    formData.form = form;
                    formData.send_date = _selectedDate;
                    formData.status = (int)status;
                }

                using (new MarqueeProgressDialog(this.ParentForm, description: "Отправка формы"))
                {
                    if (cred.IsEdu)
                    {
                        var data = (edu_form_data)formData;
                        data.edu = await Repo.GetEdu(cred.EduId);
                        if (data.id == 0)
                        {
                            formData = Repo.Add<edu_form_data>(data);
                        }
                    }
                    else if (Authentication.Credentials.IsMunicipality)
                    {
                        var data = (municipality_form_data)formData;
                        data.municipality = await Repo.GetMunicipality(cred.MunitId);
                        if (data.id == 0)
                        {
                            formData = Repo.Add<municipality_form_data>(data);
                        }
                    }
                    await Repo.SaveChangesAsync();
                }
                
                this.ShowFlyoutMessageBox("Информация",
                             String.Format("Загружена форма {0} за {1}.", formData.form.name, formData.send_date.ToString("d MMMM yyyy")),
                             FlyoutCommand.OK);
                IsSaved = true;
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Форма не загружена.\n" + ex.Message, FlyoutCommand.OK);
            }
        }

        async private void UploadEduFormDataChanges(form form, int year, Status status)
        {
            var formData = (edu_form_data) this.GetChangedFormData(form, status);
            try
            {
                if (_originalForm != formData.form)
                {
                    edu_form_data possibleFormData = null;
                    using (new MarqueeProgressDialog(this.ParentForm, description: "Загрузка"))
                    {
                        possibleFormData = await Repo.FindEduFormData(formData.form.form_id, formData.edu.edu_id, year);
                    }
                    if (possibleFormData != null)
                    {
                        this.ShowFlyoutMessageBox("Информация",
                            string.Format("Форма {0} уже загружена {1}", possibleFormData.form.name,
                            possibleFormData.send_date.ToString("dd MMMM yyyy")), FlyoutCommand.OK);
                        return;
                    }
                }
                using (new MarqueeProgressDialog(this.ParentForm, description: "Сохранение изменений"))
                {
                    await Repo.SaveChangesAsync();
                }
                this.ShowFlyoutMessageBox("Информация", "Изменения сохранены", FlyoutCommand.OK);
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Форма не загружена." + Environment.NewLine + ex.Message, FlyoutCommand.OK);
            }
            
        }

        async private void UploadMunitFormDataChanges(form form, int year, Status status)
        {
            var formData = (municipality_form_data) this.GetChangedFormData(form, status);
            try
            {
                if (_originalForm != formData.form)
                {
                    municipality_form_data possibleFormData = null;
                    using (new MarqueeProgressDialog(this.ParentForm, description: "Загрузка"))
                    {
                        possibleFormData = await Repo.FindMunicipalityFormData(formData.form_id, formData.municipality_id, year);
                    }
                    if (possibleFormData != null)
                    {
                        this.ShowFlyoutMessageBox("Информация",
                            String.Format("Форма {0} уже загружена {1}", possibleFormData.form.name,
                                possibleFormData.send_date.ToString("dd MMMM")), FlyoutCommand.OK);
                        return;
                    }
                }
                using (new MarqueeProgressDialog(this.ParentForm, description: "Сохранение изменений"))
                {
                    await Repo.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Форма не загружена.\n" + ex.Message, FlyoutCommand.OK);
            }
        }

        private IForm GetChangedFormData(form form, Status status)
        {
            var bytes = this.spreadsheetControl.Document.SaveDocument(DocumentFormat.OpenXml);
            var formData = this.FormData;
            formData.send_date = _selectedDate;
            formData.form = form;
            formData.status = (int)status;
            formData.file.contents = bytes;
            return formData;
        }

        private void LoadTemplateAsync(form form)
        {
            this.Enabled = false;
            try
            {
                var template = form.templated_form_data;
                if (template != null)
                {
                    var fileContents = template.file_data;
                    using (var ms = new MemoryStream(fileContents, 0, fileContents.Length))
                    {
                        this.spreadsheetControl.LoadDocument(ms, DocumentFormat.OpenXml);
                    }
                }
                else
                {
                    this.ShowFlyoutMessageBox("Информация",
                        String.Format("У формы {0} отсутствует шаблон. Обратитесь к администратору.", form.name),
                        FlyoutCommand.OK);
                }
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Информация", "Ошибка во время загрузки шаблона.\n" + ex.Message, FlyoutCommand.OK);
            }
            this.Enabled = true;
        }

        private bool OpenFile(Document doc)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Microsoft Excel 2003 (*.xls)|*.xls|Microsoft Excel 2007-2013 (*.xlsx)|*.xlsx";
                var result = openFileDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var filename = openFileDialog.FileName;
                    try
                    {
                        var fileContents = File.ReadAllBytes(filename);
                        var documentFormat = DocumentFormat.OpenXml;
                        if (filename.EndsWith(".xls"))
                            documentFormat = DocumentFormat.Xls;
                        using (var ms = new MemoryStream(fileContents, 0, fileContents.Length))
                        {
                            this.spreadsheetControl.LoadDocument(ms, documentFormat);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
            return false;
        }

        private void Print()
        {
            this.spreadsheetControl.ShowRibbonPrintPreview();
        }

        private void spreadsheetControl_DocumentLoaded(object sender, EventArgs e)
        {
            var sheet = (SpreadsheetControl) sender;
            sheet.Tag = "Unchecked";
            IsLocalSaved = true;
        }

        private void spreadsheetControl_CellValueChanged(object sender, SpreadsheetCellEventArgs e)
        {
            var sheet = (SpreadsheetControl) sender;
            if (sheet.Document.Worksheets[e.SheetName].Rows[e.RowIndex][e.ColumnIndex].Value.IsNumeric)
            {
                sheet.Tag = "Unchecked";
            }
            IsLocalSaved = false;
            IsSaved = false;
        }

        public void OnWarnWasAnsweredYes()
        {
            if (!IsSaved)
            {
                var dialogResult = this.ShowFlyoutMessageBox("", "Загрузить форму на сервер?", FlyoutCommand.Yes, FlyoutCommand.No);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Save();
                }
            }

            if (!IsLocalSaved)
            {
                var dialogResult = this.ShowFlyoutMessageBox("", "Сохранить файл формы локально?", FlyoutCommand.Yes, FlyoutCommand.No);
                if (dialogResult == DialogResult.Yes)
                {
                    this.SaveLocal();
                }
            }
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            var btnPrint = new WindowsUIButton()
            {
                Caption = "Печать",
                Image = Resources.glyph_print,
                Tag = "Print"
            };
            btnPrint.Click += (s, e) => Print();

            var btnSave = new WindowsUIButton()
            {
                Caption = "Отправить",
                Image = Resources.glyphicons_359_file_export,
                Tag = "Save"
            };
            btnSave.Click += (s, e) => Save(args.Document);

            var btnCheck = new WindowsUIButton()
            {
                Caption = "Проверить",
                Image = Resources.glyphicons_029_notes_2,
                Tag = "Check"
            };
            btnCheck.Click += (s, e) => Check(args.Document);

            var btnSaveToFile = new WindowsUIButton()
            {
                Caption = "Сохранить в файл",
                Image = Resources.glyphicons_358_file_import,
                Tag = "SaveLocal"
            };
            btnSaveToFile.Click += (s, e) => SaveLocal();

            var btnOpen = new WindowsUIButton()
            {
                Caption = "Открыть файл",
                Image = Resources.glyphicons_144_folder_open,
                Tag = "Open"
            };
            btnOpen.Click += (s, e) => OpenFile(args.Document);
            
            this.windowsUIButtonPanelActions.Buttons.Clear();
            
            if (!args.Document.ControlName.Contains("Archive"))
            {
                var formTypeIdMatch = new Regex(@"\w+(?<num>\d+)").Match(args.Document.ControlName);
                var formTypeId = formTypeIdMatch.Success
                    ? new int?(int.Parse(formTypeIdMatch.Groups["num"].Value))
                    : null;
                var formType = formTypeId.HasValue ? (FormType)formTypeId : FormType.None;
                var isCreateUploadButtons =
                    (Authentication.Credentials.IsMunicipality && formType.IsMunicipalityForm()) ||
                    (Authentication.Credentials.IsEdu && formType.IsEduForm()) || Authentication.Credentials.IsAdmin || 
                    args.Document.ControlName == "UploadSheetFromTemplate" ||
                    args.Document.ControlName == "UploadSheetFromFile";
                if (isCreateUploadButtons)
                {
                    if (this.Source == FormSource.File)
                        this.windowsUIButtonPanelActions.Buttons.Add(btnOpen);
                    this.windowsUIButtonPanelActions.Buttons.Add(btnSave);
                    this.windowsUIButtonPanelActions.Buttons.Add(btnCheck);
                    if (Authentication.Credentials.IsMunicipality || Authentication.Credentials.IsAdmin)
                    {
                        var btnPeekFormTest = new WindowsUIButton()
                        {
                            Caption = "Автозаполнение",
                            Image = Resources.three_dots_24x24,
                            ToolTip = "Выбрать организации, из форм которых будет заполнена таблица",
                            Tag = "AutoLoad"
                        };
                        btnPeekFormTest.Click += (s, e) => this.windowsUIButtonPanelActions.ShowPeekForm(btnPeekFormTest);
                        this.windowsUIButtonPanelActions.Buttons.Add(btnPeekFormTest);

                        this.windowsUIButtonPanelActions.QueryPeekFormContent += (s, e) =>
                        {
                            var formulaPeekControl = new MunicipalityFormulaPeekControl(Repo, _selectedForm, _selectedDate.Year);
                            formulaPeekControl.Completed += formulaPeekControl_Completed;
                            e.Control = formulaPeekControl;
                        };
                    }
                }
            }
            this.windowsUIButtonPanelActions.Buttons.Add(btnPrint);
            this.windowsUIButtonPanelActions.Buttons.Add(btnSaveToFile);
            this.comboBoxDate.Visible = (this.Mode == ControlMode.New);
            this.SetEditEnabled(this.Mode != ControlMode.Disabled);

            this.windowsUIButtonPanelActions.AppearanceButton.Normal.Font = new Font("Segoe UI Light", 11, FontStyle.Regular);
            this.windowsUIButtonPanelActions.AppearanceButton.Hovered.Font =
                this.windowsUIButtonPanelActions.AppearanceButton.Normal.Font;
            this.windowsUIButtonPanelActions.AppearanceButton.Pressed.Font =
                this.windowsUIButtonPanelActions.AppearanceButton.Normal.Font;
        }

        async void formulaPeekControl_Completed(object sender, MunicipalityFormulaPeekArgs e)
        {
            this.windowsUIButtonPanelActions.HidePeekForm();
            if (!e.Write) return;

            try
            {
                this.spreadsheetControl.BeginUpdate();
                using (new MarqueeProgressDialog(this.ParentForm, description: "Обрабатываю данные"))
                {
                    await Task.Run(() =>
                    {
                        using (var spreadsheet = new SpreadsheetControl() {AllowDrop = false})
                        {
                            using (var ms = new MemoryStream(e.FormulaBytes))
                            {
                                var formulas = FormulaExpressionParser.ParseStream(ms); //TODO: rewrite
                                var formDatas = e.FormDataList;
                                for (int i = 0; i < formDatas.Count; i++)
                                {
                                    var formData = formDatas[i];
                                    var formBytes = formData.file.contents;
                                    var format = formData.document_format.IsOpenXml()
                                        ? DocumentFormat.OpenXml
                                        : DocumentFormat.Xls;
                                    spreadsheet.LoadDocument(formBytes, format);
                                    foreach (var formula in formulas)
                                    {
                                        formula.Source = spreadsheet.Document;
                                        formula.Target = this.spreadsheetControl.Document;
                                        if (i == 0)
                                            formula.WriteToTarget();
                                        else
                                            formula.AppendToTarget();
                                    }
                                }
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", ex.Message, FlyoutCommand.OK);
            }
            finally
            {
                this.spreadsheetControl.EndUpdate();
            }

        }

        public void OnNavigatedTo(INavigationArgs args)
        {
            
        }

        public void OnNavigatedFrom(INavigationArgs args)
        {
            if (this.flyoutPanelActions.IsPopupOpen)
                this.flyoutPanelActions.HidePopup();
        }
    }
}
