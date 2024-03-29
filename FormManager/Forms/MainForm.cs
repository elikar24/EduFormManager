﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Text.RegularExpressions;
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
using EduFormManager.Properties;
using EduFormManager.Utils;
using Models;
using Models.Repo;
using NLog;

namespace EduFormManager
{
    public partial class MainForm : XtraForm
    {
        private static readonly Logger Logger = LogManager.GetLogger("app");

        readonly AuthenticationForm _authForm;
        readonly MarqueeProgressDialog _progressDialog;
        readonly Authentication _auth;

        XtraDictionaryEduPassportControl passportControl;

        public MainForm()
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
            tileContainerMain.Items.Remove(tileQueries);
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

            GuiUtility.GuiThreadContext = SynchronizationContext.Current;
            var cred = Authentication.Credentials;

            if (cred.IsEdu) this.tileForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileForms.Tag = TagHelper.FEDERAL_EDU_FORMS_TAG;
            var eduFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileForms,
                "Формы федерального статистического наблюдения", "Формы ФСН", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduFormsContainer);

            if (cred.IsEdu) this.tileAdditionalForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileAdditionalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileAdditionalForms.Tag = TagHelper.ADDON_EDU_FORMS_TAG;
            var eduAddonFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileAdditionalForms,
                "Дополнительные формы", " Доп. формы ФСН", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduAddonFormsContainer);

            if (cred.IsEdu) this.tileArchiveForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileArchiveForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveForms.Tag = TagHelper.ARCHIVE_FEDERAL_EDU_FORMS_TAG;
            var eduArchiveFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveForms,
                "Архивные формы федерального статистического наблюдения", " Архивные формы ФСН", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduArchiveFormsContainer);

            if (cred.IsEdu) this.tileArchiveAdditionalForms.Tag = TagHelper.EDU + "-" + cred.EduId;
            else if (cred.IsMunicipality) this.tileArchiveAdditionalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveAdditionalForms.Tag = TagHelper.ARCHIVE_ADDON_EDU_FORMS_TAG;
            var eduArchiveAddonFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveAdditionalForms,
                "Архивные дополнительные формы", "Архивные доп. формы ФСН", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(eduArchiveAddonFormsContainer);

            if (cred.IsMunicipality) this.tileMunicipalityForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileMunicipalityForms.Tag = TagHelper.FEDERAL_MUNIT_FORMS_TAG;
            var munitFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileMunicipalityForms,
                "Формы муниципалитетов", "Формы муниципалитетов", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitFormsContainer);

            if (cred.IsMunicipality) this.tileMunicipalityAdditonalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileMunicipalityAdditonalForms.Tag = TagHelper.FEDERAL_MUNIT_FORMS_TAG;
            var munitAdditionalFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileMunicipalityAdditonalForms,
                "Дополнительные формы муниципалитетов", "Доп. формы муниципалитетов", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitAdditionalFormsContainer);

            if (cred.IsMunicipality) this.tileArchiveMunicipalityForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveMunicipalityForms.Tag = TagHelper.ARCHIVE_FEDERAL_MUNIT_FORMS_TAG;
            var munitArchiveFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveMunicipalityForms,
                "Архивные формы муниципалитетов", "Архивные доп. формы муниципалитетов", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitArchiveFormsContainer);

            if (cred.IsMunicipality) this.tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.MUNICIPALITY + "-" + cred.MunitId;
            else this.tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.ARCHIVE_FEDERAL_MUNIT_FORMS_TAG;
            var munitArchiveAdditionalFormsContainer = TileContainerHelper.CreateTileContainer(this.windowsUIViewMain, this.tileArchiveMunicipalityAdditonalForms,
                "Архивные дополнительные формы муниципалитетов", "Архивные доп. формы муниципалитетов", this.tileContainerMain);
            windowsUIViewMain.ContentContainers.Add(munitArchiveAdditionalFormsContainer);

            tileEduPasport.Elements[1].Text = Authentication.Credentials.Name;

            using (var repo = new Repository())
            {
                int count = await repo.GetUnreadMessagesCount();
                tileMessageList.Elements[0].Text = count.ToString();
            }
            if (!Authentication.Credentials.IsAdmin)
            {
                await DbLogger.LogLoginAsync(Authentication.Credentials);
                this.flyoutPanelNotifications.ShowPopup();
            }

            foreach (var container in this.windowsUIViewMain.ContentContainers)
            {
                if (container is Page)
                {
                    Page page = container as Page;

                    page.AppearanceButton.Normal.ForeColor = TileResources.FontColor;
                    page.AppearanceButton.Hovered.ForeColor = Color.FromArgb(39,39,39);
                    page.AppearanceButton.Pressed.ForeColor = Color.FromArgb(19, 19, 19);
                }
            }

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
                            Actions.LoadMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.Edu, syncCtx);
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.Edu, syncCtx);

                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherEdu, syncCtx);
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
                                syncCtx);

                    tileMunicipalityForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.Municipality, syncCtx);
                    tileArchiveMunicipalityForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.Municipality, syncCtx);

                    tileMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherMunicipality, syncCtx);
                    tileArchiveMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityMunicipalityLayerAction.Invoke(sender, args, view, true,
                                FormType.OtherMunicipality, syncCtx);
                }
                else if (user.IsMunicipality)
                {
                    var munit = await repo.GetMunicipality(user.MunitId);
                    tileMunicipalityForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileMunicipalityForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, false,
                                FormType.Municipality, syncCtx);
                    tileArchiveMunicipalityForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveMunicipalityForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, true,
                                FormType.Municipality, syncCtx);

                    tileMunicipalityAdditonalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, false,
                                FormType.OtherMunicipality, syncCtx);
                    tileArchiveMunicipalityAdditonalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveMunicipalityAdditonalForms.Click +=
                        (sender, args) =>
                            Actions.LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, true,
                                FormType.OtherMunicipality, syncCtx);

                    tileForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduKindLayerAction.Invoke(sender, args, view, false, FormType.Edu,
                                syncCtx);
                    tileArchiveForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit, "archive");
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduKindLayerAction.Invoke(sender, args, view, true, FormType.Edu,
                                syncCtx);

                    tileAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit);
                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduKindLayerAction.Invoke(sender, args, view, false, FormType.OtherEdu,
                                syncCtx);
                    tileArchiveAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, munit,
                        "archive");
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduKindLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
                                syncCtx);
                }
                else if (user.IsEdu)
                {
                    var edu = await repo.GetEdu(user.EduId);
                    tileForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu);
                    tileForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduFormsLayerAction.Invoke(sender, args, view, false, FormType.Edu,
                                syncCtx);
                    tileArchiveForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu, "archive");
                    tileArchiveForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduFormsLayerAction.Invoke(sender, args, view, true, FormType.Edu,
                                syncCtx);

                    tileAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu);
                    tileAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduFormsLayerAction.Invoke(sender, args, view, false, FormType.OtherEdu,
                                syncCtx);
                    tileArchiveAdditionalForms.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, edu, "archive");
                    tileArchiveAdditionalForms.Click +=
                        (sender, args) =>
                            Actions.LoadEduFormsLayerAction.Invoke(sender, args, view, true, FormType.OtherEdu,
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
                    tileContainerMain.Items.Add(tileCreateQuery);
                }

                if (user.IsAdmin || user.IsMunicipality || user.IsMinistry)
                {
                    tileContainerMain.Items.Add(tileMunicipalityForms);
                    tileContainerMain.Items.Add(tileArchiveMunicipalityForms);
                    tileContainerMain.Items.Add(tileMunicipalityAdditonalForms);
                    tileContainerMain.Items.Add(tileArchiveMunicipalityAdditonalForms);
                    tileContainerMain.Items.Add(tileQueries);
                    

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

                this.labelLoggedUser.Text = user.Name;
                this.labelLoggedUser.Cursor = Cursors.Hand;
                if (user.IsEdu)
                {
                    this.labelLoggedUser.Click += (s, e) =>
                    {
                        this.windowsUIViewMain.ActivateContainer(pageEduPassport);
                    };
                }
                GuiUtility.NotifyAboutForms(user);
                this.labelLoggedUser.Text = Authentication.Credentials.Name;
            }
        }

        async private void windowsUIViewMain_QueryControl(object sender, QueryControlEventArgs e)
        {
            try
            {
                var queryReportRegex = new Regex(@"QueryReport(?<idx>\d+)");
                var queryReportMatch = queryReportRegex.Match(e.Document.ControlName);
                if (queryReportMatch.Success)
                {
                    try
                    {
                        var idx = int.Parse(queryReportMatch.Groups["idx"].Value);
                        e.Control = new XtraReportViewControl(windowsUIViewMain) {Report = ReportFactory.Reports[idx]};
                        return;
                    }
                    catch
                    {
                        throw new KeyNotFoundException("Отчет не найден");
                    }
                }
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
                    case "QueriesEdu":
                        {
                            var repo = new Repository();
                            var queryControl = new XtraQueryEduControl(this.windowsUIViewMain, repo)
                            {
                                FormDataSource = await repo.GetFormsHaveQueries(FormType.Edu, FormType.OtherEdu),
                                YearDataSource = await repo.GetAvailableYears(),
                                QueryPartHeadDataSource = await repo.GetQueriesHeadParts()
                            };
                            e.Control = queryControl;
                            break;
                        }
                    case "QueriesMunicipality":
                        {
                            var repo = new Repository();
                            var queryControl = new XtraQueryMunicipalityControl(this.windowsUIViewMain, repo)
                            {
                                FormDataSource = await repo.GetFormsHaveQueries(FormType.Municipality, FormType.OtherMunicipality),
                                YearDataSource = await repo.GetAvailableYears(),
                                QueryPartHeadDataSource = await repo.GetQueriesHeadParts()
                            };
                            e.Control = queryControl;
                            break;
                        }
                    case "DictCreateQuery":
                        {
                            var repo = new Repository();
                            var createQueryControl = new XtraCreateQueryControl(this.windowsUIViewMain, repo)
                            {
                                QueryAutocomletePartSource = await repo.GetQueriesAutocompleteParts(),
                                QueryHeadPartSource = await repo.GetQueriesHeadParts()
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
                                    DataSourceEduKind = await repo.GetEduKinds()
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
                    case "FormData4": //допформа
                    case "ArchiveFormData3":
                    case "FormData3": //форма муниципалитета
                        {
                            int? dataId = TagHelper.GetFormDataId(e.Document.Tag.ToString());
                            if (dataId.HasValue)
                            {
                                var repo = new Repository();
                                var fd = await repo.GetMunitFormDataById(dataId.Value);
                                var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                                {
                                    FormDataSource = await repo.GetMunicipalityForms(),
                                    FormData = fd,
                                    FormStatus = (Status)fd.status,
                                    Source = XtraSpreadsheet.FormSource.File,
                                    Mode = (fd.form.DaysRemain() == -1 && fd.form.is_blocked) 
                                        ? XtraSpreadsheet.ControlMode.Disabled 
                                        : XtraSpreadsheet.ControlMode.Edit,
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
                    case "FormData2": //допформа
                    case "FormData1": //форма организации
                        {
                            int? dataId = TagHelper.GetFormDataId(e.Document.Tag.ToString());
                            if (dataId.HasValue)
                            {
                                var repo = new Repository();
                                var fd = await repo.GetEduFormDataById(dataId.Value);
                                var sheetControl = new XtraSpreadsheet(this.windowsUIViewMain, repo)
                                {
                                    FormData = fd,
                                    FormStatus = (Status)fd.status,
                                    Source = XtraSpreadsheet.FormSource.File,
                                    Mode = (fd.form.DaysRemain() == -1 && fd.form.is_blocked) 
                                        ? XtraSpreadsheet.ControlMode.Disabled 
                                        : XtraSpreadsheet.ControlMode.Edit
                                };
                                if (Authentication.Credentials.IsEdu)
                                {
                                    var edu = await repo.GetEdu(Authentication.Credentials.EduId);
                                    if (edu.edu_kind_id != null)
                                        sheetControl.FormDataSource = await repo.GetFormsByEduKind(edu.edu_kind_id.Value);
                                }
                                else
                                {
                                    sheetControl.FormDataSource = await repo.GetForms();
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
                                ActivityTypeDataSource = await repo.GetActivityTypes(),
                                EduStatusDataSource = await repo.GetEduStatuses(),
                                EduTypeDataSource = await repo.GetEduTypes(),
                                DataSourceEduKind = await repo.GetEduKinds(),
                                ManagementAgencyDataSource = await repo.GetManagementAgencies(),
                                ManagementAgencyActivityDataSource = await repo.GetManagementAgencyActivities(),
                                OwnershipTypeDataSource = await repo.GetOwnershipTypes(),
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
                                forms = await repo.GetMunicipalityForms();
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
                                forms = await repo.GetMunicipalityForms();
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
                                FormDataSource = await repo.GetForms()
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
                                FormDataSource = await repo.GetForms()
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
                            formStatisticReport.FormStatisticDataSource = formStatData;
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument();

                            e.Control = formStatisticReportControl;
                            break;
                        }
                    case "FormDetailedStatistics":
                        {
                            var repo = new Repository();
                            var detailedFormStatisticsReport = new XtraFormDetailedStatisticControl(this.windowsUIViewMain, repo)
                            {
                                FormStatisticDataSource = Authentication.Credentials.IsMunicipality
                                    ? repo.GetDetailedFormStatistics(Authentication.Credentials.MunitId, DateTime.Now.Year).Result
                                    : repo.GetDetailedFormStatistics(DateTime.Now.Year).Result,
                                YearsDataSource = await repo.GetAvailableYears()
                            };
                            
                            e.Control = detailedFormStatisticsReport;
                            break;
                        }
                    case "FormStatistics":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraFormStatisticReport
                            {
                                FormStatisticDataSource = Authentication.Credentials.IsMunicipality
                                    ? repo.GetFormStatistics(Authentication.Credentials.MunitId).Result
                                    : repo.GetFormStatistics().Result
                            };
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain) 
                            {
                                Report = formStatisticReport
                            };
                            formStatisticReport.CreateDocument();
                            
                            e.Control = formStatisticReportControl;
                            break;
                        }
                    case "MunicipalityFormStatistics":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraMunicipalityFormStatisticReport //не ясно почему вылетает deferredloadexception, если использовать await
                            {
                                FormStatisticDataSource = Authentication.Credentials.IsMunicipality
                                    ? repo.GetMunicipalityFormStatistics(Authentication.Credentials.MunitId).Result
                                    : repo.GetMunicipalityFormStatistics().Result
                            };
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain)
                            {
                                Report = formStatisticReport
                            };
                            formStatisticReport.CreateDocument();

                            e.Control = formStatisticReportControl;
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
                            
                            formStatisticReport.FormStatisticDataSource = formStatData;
                            formStatisticReportControl.Report = formStatisticReport;
                            formStatisticReport.CreateDocument();

                            e.Control = formStatisticReportControl;
                            break;
                        }
                    case "MunicipalityFormDetailedStatistics":
                        {
                            var repo = new Repository();
                            var detailedFormStatisticsReport = new XtraMunicipalityFormDetailedStatisticControl(this.windowsUIViewMain, repo)
                            {
                                FormStatisticDataSource = Authentication.Credentials.IsMunicipality 
                                    ? repo.GetDetailedMunicipalityFormStatistics(Authentication.Credentials.MunitId, DateTime.Now.Year).Result
                                    : repo.GetDetailedMunicipalityFormStatistics(DateTime.Now.Year).Result, 
                                YearsDataSource = await repo.GetAvailableYears()
                            };

                            e.Control = detailedFormStatisticsReport;
                            break;
                        }
                    case "FormStatisticsSummary":
                        using (var repo = new Repository())
                        {
                            var formStatisticReport = new XtraFormStatisticSummaryReport
                            {
                                FormStatisticSummaryDataSource = Authentication.Credentials.IsMunicipality
                                    ? repo.GetSummaryFormStatistics(Authentication.Credentials.MunitId).Result
                                    : repo.GetSummaryFormStatistics().Result
                            };
                            var formStatisticReportControl = new XtraReportViewControl(this.windowsUIViewMain)
                            {
                                Report = formStatisticReport
                            };
                            formStatisticReport.CreateDocument();

                            e.Control = formStatisticReportControl;
                            break;
                        }
                    case "SignInOutLog":
                        {
                            using (var repo = new Repository())
                            {

                                var signInOutReport = new XtraSignInOutReport();
                                var signInOutReportControl = new XtraReportViewControl(this.windowsUIViewMain);

                                var startDate = DateTime.Now;
                                var endDate = DateTime.Now.AddDays(-30);

                                var logs = await repo.GetSignInOutLogs(startDate, endDate);
                                signInOutReport.SignInOutLogDataSource = logs;
                                signInOutReportControl.Report = signInOutReport;
                                signInOutReport.CreateDocument();

                                e.Control = signInOutReportControl;
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
                    DbLogger.LogLogoutAsync(Authentication.Credentials);
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
            this.xtraNavPane.Home = this.tileContainerMain;

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
            if (container == null) 
                return;
            this.xtraNavPane.ClearItems();
            if (container == this.tileContainerMain) 
                return;
            while (container != null && container != this.tileContainerMain)
            {
                this.xtraNavPane.PushItem(container);
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
                if (!(spreadSheetContol.Mode == XtraSpreadsheet.ControlMode.Disabled &&
                    windowsUIViewMain.ActiveDocument.ControlName == "FormData"))
                {
                    var dialogResult = spreadSheetContol.WarnAboutSavingChanges();
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
            }
            else
            {
                e.Handled = false;
            }
        }

        private void buttonShowNotifications_Click(object sender, EventArgs e)
        {
            this.flyoutPanelNotifications.ShowPopup();
        }

        private void flyoutPanel1_ButtonClick(object sender, FlyoutPanelButtonClickEventArgs e)
        {
            if (e.Button.Caption == "Close")
            {
                this.flyoutPanelNotifications.HidePopup();
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
