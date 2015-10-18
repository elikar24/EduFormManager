using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using EduFormManager.Forms;
using EduFormManager.Forms.Reports;
using EduFormManager.Forms.UserControls;
using EduFormManager.Forms.UserControls.QueryControl;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Properties;
using EduFormManager.Utilities;
using EduFormManager.Utils;
using NLog;

namespace EduFormManager
{
    public partial class mainForm : XtraForm
    {
        private static readonly Logger Logger = LogManager.GetLogger("app");

        readonly AuthenticationForm _authForm;
        readonly MarqueeProgressDialog _progressDialog;
        readonly Authentication _auth;

        XtraDictionaryEduPassportControl passportControl;

        public mainForm()
        {
            InitializeComponent();
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "CMO Statistics " + version;

            if (!DesignMode)
            {
                _progressDialog = new MarqueeProgressDialog();
                _authForm = new AuthenticationForm(Settings.Default.LastLogin);

                _auth = new Authentication();
            }
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            tileContainerMain.Items.Remove(tileDictionaries);
            tileContainerMain.Items.Remove(tileDocumentQueries);
            tileContainerMain.Items.Remove(tileMessageList);
            tileContainerMain.Items.Remove(tileMessage);
            tileContainerMain.Items.Remove(tileFormStatistics);
            tileContainerMain.Items.Remove(tileEduPasport);
            tileContainerMain.Items.Remove(tileSpreadsheet);
            tileContainerMain.Items.Remove(tileMunicipalityForms);
            tileContainerMain.Items.Remove(tileMunicipalityAdditonalForms);
            tileContainerMain.Items.Remove(tileArchiveMunicipalityForms);
            tileContainerMain.Items.Remove(tileArchiveMunicipalityAdditonalForms);
            //tileContainerMain.Items.Remove(tileDictQuestionary);
            tileContainerMain.Items.Remove(tileCreateQuery);
        }

        async void SomeInitialization()
        {
            _progressDialog.ShowTop(this);

            SynchronizationContext context = SynchronizationContext.Current;
            GuiHelper.GuiThreadContext = context;
            var cred = Authentication.Credentials;

            if (cred.IsEdu) this.tileForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileForms.Tag = TagHelper.FEDERAL_EDU_FORMS_TAG;
            var eduFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileForms,
                "Формы федерального статистического наблюдения", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduFormsContainer);

            if (cred.IsEdu) this.tileAdditionalForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileAdditionalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileAdditionalForms.Tag = TagHelper.ADDON_EDU_FORMS_TAG;
            var eduAddonFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileAdditionalForms,
                "Дополнительные формы", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduAddonFormsContainer);

            if (cred.IsEdu) this.tileArchiveForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileArchiveForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveForms.Tag = TagHelper.ARCHIVE_FEDERAL_EDU_FORMS_TAG;
            var eduArchiveFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveForms,
                "Архивные формы федерального статистического наблюдения", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduArchiveFormsContainer);

            if (cred.IsEdu) this.tileArchiveAdditionalForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileArchiveAdditionalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveAdditionalForms.Tag = TagHelper.ARCHIVE_ADDON_EDU_FORMS_TAG;
            var eduArchiveAddonFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveAdditionalForms,
                "Архивные дополнительные формы", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduArchiveAddonFormsContainer);

            if (cred.IsMunicipality) this.tileMunicipalityForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileMunicipalityForms.Tag = TagHelper.FEDERAL_MUNIT_FORMS_TAG;
            var munitFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileMunicipalityForms,
                "Формы муниципалитетов", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitFormsContainer);

            if (cred.IsMunicipality) this.tileMunicipalityAdditonalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileMunicipalityAdditonalForms.Tag = TagHelper.FEDERAL_MUNIT_FORMS_TAG;
            var munitAdditionalFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileMunicipalityAdditonalForms,
                "Дополнительные формы муниципалитетов", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitAdditionalFormsContainer);

            if (cred.IsMunicipality) this.tileArchiveMunicipalityForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveMunicipalityForms.Tag = TagHelper.ARCHIVE_FEDERAL_MUNIT_FORMS_TAG;
            var munitArchiveFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveMunicipalityForms,
                "Архивные формы муниципалитетов", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitArchiveFormsContainer);

            if (cred.IsMunicipality) this.tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.ARCHIVE_FEDERAL_MUNIT_FORMS_TAG;
            var munitArchiveAdditionalFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveMunicipalityAdditonalForms,
                "Архивные дополнительные формы муниципалитетов", "", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitArchiveAdditionalFormsContainer);

            tileEduPasport.Elements[1].Text = Authentication.Credentials.Name;

            using (var repo = new Repository())
            {
                int count = await repo.GetUnreadMessagesCount();
                tileMessageList.Elements[0].Text = count.ToString();
            }
            if (!Authentication.Credentials.IsAdmin)
            {
                await DbLogHelper.LogLoginAsync(Authentication.Credentials);
                this.flyoutPanel1.ShowPopup();
            }

            //foreach (var container in this.windowsUIViewMain.ContentContainers)
            //{
            //    if (container is Page)
            //    {
            //        Page page = container as Page;

            //        page.AppearanceButton.Normal.ForeColor = System.Drawing.Color.FromArgb(0x02, 0x53, 0x8E);
            //        page.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(0, 114, 198);
            //        page.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(0x49, 0x92, 0xC8);
            //    }
            //}

            _progressDialog.HideTop();
        }

        private async void TriggerControlsWithPrivilegies(Credentials user)
        {
            using (var repo = new Repository())
            {
                this.tileEduPasport.Tag = user.IsEdu ? user.EduId : 0;

                var syncCtx = SynchronizationContext.Current;
                var view = this.windowsUIViewMain;
                if (user.IsAdmin || user.IsMinistry)
                {
                    tileForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.Edu, syncCtx);
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.Edu, syncCtx);

                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherEdu, syncCtx);
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
                                syncCtx);

                    tileMunicipalityForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.Municipality, syncCtx);
                    tileArchiveMunicipalityForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.Municipality, syncCtx);

                    tileMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherMunicipality, syncCtx);
                    tileArchiveMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.OtherMunicipality, syncCtx);
                }
                else if (user.IsMunicipality)
                {
                    var munit = await repo.GetMunicipality(user.MunitId);
                    tileMunicipalityForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileMunicipalityForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, false,
                                FormType.Municipality, syncCtx);
                    tileArchiveMunicipalityForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveMunicipalityForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, true,
                                FormType.Municipality, syncCtx);

                    tileMunicipalityAdditonalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherMunicipality, syncCtx);
                    tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, true,
                                FormType.OtherMunicipality, syncCtx);

                    tileForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduKindLayerAction.Invoke(sender, args, view, false, FormType.Edu,
                                syncCtx);
                    tileArchiveForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduKindLayerAction.Invoke(sender, args, view, true, FormType.Edu,
                                syncCtx);

                    tileAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduKindLayerAction.Invoke(sender, args, view, false, FormType.OtherEdu,
                                syncCtx);
                    tileArchiveAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit,
                        "archive");
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduKindLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
                                syncCtx);
                }
                else if (user.IsEdu)
                {
                    var edu = await repo.GetEdu(user.EduId);
                    tileForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu);
                    tileForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduFormsLayerAction.Invoke(sender, args, view, false, FormType.Edu,
                                syncCtx);
                    tileArchiveForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu, "archive");
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduFormsLayerAction.Invoke(sender, args, view, true, FormType.Edu,
                                syncCtx);

                    tileAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu);
                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduFormsLayerAction.Invoke(sender, args, view, false, FormType.OtherEdu,
                                syncCtx);
                    tileArchiveAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu, "archive");
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            LevelAdminHelper.LoadEduFormsLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
                                syncCtx);
                }

                if (user.IsEdu || user.IsMunicipality || user.IsAdmin)
                {
                    tileContainerMain.Items.Add(tileSpreadsheet);
                }
                if (user.IsAdmin)
                {
                    tileContainerMain.Items.Add(tileDictionaries);
                    tileContainerMain.Items.Add(tileMessageList);
                }

                if (user.IsAdmin || user.IsMunicipality || user.IsMinistry)
                {
                    tileContainerMain.Items.Add(tileMunicipalityForms);
                    tileContainerMain.Items.Add(tileArchiveMunicipalityForms);
                    tileContainerMain.Items.Add(tileMunicipalityAdditonalForms);
                    tileContainerMain.Items.Add(tileArchiveMunicipalityAdditonalForms);
                    tileContainerMain.Items.Add(tileDocumentQueries);
                    if (!user.IsMinistry)
                        tileContainerMain.Items.Add(tileCreateQuery);

                    tileContainerMain.Items.Add(tileFormStatistics);
                    if (user.IsMunicipality)
                        tabbedGroupStatistics.Items.Remove(documentSignInOutLog);
                }
                if (user.IsEdu || user.IsMunicipality)
                {
                    tileContainerMain.Items.Add(tileMessage);
                }
                if (user.IsEdu)
                {
                    tileContainerMain.Items.Add(tileEduPasport);
                    tileForms.Tag = string.Format("Forms{0}", (int) FormType.Edu);
                    tileAdditionalForms.Tag = string.Format("Forms{0}", (int) FormType.OtherEdu);
                }

                this.loggedUserControl.Text = user.Name;
                this.loggedUserControl.Cursor = Cursors.Hand;
                if (user.IsEdu)
                {
                    this.loggedUserControl.Click += (s, e) =>
                    {
                        this.windowsUIViewMain.ActivateContainer(pageEduPassport);
                    };
                }
                GuiUtility.NotifyAboutForms(user);
                this.loggedUserControl.Text = Authentication.Credentials.Name;
            }
        }

        async private void windowsUIView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            try
            {
                switch (e.Document.ControlName)
                {
                    case "Questionary":
                        {
                            //XtraDictionaryQuestionaryControl questionaryControl = new XtraDictionaryQuestionaryControl(this.windowsUIViewMain);
                            //int? questionaryId = TagHelper.GetQuestionaryId(e.Document.Tag.ToString());
                            //if (questionaryId.HasValue)
                            //    questionaryControl.CurrentQuestionary = RepoHelper.Repo.GetById<Questionary>(questionaryId.Value);
                            //e.Control = questionaryControl;
                            break;
                        }
                    case "Query":
                    {
                        var reportControl = new XtraReportViewControl(this.windowsUIViewMain) { Report = ReportFactory.LastReport };
                        e.Control = reportControl;
                        break;
                    }
                    case "Queries":
                        {
                            var repo = new Repository();
                            var queryControl = new XtraQueryControl(this.windowsUIViewMain, repo)
                            {
                                FormDataSource = await repo.Db.queries.Select(t => t.form)
                                    .Distinct()
                                    .OrderBy(t => t.name)
                                    .ToListAsync(),
                                YearDataSource = await repo.GetAvailableYears(),
                                QueryPartHeadDataSource = await repo.Db.query_head_part.ToListAsync()
                            };
                            e.Control = queryControl;
                            break;
                        }
                    case "DictCreateQuery":
                        {
                            var repo = new Repository();
                            var createQueryControl = new XtraCreateQueryControl(this.windowsUIViewMain, repo)
                            {
                                QueryAutocomletePartSource = await repo.Db.query_autocomplete_part.ToListAsync(),
                                QueryHeadPartSource = await repo.Db.query_head_part.ToListAsync()
                            };
                            if (Authentication.Credentials.IsAdmin)
                            {
                                createQueryControl.TemplatedFormDataDataSource = 
                                    await repo.GetTemplates();
                            }
                            else if (Authentication.Credentials.IsMunicipality)
                            {
                                createQueryControl.TemplatedFormDataDataSource =
                                    await repo.GetTemplatesForMunicipality(Authentication.Credentials.MunitId);
                            }
                            else if (Authentication.Credentials.IsEdu)
                            {
                                createQueryControl.TemplatedFormDataDataSource =
                                    await repo.GetTemplatesForEdu(Authentication.Credentials.EduId);
                            }
                            e.Control = createQueryControl;
                            break;
                        }
                    case "DictEdu":
                        {
                            var repo = new Repository();
                            var dictionaryEduControl =
                                new XtraDictionaryEduControl(this.windowsUIViewMain, repo)
                                {
                                    EduDataSource = await repo.GetEdus(),
                                    MunicipalityDataSource = await repo.GetMunicipalities(),
                                    DataSourceEduKind = await repo.Db.edu_kind.OrderBy(t => t.name).ToListAsync()
                                };

                            e.Control = dictionaryEduControl;
                            break;
                        }
                    case "DictMunicipality":
                        {
                            var repo = new Repository();
                            var dictionaryMunitControl = 
                                new XtraDictionaryMunitControl(this.windowsUIViewMain, repo)
                                {
                                    MunicipalityDataSource = await repo.GetMunicipalities()
                                };
                            e.Control = dictionaryMunitControl;
                            break;
                        }
                    case "DictTemplate":
                        {
                            var repo = new Repository();
                            var templateControl = new XtraDictionaryTemplateControl(this.windowsUIViewMain, repo)
                            {
                                TemplatedFormDataDataSource = await repo.GetTemplates(),
                                FormDataSource = await repo.GetFormsWithoutTemplates()
                            };
                            e.Control = templateControl;
                            break;
                        }
                    case "DictForms":
                    {
                        var repo = new Repository();
                            var dictionaryFormControl = new XtraDictionaryFormsControl(this.windowsUIViewMain, repo);
                        dictionaryFormControl.FormDataSource = await repo.GetForms();
                        dictionaryFormControl.DataSourceEduKind = await repo.GetEduKinds();
                        dictionaryFormControl.FormTypeDataSource = await repo.GetFormTypes();

                        e.Control = dictionaryFormControl;
                            break;
                        }
                    case "DictMunicipalityFormula":
                        {
                            var repo = new Repository();
                            var dictionaryMunicipalityFormulaControl = new XtraDictionaryMunicipalityFormulaControl(this.windowsUIViewMain, repo);
                            e.Control = dictionaryMunicipalityFormulaControl;
                            dictionaryMunicipalityFormulaControl.RegularFormDataSource = await repo.GetForms();
                            dictionaryMunicipalityFormulaControl.SummaryFormDataSource = await repo.GetForms();
                            break;
                        }
                    case "ArchiveFormData4":
                    case "FormData4":
                    case "ArchiveFormData3":
                    case "FormData3": //форма муниципалитета
                        {
                            int? dataId = TagHelper.GetFormDataId(e.Document.Tag.ToString());
                            if (dataId.HasValue)
                            {
                                var repo = new Repository();
                                var fd = await repo.Db.municipality_form_data.FirstAsync(t => t.id == dataId.Value);
                                var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                                {
                                    FormDataSource = await repo.Db.forms.Where(t => 
                                        t.form_type_id == (int) FormType.Municipality || t.form_type_id == (int) FormType.OtherMunicipality)
                                        .ToListAsync(),
                                    FormData = fd,
                                    FormStatus = (Status)fd.status,
                                    Source = XtraSpreadsheet.FormSource.File,
                                    Mode = XtraSpreadsheet.ControlMode.Edit,
                                    ActiveForm = fd.form
                                };
                                sheetControl.LoadDocument();

                                e.Control = sheetControl;
                            }
                            else
                            {
                                e.Control = new Control();
                            }
                            break;
                        }
                    case "ArchiveFormData1":
                    case "ArchiveFormData2":
                    case "FormData2":
                    case "FormData1": //форма организации
                        {
                            int? dataId = TagHelper.GetFormDataId(e.Document.Tag.ToString());
                            if (dataId.HasValue)
                            {
                                var repo = new Repository();
                                var fd = await repo.Db.edu_form_data.FirstAsync(t => t.id == dataId.Value);
                                var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                                {
                                    FormData = fd,
                                    FormStatus = (Status)fd.status,
                                    Source = XtraSpreadsheet.FormSource.File,
                                    Mode = XtraSpreadsheet.ControlMode.Edit
                                };
                                if (Authentication.Credentials.IsEdu)
                                {
                                    var edu = await repo.GetEdu(Authentication.Credentials.EduId);
                                    sheetControl.FormDataSource = await repo.GetFormsByEduKind(edu.edu_kind.edu_kind_id);
                                }
                                else
                                {
                                    sheetControl.FormDataSource = await repo.Db.forms.ToListAsync();
                                }
                                sheetControl.ActiveForm = fd.form;
                                sheetControl.LoadDocument();

                                e.Control = sheetControl;
                            }
                            else
                            {
                                e.Control = new Control();
                            }
                            break;
                        }
                    case "XtraProgress":
                        e.Control = new XtraProgress();
                        break;
                    case "Authentication":
                        e.Control = _authForm;
                        break;
                    case "Pasport":
                        {
                            var repo = new Repository();
                            passportControl = new XtraDictionaryEduPassportControl(this.windowsUIViewMain, repo)
                            {
                                MunicipalityDataSource = await repo.GetMunicipalities(),
                                ActivityTypeDataSource = await repo.Db.activity_type.OrderBy(t => t.name).ToListAsync(),
                                EduStatusDataSource = await repo.Db.edu_status.OrderBy(m => m.name).ToListAsync(),
                                EduTypeDataSource = await repo.Db.edu_type.OrderBy(m => m.name).ToListAsync(),
                                DataSourceEduKind = await repo.Db.edu_kind.OrderBy(m => m.name).ToListAsync(),
                                ManagementAgencyDataSource = await repo.Db.management_agency.OrderBy(m => m.name).ToListAsync(),
                                ManagementAgencyActivityDataSource = await repo.Db.management_agency_activity.OrderBy(m => m.name).ToListAsync(),
                                OwnershipTypeDataSource = await repo.Db.ownership_type.OrderBy(m => m.name).ToListAsync(),
                                Edu = await repo.GetEdu(Authentication.Credentials.EduId)
                            };
                            e.Control = passportControl;
                            break;
                        }
                    case "UploadSheetFromFile":
                        {
                            var repo = new Repository(); 
                            var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                            {
                                Source = XtraSpreadsheet.FormSource.File,
                                Mode = XtraSpreadsheet.ControlMode.New
                            };
                            var forms = new List<form>();
                            if (Authentication.Credentials.IsEdu)
                            {
                                var edu = await repo.GetEdu(Authentication.Credentials.EduId);
                                forms = await repo.GetFormsByEduKind(edu.edu_kind.edu_kind_id);
                            }
                            else if (Authentication.Credentials.IsMunicipality)
                            {
                                forms = await repo.Db.forms.Where(t =>
                                    t.form_type_id == (int)FormType.Municipality || t.form_type_id == (int)FormType.OtherMunicipality)
                                    .OrderBy(t => t.name)
                                    .ToListAsync();
                            }
                            else if (Authentication.Credentials.IsAdmin)
                            {
                                forms = await repo.GetForms();
                            }
                            sheetControl.FormDataSource = forms;
                            sheetControl.ActiveForm = forms.FirstOrDefault();
                            e.Control = sheetControl;
                            break;
                        }
                    case "UploadSheetFromTemplate":
                        {
                            var repo = new Repository();
                            var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                            {
                                Source = XtraSpreadsheet.FormSource.Template,
                                Mode = XtraSpreadsheet.ControlMode.New
                            };
                            var forms = new List<form>();
                            if (Authentication.Credentials.IsEdu)
                            {
                                var edu = await repo.GetEdu(Authentication.Credentials.EduId);
                                forms = await repo.GetFormsByEduKind(edu.edu_kind.edu_kind_id);
                            }
                            else if (Authentication.Credentials.IsMunicipality)
                            {
                                forms = await repo.Db.forms.Where(t => 
                                    t.form_type_id == (int)FormType.Municipality || t.form_type_id == (int)FormType.OtherMunicipality)
                                    .OrderBy(t => t.name)
                                    .ToListAsync();
                            }
                            else if (Authentication.Credentials.IsAdmin)
                            {
                                forms = await repo.GetForms();
                            }
                            sheetControl.FormDataSource = forms;
                            sheetControl.ActiveForm = forms.FirstOrDefault();
                            e.Control = sheetControl;
                            break;
                        }
                    case "RequestQuery":
                        {
                            var repo = new Repository();
                            var messageControl = new XtraMessageControl(this.windowsUIViewMain, repo)
                            {
                                MessageType = XtraMessageControl.MessageTypeEnum.RequestForQuery,
                                FormDataSource = await repo.Db.forms.OrderBy(t => t.name).ToListAsync()
                            };

                            e.Control = messageControl;
                            break;
                        }
                    case "BugReport":
                        {
                            var repo = new Repository();
                            var messageControl = new XtraMessageControl(this.windowsUIViewMain, repo)
                            {
                                MessageType = XtraMessageControl.MessageTypeEnum.BugReport,
                                FormDataSource = await repo.Db.forms.OrderBy(t => t.name).ToListAsync()
                            }; e.Control = messageControl;
                            break;
                        }
                    case "MessageList":
                        {
                            var repo = new Repository();
                            var messageListControl = new XtraMessageListControl(this.windowsUIViewMain, repo)
                            {
                                DataSourceMessage = await repo.GetMessages()
                            };
                            e.Control = messageListControl;
                            break;
                        }
                    case "FormDetailedStatisticsReport":
                    {
                        var doc = this.windowsUIViewMain.Documents.FindFirst(t => t.ControlName == "FormDetailedStatistics");
                        var formStatData = new List<t_detailed_form_statistics>();
                        if (doc != null)
                        {
                            formStatData = (List<t_detailed_form_statistics>)doc.Tag;
                        }
                        var formStatisticReport = new XtraDetailedFormStatisticReport();
                        var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain);
                        e.Control = formStatisticReportControl;
                        
                        formStatisticReport.FormStatisticDataSource = formStatData;
                        formStatisticReportControl.Report = formStatisticReport;
                        formStatisticReport.CreateDocument(true);
                        break;
                    }
                    case "FormDetailedStatistics":
                        {
                            var repo = new Repository();
                            var control = new XtraFormDetailedStatisticControl(this.windowsUIViewMain, repo);
                            e.Control = control;
                            control.FormStatisticDataSource = Authentication.Credentials.IsMunicipality ?
                                await repo.GetDetailedFormStatistics(Authentication.Credentials.MunitId, DateTime.Now.Year) :
                                await repo.GetDetailedFormStatistics(DateTime.Now.Year);
                            control.YearsDataSource = await repo.GetAvailableYears();
                            break;
                        }
                    case "FormStatistics":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraFormStatisticReport();
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain);

                            e.Control = formStatisticReportControl;

                            formStatisticReport.FormStatisticDataSource = Authentication.Credentials.IsMunicipality ?
                                await repo.GetFormStatistics(Authentication.Credentials.MunitId) :
                                await repo.GetFormStatistics();
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument(false);
                            break;
                        }
                    case "MunicipalityFormStatistics":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraMunicipalityFormStatisticReport();
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain);

                            e.Control = formStatisticReportControl;

                            formStatisticReport.FormStatisticDataSource = Authentication.Credentials.IsMunicipality ?
                                await repo.GetMunicipalityFormStatistics(Authentication.Credentials.MunitId) :
                                await repo.GetMunicipalityFormStatistics();
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument(false);
                            break;
                        }
                    case "MunicipalityFormDetailedStatisticsReport":
                        {
                            var doc = this.windowsUIViewMain.Documents.FindFirst(t => t.ControlName == "MunicipalityFormDetailedStatistics");
                            var formStatData = new List<t_detailed_municipality_form_statistics>();
                            if (doc != null)
                            {
                                formStatData = (List<t_detailed_municipality_form_statistics>)doc.Tag;
                            }
                            var formStatisticReport = new XtraDetailedMunicipalityFormStatisticReport();
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain);
                            e.Control = formStatisticReportControl;

                            formStatisticReport.FormStatisticDataSource = formStatData;
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument(true);
                            break;
                        }
                    case "MunicipalityFormDetailedStatistics":
                        {
                            var repo = new Repository();
                            var control = new XtraMunicipalityFormDetailedStatisticControl(this.windowsUIViewMain, repo);
                            e.Control = control;
                            control.FormStatisticDataSource = Authentication.Credentials.IsMunicipality ?
                                await repo.GetDetailedMunicipalityFormStatistics(Authentication.Credentials.MunitId, DateTime.Now.Year) :
                                await repo.GetDetailedMunicipalityFormStatistics(DateTime.Now.Year);
                            control.YearsDataSource = await repo.GetAvailableYears();
                            break;
                        }
                    case "FormStatisticsSummary":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraFormStatisticSummaryReport();
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain);

                            e.Control = formStatisticReportControl;

                            var formStatData = Authentication.Credentials.IsMunicipality ?
                                await repo.GetSummaryFormStatistics(Authentication.Credentials.MunitId) :
                                await repo.GetSummaryFormStatistics();
                            formStatisticReport.FormStatisticSummaryDataSource = formStatData;
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument(false);
                            break;
                        }
                    case "SignInOutLog":
                        {
                            using (var db = new Entities())
                            {
                                db.Configuration.LazyLoadingEnabled = false;

                                var signInOutReport = new XtraSignInOutReport();
                                var signInOutReportControl = new XtraReportViewControl(this.windowsUIViewMain);

                                e.Control = signInOutReportControl;

                                var startDate = DateTime.Now;
                                var endDate = DateTime.Now.AddDays(-30);

                                var logs = await db.edu_log.Include("action")
                                    .Where(t => 
                                        (t.action_id == (int)LogActionType.Login || t.action_id == (int)LogActionType.Logout)
                                        && (t.created < startDate && t.created > endDate)
                                    ).ToListAsync();
                                signInOutReport.SignInOutLogDataSource = logs;
                                signInOutReportControl.Report = signInOutReport;
                                signInOutReport.CreateDocument(false);

                                db.Configuration.LazyLoadingEnabled = true;
                                break;
                            }
                        }
                    case "ExportReport":
                        {
                            var exportControl = new XtraExportReportControl();
                            e.Control = exportControl;
                            break;
                        }
                    default:
                        e.Control = new Control();
                        break;
                }
            }
            catch (Exception ex)
            {
                GuiUtility.ShowFlyoutMessage(windowsUIViewMain, flyoutMessage, "Ошибка", ex.Message + "\n" + ex.InnerException ?? ex.InnerException.Message, FlyoutCommand.OK);
                Logger.Error(ex.Message);
                Logger.Error(ex.StackTrace);
                e.Control = new Control();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlyoutAction closeAppAction = new FlyoutAction()
            {
                Caption = "Выход",
                Description = "Выйти из приложения?"
            };
            flyoutQuit.Action = closeAppAction;

            var res = windowsUIViewMain.ShowFlyoutDialog(flyoutQuit);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (Authentication.Credentials != null && !Authentication.Credentials.IsAdmin)
                    DbLogHelper.LogLogout(Authentication.Credentials);
            }
        }

        private void windowsUIViewMain_FlyoutHiding(object sender, FlyoutCancelEventArgs e)
        {
            var view = (WindowsUIView)sender;
            var fly = view.ActiveFlyoutContainer as Flyout;
            if (fly == null)
                return;
            var ee = (FlyoutResultCancelEventArgs) e;
            if (fly.Document == documentLogin)
            {
                switch (ee.Result)
                {
                    case DialogResult.OK:
                        var args = _authForm.Args;
                        _authForm.labelError.Visible = false;
                        try
                        {
                            Authentication.Credentials = _auth.GetAuthenticated(args.UserName, args.Password);
                            TriggerControlsWithPrivilegies(Authentication.Credentials);
                            SomeInitialization();

                            Settings.Default.LastLogin = args.UserName;
                            Settings.Default.Save();
                        }
                        catch (InvalidCredentialException)
                        {
                            _authForm.labelError.Visible = true;
                            e.Cancel = true;
                        }
                        catch (Exception ex)
                        {
                            GuiUtility.ShowFlyoutMessage(windowsUIViewMain, flyoutMessage, "Ошибка", ex.Message, FlyoutCommand.OK);
                            Logger.Error(ex.Message);
                            Logger.Error(ex.StackTrace);
                            if (ex.InnerException != null)
                            {
                                Logger.Error("inner {0}", ex.InnerException.Message);
                                Logger.Error("inner {0}", ex.InnerException.StackTrace);
                            }
                            e.Cancel = true;
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = false;
                        this.Close();
                        break;
                }
            }
            else if (fly.Document == documentExportReport)
            {
                switch (ee.Result)
                {
                    case DialogResult.OK:
                        try
                        {   
                            var f = view.ActiveContentContainer;
                            var exportControl = (XtraExportReportControl) fly.Document.Control;
                            XtraReportViewControl reportViewControl;
                            var pageGroupContainer = f as TabbedGroup;
                            if (pageGroupContainer != null)
                            {
                                reportViewControl = (XtraReportViewControl) pageGroupContainer.SelectedDocument.Control;
                            }
                            else
                            {
                                GuiUtility.ShowFlyoutMessage(windowsUIViewMain, flyoutMessage, "Ошибка", "Неизвестная ошибка", FlyoutCommand.OK);
                                return;
                            }
                            if (string.IsNullOrEmpty(exportControl.FileName))
                            {
                                GuiUtility.ShowFlyoutMessage(windowsUIViewMain, flyoutMessage, "", "Не выбран файл",
                                    FlyoutCommand.OK);
                                e.Cancel = true;
                                return;
                            }
                            switch (exportControl.Format)
                            {
                                case XtraExportReportControl.ExportFormat.Xslx:
                                    reportViewControl.ExportToXlsx(exportControl.FileName);
                                    break;
                                case XtraExportReportControl.ExportFormat.Pdf:
                                    reportViewControl.ExportToPdf(exportControl.FileName);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            GuiUtility.ShowFlyoutMessage(windowsUIViewMain, flyoutMessage, "Ошибка", ex.Message, FlyoutCommand.OK);
                            Logger.Error(ex.Message);
                            Logger.Error(ex.StackTrace);
                            if (ex.InnerException != null)
                            {
                                Logger.Error("inner {0}", ex.InnerException.Message);
                                Logger.Error("inner {0}", ex.InnerException.StackTrace);
                            }
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = false;
                        break;
                }
            }
        }
        private void mainForm_Shown(object sender, EventArgs e)
        {
            FlyoutAction loginAction = new FlyoutAction()
            {
                Caption = "Вход",
                Commands = { FlyoutCommand.OK, FlyoutCommand.Cancel }
            };
            flyoutLogin.Action = loginAction;
            windowsUIViewMain.ActivateContainer(flyoutLogin);
        }

        async private void windowsUIViewMain_ContentContainerActivated(object sender, ContentContainerEventArgs e)
        {
            if (Authentication.Credentials == null) return;
            RebuildNavBar(e.ContentContainer);
            if (e.ContentContainer == tileContainerMain && Authentication.Credentials.IsAdmin)
            {
                using (var repo = new Repository())
                {
                    int count = await repo.GetUnreadMessagesCount();
                    tileMessageList.Elements[0].Text = count.ToString();
                }
            }
            if (e.ContentContainer == tileContainerMain)
                this.windowsUIViewMain.ActivateContainer(tileContainerMain);
        }

        private void RebuildNavBar(IContentContainer container)
        {
            if (container == null) return;
            this.navigationBar1.ClearItems();
            while (container != null)
            {
                this.navigationBar1.PushItem(container);
                container = container.Parent;
            }
        }

        private void windowsUIViewMain_BackButtonClick(object sender, BackButtonClickEventArgs e)
        {
            if (windowsUIViewMain.ActiveDocument == null)
            {
                return;
            }
            if (windowsUIViewMain.ActiveDocument == documentEduPasport)
            {DialogResult dialogResult = passportControl.WarnAboutSavingChanges();
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        passportControl.Save();
                        windowsUIViewMain.Controller.Back();
                        break;
                    case DialogResult.No:
                        windowsUIViewMain.Controller.Back();
                        break;
                }
                e.Handled = true;
            }
            else if (windowsUIViewMain.ActiveDocument == documentUploadSheetFromFile
                || windowsUIViewMain.ActiveDocument == documentUploadSheetFromTemplate
                || windowsUIViewMain.ActiveDocument.ControlName == "FormData")
            {
                var spreadSheetContol = ((XtraSpreadsheet) windowsUIViewMain.ActiveDocument.Control);
                DialogResult dialogResult = spreadSheetContol.WarnAboutSavingChanges();
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        spreadSheetContol.OnWarnWasAnsweredYes();
                        windowsUIViewMain.Controller.Back();
                        break;
                    case DialogResult.No:
                        windowsUIViewMain.Controller.Back();
                        break;
                }
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.flyoutPanel1.ShowPopup();
        }

        private void flyoutPanel1_ButtonClick(object sender, FlyoutPanelButtonClickEventArgs e)
        {
            if (e.Button.Caption == "Close")
            {
                this.flyoutPanel1.HidePopup();
            }
        }

        private void buttonShowLogs_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "logs");
                if (Directory.Exists(path)) Process.Start(path);
                else MessageBox.Show("Логов нет.");
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Логов нет.");
            }
        }

        private void windowsUIViewMain_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            e.DisposeControl = true;
            e.KeepControl = false;
            var control = e.Document.Control as XtraBaseControl;
            if (control != null && control.Repo != null)
            {
                control.Repo.Dispose();
                control.Repo = null;
            }
        }
    }
}
