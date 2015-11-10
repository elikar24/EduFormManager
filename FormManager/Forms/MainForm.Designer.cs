using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Win;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.Controls;
using EduFormManager.Forms;
using EduFormManager.Forms.UserControls;
using EduFormManager.Properties;
using TileGroup = DevExpress.XtraEditors.TileGroup;

namespace EduFormManager
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement19 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement20 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement21 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement22 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement23 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement24 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement32 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement29 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement30 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement31 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement33 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement34 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement35 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.docContainer = new EduFormManager.Forms.DocumentManagerContainer();
            this.windowsUIViewMain = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainerMain = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileMunicipalityForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveMunicipalityForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileSpreadsheet = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroupUploadForm = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.documentUploadSheetFromTemplate = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentUploadSheetFromFile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileAdditionalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveAdditionalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileMunicipalityAdditonalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveMunicipalityAdditonalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroupQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.documentQueriesEdu = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentQueriesMunicipality = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictionaries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainerDictionaries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileDictMunicipality = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageMunit = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictMunicipality = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictEdu = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageEdu = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictEdu = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictTemplate = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageTemplate = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictTemplate = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictMunicipalityFormula = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageMunicipalityFormula = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictMunicipalityFormula = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tabbedGroupStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
            this.documentFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentFormStatisticsSummary = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentFormDetailedStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentSignInOutLog = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentMunicipalityFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentMunicipalityFormDetailedStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileMessageList = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageMessageList = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentMessageList = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileMessage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainerMessage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileRequestQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageRequestQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentRequestQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileBugReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageBugReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentBugReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileEduPasport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageEduPassport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentEduPasport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutInProgress = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.documentInProgress = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutQuit = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.flyoutLogin = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.documentLogin = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutMessage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.pageCheck = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictCheck = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.pageQuestionary = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentDictQuestionary = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutExportReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.documentExportReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.pageDetailedStatisticsReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentFormDetailedStatisticsReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tabbedGroupQueryReports = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
            this.pageDetailedMunicipalityStatisticsReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentMunicipalityFormDetailedStatisticsReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileDictCheck = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loggedUserControl = new EduFormManager.Forms.UserControls.XtraLoggedUserControl();
            this.buttonShowLogs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.navigationBar = new EduFormManager.Forms.NavigationBar();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.collapsableSideListBoxControl1 = new EduFormManager.Forms.CollapsableSideListBoxControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expireWarnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSpreadsheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupUploadForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAdditionalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveAdditionalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityAdditonalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityAdditonalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesMunicipality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerDictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictMunicipality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMunit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictMunicipality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictMunicipalityFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMunicipalityFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictMunicipalityFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatisticsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSignInOutLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMessageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMessageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMessageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileRequestQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequestQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRequestQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEduPasport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEduPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentEduPasport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageQuestionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictQuestionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutExportReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentExportReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDetailedStatisticsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatisticsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupQueryReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDetailedMunicipalityStatisticsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatisticsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictCheck)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expireWarnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManagerMain
            // 
            this.documentManagerMain.ContainerControl = this.docContainer;
            this.documentManagerMain.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManagerMain.View = this.windowsUIViewMain;
            this.documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIViewMain});
            // 
            // docContainer
            // 
            this.docContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docContainer.Location = new System.Drawing.Point(0, 0);
            this.docContainer.Name = "docContainer";
            this.docContainer.Size = new System.Drawing.Size(1186, 571);
            this.docContainer.TabIndex = 0;
            // 
            // windowsUIViewMain
            // 
            this.windowsUIViewMain.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            this.windowsUIViewMain.Caption = "";
            this.windowsUIViewMain.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainerMain,
            this.tileContainerDictionaries,
            this.flyoutInProgress,
            this.flyoutQuit,
            this.flyoutLogin,
            this.flyoutMessage,
            this.tileContainerMessage,
            this.pageEduPassport,
            this.pageCheck,
            this.pageEdu,
            this.pageMunit,
            this.pageCreateQuery,
            this.pageRequestQuery,
            this.pageBugReport,
            this.pageMessageList,
            this.pageForms,
            this.pageGroupUploadForm,
            this.pageMunicipalityFormula,
            this.pageQuestionary,
            this.flyoutExportReport,
            this.pageDetailedStatisticsReport,
            this.tabbedGroupQueryReports,
            this.tabbedGroupStatistics,
            this.pageDetailedMunicipalityStatisticsReport,
            this.pageGroupQueries,
            this.pageTemplate});
            this.windowsUIViewMain.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.documentQueriesEdu,
            this.documentDictCheck,
            this.documentDictEdu,
            this.documentDictMunicipality,
            this.documentDictTemplate,
            this.documentLogin,
            this.documentUploadSheetFromFile,
            this.documentInProgress,
            this.documentCreateQuery,
            this.documentEduPasport,
            this.documentRequestQuery,
            this.documentBugReport,
            this.documentMessageList,
            this.documentDictForms,
            this.documentFormStatistics,
            this.documentFormStatisticsSummary,
            this.documentUploadSheetFromTemplate,
            this.documentSignInOutLog,
            this.documentDictMunicipalityFormula,
            this.documentDictQuestionary,
            this.documentExportReport,
            this.documentFormDetailedStatistics,
            this.documentFormDetailedStatisticsReport,
            this.documentMunicipalityFormStatistics,
            this.documentMunicipalityFormDetailedStatistics,
            this.documentMunicipalityFormDetailedStatisticsReport,
            this.documentQueriesMunicipality});
            this.windowsUIViewMain.FlyoutProperties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.windowsUIViewMain.FlyoutProperties.Appearance.ForeColor = System.Drawing.Color.White;
            this.windowsUIViewMain.FlyoutProperties.Appearance.Options.UseBackColor = true;
            this.windowsUIViewMain.FlyoutProperties.Appearance.Options.UseForeColor = true;
            this.windowsUIViewMain.SplashScreenProperties.Caption = "Подождите";
            this.windowsUIViewMain.SplashScreenProperties.LoadingDescription = "Загрузка";
            this.windowsUIViewMain.TileContainerProperties.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.None;
            this.windowsUIViewMain.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileQueries,
            this.tileDictionaries,
            this.tileDictMunicipality,
            this.tileDictCheck,
            this.tileDictEdu,
            this.tileDictTemplate,
            this.tileForms,
            this.tileSpreadsheet,
            this.tileCreateQuery,
            this.tileAdditionalForms,
            this.tileArchiveForms,
            this.tileEduPasport,
            this.tileMessage,
            this.tileRequestQuery,
            this.tileBugReport,
            this.tileMessageList,
            this.tileDictForms,
            this.tileFormStatistics,
            this.tileMunicipalityForms,
            this.tileArchiveMunicipalityForms,
            this.tileArchiveAdditionalForms,
            this.tileDictMunicipalityFormula,
            this.tileMunicipalityAdditonalForms,
            this.tileArchiveMunicipalityAdditonalForms});
            this.windowsUIViewMain.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            this.windowsUIViewMain.UseTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.windowsUIViewMain.ContentContainerActivated += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.ContentContainerEventHandler(this.windowsUIViewMain_ContentContainerActivated);
            this.windowsUIViewMain.BackButtonClick += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BackButtonClickEventHandler(this.windowsUIViewMain_BackButtonClick);
            this.windowsUIViewMain.FlyoutHiding += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCancelEventHandler(this.windowsUIViewMain_FlyoutHiding);
            this.windowsUIViewMain.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            this.windowsUIViewMain.ControlReleasing += new DevExpress.XtraBars.Docking2010.Views.ControlReleasingEventHandler(this.windowsUIViewMain_ControlReleasing);
            // 
            // tileContainerMain
            // 
            this.tileContainerMain.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileContainerMain.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileContainerMain.Caption = "\"Региональная образовательная статистика\"";
            this.tileContainerMain.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileForms,
            this.tileMunicipalityForms,
            this.tileArchiveForms,
            this.tileArchiveMunicipalityForms,
            this.tileSpreadsheet,
            this.tileAdditionalForms,
            this.tileArchiveAdditionalForms,
            this.tileMunicipalityAdditonalForms,
            this.tileArchiveMunicipalityAdditonalForms,
            this.tileQueries,
            this.tileCreateQuery,
            this.tileDictionaries,
            this.tileFormStatistics,
            this.tileMessageList,
            this.tileMessage,
            this.tileEduPasport});
            this.tileContainerMain.Name = "tileContainerMain";
            this.tileContainerMain.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileContainerMain.Properties.IndentBetweenGroups = 24;
            this.tileContainerMain.Properties.IndentBetweenItems = 6;
            this.tileContainerMain.Properties.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.tileContainerMain.Properties.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft;
            this.tileContainerMain.Properties.ItemSize = 128;
            this.tileContainerMain.Properties.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Default;
            this.tileContainerMain.Properties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tileContainerMain.Properties.RowCount = 3;
            this.tileContainerMain.Properties.ShowGroupText = DevExpress.Utils.DefaultBoolean.False;
            this.tileContainerMain.Properties.ShowText = DevExpress.Utils.DefaultBoolean.False;
            this.tileContainerMain.Subtitle = "Программный комплекс";
            // 
            // tileForms
            // 
            this.tileForms.Appearances.Normal.BackColor = System.Drawing.Color.Brown;
            this.tileForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement1.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Формы Федерального статистического наблюдения";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "Образовательные организации";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileForms.Elements.Add(tileItemElement1);
            this.tileForms.Elements.Add(tileItemElement2);
            this.tileForms.Group = "TileGroupForms";
            this.tileForms.Name = "tileForms";
            this.tileForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileForms.Tag = "Forms";
            // 
            // tileMunicipalityForms
            // 
            this.tileMunicipalityForms.Appearances.Normal.BackColor = System.Drawing.Color.RosyBrown;
            this.tileMunicipalityForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileMunicipalityForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileMunicipalityForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileMunicipalityForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileMunicipalityForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement3.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Формы Федерального статистического наблюдения";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "Муниципалитет";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMunicipalityForms.Elements.Add(tileItemElement3);
            this.tileMunicipalityForms.Elements.Add(tileItemElement4);
            this.tileMunicipalityForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileMunicipalityForms, 10);
            this.tileMunicipalityForms.Name = "tileMunicipalityForms";
            this.tileMunicipalityForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileMunicipalityForms.Tag = "MunitForms";
            // 
            // tileArchiveForms
            // 
            this.tileArchiveForms.Appearances.Normal.BackColor = System.Drawing.Color.IndianRed;
            this.tileArchiveForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileArchiveForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileArchiveForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileArchiveForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement5.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement5.ImageSize = new System.Drawing.Size(32, 32);
            tileItemElement5.Text = "Архив";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "Образовательные организации";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveForms.Elements.Add(tileItemElement5);
            this.tileArchiveForms.Elements.Add(tileItemElement6);
            this.tileArchiveForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileArchiveForms, 3);
            this.tileArchiveForms.Name = "tileArchiveForms";
            this.tileArchiveForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileArchiveForms.Tag = "ArchiveForms";
            // 
            // tileArchiveMunicipalityForms
            // 
            this.tileArchiveMunicipalityForms.Appearances.Normal.BackColor = System.Drawing.Color.IndianRed;
            this.tileArchiveMunicipalityForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveMunicipalityForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileArchiveMunicipalityForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileArchiveMunicipalityForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileArchiveMunicipalityForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement7.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement7.Text = "Архив";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement8.Text = "Муниципалитет";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveMunicipalityForms.Elements.Add(tileItemElement7);
            this.tileArchiveMunicipalityForms.Elements.Add(tileItemElement8);
            this.tileArchiveMunicipalityForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileArchiveMunicipalityForms, 11);
            this.tileArchiveMunicipalityForms.Name = "tileArchiveMunicipalityForms";
            this.tileArchiveMunicipalityForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileSpreadsheet
            // 
            this.tileSpreadsheet.ActivationTarget = this.pageGroupUploadForm;
            this.tileSpreadsheet.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(148)))));
            this.tileSpreadsheet.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileSpreadsheet.Appearances.Normal.Options.UseBackColor = true;
            this.tileSpreadsheet.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement9.AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            tileItemElement9.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement9.Appearance.Normal.Options.UseFont = true;
            tileItemElement9.Image = global::EduFormManager.Properties.Resources.Arrow_upload_2_icon;
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement9.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement9.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement9.Text = "Отправить форму";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileSpreadsheet.Elements.Add(tileItemElement9);
            this.tileSpreadsheet.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileSpreadsheet, 4);
            this.tileSpreadsheet.Name = "tileSpreadsheet";
            this.tileSpreadsheet.Properties.AllowCheck = DevExpress.Utils.DefaultBoolean.True;
            this.tileSpreadsheet.Tag = "Spreadsheet";
            // 
            // pageGroupUploadForm
            // 
            this.pageGroupUploadForm.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.pageGroupUploadForm.Caption = "Загрузка формы";
            this.pageGroupUploadForm.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.documentUploadSheetFromTemplate,
            this.documentUploadSheetFromFile});
            this.pageGroupUploadForm.Name = "pageGroupUploadForm";
            this.pageGroupUploadForm.Parent = this.tileContainerMain;
            this.pageGroupUploadForm.Subtitle = "Не выбрана форма";
            // 
            // documentUploadSheetFromTemplate
            // 
            this.documentUploadSheetFromTemplate.Caption = "из шаблона";
            this.documentUploadSheetFromTemplate.ControlName = "UploadSheetFromTemplate";
            // 
            // documentUploadSheetFromFile
            // 
            this.documentUploadSheetFromFile.Caption = "из файла";
            this.documentUploadSheetFromFile.ControlName = "UploadSheetFromFile";
            // 
            // tileAdditionalForms
            // 
            this.tileAdditionalForms.Appearances.Normal.BackColor = System.Drawing.Color.SlateGray;
            this.tileAdditionalForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileAdditionalForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileAdditionalForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileAdditionalForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileAdditionalForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement10.Appearance.Normal.BorderColor = System.Drawing.Color.Transparent;
            tileItemElement10.Appearance.Normal.Options.UseBorderColor = true;
            tileItemElement10.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement10.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement10.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement10.Text = "Доп. формы";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement11.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement11.Appearance.Normal.Options.UseFont = true;
            tileItemElement11.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement11.Text = "Образовательные организации";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileAdditionalForms.Elements.Add(tileItemElement10);
            this.tileAdditionalForms.Elements.Add(tileItemElement11);
            this.tileAdditionalForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileAdditionalForms, 6);
            this.tileAdditionalForms.Name = "tileAdditionalForms";
            this.tileAdditionalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileAdditionalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileAdditionalForms.Properties.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Default;
            this.tileAdditionalForms.Tag = "Forms2";
            // 
            // tileArchiveAdditionalForms
            // 
            this.tileArchiveAdditionalForms.Appearances.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileArchiveAdditionalForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveAdditionalForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileArchiveAdditionalForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileArchiveAdditionalForms.Appearances.Normal.Options.UseBorderColor = true;
            this.tileArchiveAdditionalForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement12.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement12.Text = "Архив<br>Доп. формы ";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement13.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement13.Appearance.Normal.Options.UseFont = true;
            tileItemElement13.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement13.Text = "Образовательные организации";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveAdditionalForms.Elements.Add(tileItemElement12);
            this.tileArchiveAdditionalForms.Elements.Add(tileItemElement13);
            this.tileArchiveAdditionalForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileArchiveAdditionalForms, 12);
            this.tileArchiveAdditionalForms.Name = "tileArchiveAdditionalForms";
            this.tileArchiveAdditionalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveAdditionalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileMunicipalityAdditonalForms
            // 
            this.tileMunicipalityAdditonalForms.Appearances.Normal.BackColor = System.Drawing.Color.Sienna;
            this.tileMunicipalityAdditonalForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileMunicipalityAdditonalForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileMunicipalityAdditonalForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement14.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement14.Text = "Доп. формы";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement15.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement15.Appearance.Normal.Options.UseFont = true;
            tileItemElement15.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement15.Text = "Муниципалитет";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMunicipalityAdditonalForms.Elements.Add(tileItemElement14);
            this.tileMunicipalityAdditonalForms.Elements.Add(tileItemElement15);
            this.tileMunicipalityAdditonalForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileMunicipalityAdditonalForms, 13);
            this.tileMunicipalityAdditonalForms.Name = "tileMunicipalityAdditonalForms";
            this.tileMunicipalityAdditonalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityAdditonalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileArchiveMunicipalityAdditonalForms
            // 
            this.tileArchiveMunicipalityAdditonalForms.Appearances.Normal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tileArchiveMunicipalityAdditonalForms.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileArchiveMunicipalityAdditonalForms.Appearances.Normal.Options.UseBackColor = true;
            this.tileArchiveMunicipalityAdditonalForms.Appearances.Normal.Options.UseFont = true;
            tileItemElement16.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement16.Text = "Архив<br>Доп. формы";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement17.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement17.Appearance.Normal.Options.UseFont = true;
            tileItemElement17.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement17.Text = "Муниципалитет";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveMunicipalityAdditonalForms.Elements.Add(tileItemElement16);
            this.tileArchiveMunicipalityAdditonalForms.Elements.Add(tileItemElement17);
            this.tileArchiveMunicipalityAdditonalForms.Group = "TileGroupForms";
            this.tileContainerMain.SetID(this.tileArchiveMunicipalityAdditonalForms, 15);
            this.tileArchiveMunicipalityAdditonalForms.Name = "tileArchiveMunicipalityAdditonalForms";
            this.tileArchiveMunicipalityAdditonalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityAdditonalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileQueries
            // 
            this.tileQueries.ActivationTarget = this.pageGroupQueries;
            this.tileQueries.Appearances.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileQueries.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileQueries.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileQueries.Appearances.Normal.Options.UseBackColor = true;
            this.tileQueries.Appearances.Normal.Options.UseBorderColor = true;
            this.tileQueries.Appearances.Normal.Options.UseFont = true;
            tileItemElement18.Image = global::EduFormManager.Properties.Resources.summary_icon;
            tileItemElement18.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement18.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement18.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement18.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement18.Text = "Запросы";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileQueries.Elements.Add(tileItemElement18);
            this.tileQueries.Group = "TileGroup2";
            this.tileContainerMain.SetID(this.tileQueries, 1);
            this.tileQueries.Name = "tileQueries";
            this.tileQueries.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileQueries.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileQueries.Properties.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.tileQueries.Tag = "Queries";
            // 
            // pageGroupQueries
            // 
            this.pageGroupQueries.Caption = "Запросы";
            this.pageGroupQueries.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.documentQueriesEdu,
            this.documentQueriesMunicipality});
            this.pageGroupQueries.Name = "pageGroupQueries";
            this.pageGroupQueries.Parent = this.tileContainerMain;
            // 
            // documentQueriesEdu
            // 
            this.documentQueriesEdu.Caption = "К организациям";
            this.documentQueriesEdu.ControlName = "QueriesEdu";
            this.documentQueriesEdu.Header = "";
            // 
            // documentQueriesMunicipality
            // 
            this.documentQueriesMunicipality.Caption = "К муниципалитетам";
            this.documentQueriesMunicipality.ControlName = "QueriesMunicipality";
            // 
            // tileCreateQuery
            // 
            this.tileCreateQuery.ActivationTarget = this.pageCreateQuery;
            this.tileCreateQuery.Appearances.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileCreateQuery.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileCreateQuery.Appearances.Normal.Options.UseBackColor = true;
            this.tileCreateQuery.Appearances.Normal.Options.UseFont = true;
            tileItemElement19.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement19.Text = "Создание запроса";
            tileItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileCreateQuery.Elements.Add(tileItemElement19);
            this.tileCreateQuery.Group = "TileGroup2";
            this.tileContainerMain.SetID(this.tileCreateQuery, 14);
            this.tileCreateQuery.Name = "tileCreateQuery";
            this.tileCreateQuery.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileCreateQuery.Tag = "CreateQuery";
            // 
            // pageCreateQuery
            // 
            this.pageCreateQuery.Caption = "Создать запрос";
            this.pageCreateQuery.Document = this.documentCreateQuery;
            this.pageCreateQuery.Name = "pageCreateQuery";
            this.pageCreateQuery.Parent = this.tileContainerMain;
            // 
            // documentCreateQuery
            // 
            this.documentCreateQuery.Caption = "Создание запроса";
            this.documentCreateQuery.ControlName = "DictCreateQuery";
            // 
            // tileDictionaries
            // 
            this.tileDictionaries.ActivationTarget = this.tileContainerDictionaries;
            this.tileDictionaries.Appearances.Normal.BackColor = System.Drawing.Color.DimGray;
            this.tileDictionaries.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileDictionaries.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileDictionaries.Appearances.Normal.Options.UseBackColor = true;
            this.tileDictionaries.Appearances.Normal.Options.UseBorderColor = true;
            this.tileDictionaries.Appearances.Normal.Options.UseFont = true;
            tileItemElement25.Image = global::EduFormManager.Properties.Resources.stat_icon;
            tileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement25.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement25.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement25.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement25.Text = "Справочники";
            tileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileDictionaries.Elements.Add(tileItemElement25);
            this.tileDictionaries.Enabled = true;
            this.tileDictionaries.Group = "TileGroup3";
            this.tileContainerMain.SetID(this.tileDictionaries, 2);
            this.tileDictionaries.Name = "tileDictionaries";
            this.tileDictionaries.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileDictionaries.Tag = "Dictionaries";
            // 
            // tileContainerDictionaries
            // 
            this.tileContainerDictionaries.AppearanceButton.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.tileContainerDictionaries.AppearanceButton.Normal.Options.UseForeColor = true;
            this.tileContainerDictionaries.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.tileContainerDictionaries.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileContainerDictionaries.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileContainerDictionaries.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileContainerDictionaries.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileContainerDictionaries.AppearanceItem.Normal.Options.UseFont = true;
            this.tileContainerDictionaries.Caption = "Справочники";
            this.tileContainerDictionaries.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileDictMunicipality,
            this.tileDictEdu,
            this.tileDictTemplate,
            this.tileDictForms,
            this.tileDictMunicipalityFormula});
            this.tileContainerDictionaries.Name = "tileContainerDictionaries";
            this.tileContainerDictionaries.Parent = this.tileContainerMain;
            this.tileContainerDictionaries.Properties.IndentBetweenGroups = 1;
            this.tileContainerDictionaries.Properties.IndentBetweenItems = 1;
            // 
            // tileDictMunicipality
            // 
            this.tileDictMunicipality.ActivationTarget = this.pageMunit;
            tileItemElement20.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement20.Text = "Муниципалитеты";
            this.tileDictMunicipality.Elements.Add(tileItemElement20);
            this.tileDictMunicipality.Name = "tileDictMunicipality";
            this.tileDictMunicipality.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // pageMunit
            // 
            this.pageMunit.Caption = "Муниципалитеты";
            this.pageMunit.Document = this.documentDictMunicipality;
            this.pageMunit.Name = "pageMunit";
            this.pageMunit.Parent = this.tileContainerDictionaries;
            // 
            // documentDictMunicipality
            // 
            this.documentDictMunicipality.Caption = "Муниципалитеты";
            this.documentDictMunicipality.ControlName = "DictMunicipality";
            // 
            // tileDictEdu
            // 
            this.tileDictEdu.ActivationTarget = this.pageEdu;
            tileItemElement21.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement21.Text = "Образовательные организации";
            this.tileDictEdu.Elements.Add(tileItemElement21);
            this.tileContainerDictionaries.SetID(this.tileDictEdu, 2);
            this.tileDictEdu.Name = "tileDictEdu";
            this.tileDictEdu.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // pageEdu
            // 
            this.pageEdu.Caption = "Образовательные организации";
            this.pageEdu.Document = this.documentDictEdu;
            this.pageEdu.Name = "pageEdu";
            this.pageEdu.Parent = this.tileContainerDictionaries;
            // 
            // documentDictEdu
            // 
            this.documentDictEdu.ActionCaption = "Назад";
            this.documentDictEdu.Caption = "Образовательные организации";
            this.documentDictEdu.ControlName = "DictEdu";
            // 
            // tileDictTemplate
            // 
            this.tileDictTemplate.ActivationTarget = this.pageTemplate;
            tileItemElement22.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement22.Text = "Шаблоны форм";
            this.tileDictTemplate.Elements.Add(tileItemElement22);
            this.tileContainerDictionaries.SetID(this.tileDictTemplate, 3);
            this.tileDictTemplate.Name = "tileDictTemplate";
            this.tileDictTemplate.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // pageTemplate
            // 
            this.pageTemplate.Caption = "Шаблоны форм";
            this.pageTemplate.Document = this.documentDictTemplate;
            this.pageTemplate.Name = "pageTemplate";
            this.pageTemplate.Parent = this.tileContainerDictionaries;
            // 
            // documentDictTemplate
            // 
            this.documentDictTemplate.Caption = "Шаблоны форм";
            this.documentDictTemplate.ControlName = "DictTemplate";
            // 
            // tileDictForms
            // 
            this.tileDictForms.ActivationTarget = this.pageForms;
            tileItemElement23.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement23.Text = "Формы";
            this.tileDictForms.Elements.Add(tileItemElement23);
            this.tileContainerDictionaries.SetID(this.tileDictForms, 5);
            this.tileDictForms.Name = "tileDictForms";
            this.tileDictForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // pageForms
            // 
            this.pageForms.Caption = "Формы";
            this.pageForms.Document = this.documentDictForms;
            this.pageForms.Name = "pageForms";
            this.pageForms.Parent = this.tileContainerDictionaries;
            // 
            // documentDictForms
            // 
            this.documentDictForms.Caption = "Формы";
            this.documentDictForms.ControlName = "DictForms";
            // 
            // tileDictMunicipalityFormula
            // 
            this.tileDictMunicipalityFormula.ActivationTarget = this.pageMunicipalityFormula;
            tileItemElement24.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement24.Text = "Формулы для заполнения муниципалитетных форм";
            tileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.tileDictMunicipalityFormula.Elements.Add(tileItemElement24);
            this.tileContainerDictionaries.SetID(this.tileDictMunicipalityFormula, 1);
            this.tileDictMunicipalityFormula.Name = "tileDictMunicipalityFormula";
            this.tileDictMunicipalityFormula.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // pageMunicipalityFormula
            // 
            this.pageMunicipalityFormula.Caption = "Сводные формулы";
            this.pageMunicipalityFormula.Document = this.documentDictMunicipalityFormula;
            this.pageMunicipalityFormula.Name = "pageMunicipalityFormula";
            this.pageMunicipalityFormula.Parent = this.tileContainerDictionaries;
            // 
            // documentDictMunicipalityFormula
            // 
            this.documentDictMunicipalityFormula.Caption = "Сводные формулы";
            this.documentDictMunicipalityFormula.ControlName = "DictMunicipalityFormula";
            // 
            // tileFormStatistics
            // 
            this.tileFormStatistics.ActivationTarget = this.tabbedGroupStatistics;
            this.tileFormStatistics.Appearances.Normal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tileFormStatistics.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileFormStatistics.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileFormStatistics.Appearances.Normal.Options.UseBackColor = true;
            this.tileFormStatistics.Appearances.Normal.Options.UseBorderColor = true;
            this.tileFormStatistics.Appearances.Normal.Options.UseFont = true;
            tileItemElement26.Image = global::EduFormManager.Properties.Resources.analytics_icon;
            tileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement26.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement26.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement26.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement26.Text = "Статистика";
            tileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileFormStatistics.Elements.Add(tileItemElement26);
            this.tileFormStatistics.Group = "TileGroup3";
            this.tileContainerMain.SetID(this.tileFormStatistics, 9);
            this.tileFormStatistics.Name = "tileFormStatistics";
            this.tileFormStatistics.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileFormStatistics.Tag = "Statistics";
            // 
            // tabbedGroupStatistics
            // 
            this.tabbedGroupStatistics.Caption = "Статистика";
            this.tabbedGroupStatistics.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.documentFormStatistics,
            this.documentFormStatisticsSummary,
            this.documentFormDetailedStatistics,
            this.documentSignInOutLog,
            this.documentMunicipalityFormStatistics,
            this.documentMunicipalityFormDetailedStatistics});
            this.tabbedGroupStatistics.Name = "tabbedGroupStatistics";
            this.tabbedGroupStatistics.Parent = this.tileContainerMain;
            // 
            // documentFormStatistics
            // 
            this.documentFormStatistics.Caption = "Статистика форм";
            this.documentFormStatistics.ControlName = "FormStatistics";
            // 
            // documentFormStatisticsSummary
            // 
            this.documentFormStatisticsSummary.Caption = "Статистика форм (сводная)";
            this.documentFormStatisticsSummary.ControlName = "FormStatisticsSummary";
            // 
            // documentFormDetailedStatistics
            // 
            this.documentFormDetailedStatistics.Caption = "Статистика форм (детально)";
            this.documentFormDetailedStatistics.ControlName = "FormDetailedStatistics";
            // 
            // documentSignInOutLog
            // 
            this.documentSignInOutLog.Caption = "Лог посещений";
            this.documentSignInOutLog.ControlName = "SignInOutLog";
            // 
            // documentMunicipalityFormStatistics
            // 
            this.documentMunicipalityFormStatistics.Caption = "Статистистика форм муниципалитетов";
            this.documentMunicipalityFormStatistics.ControlName = "MunicipalityFormStatistics";
            // 
            // documentMunicipalityFormDetailedStatistics
            // 
            this.documentMunicipalityFormDetailedStatistics.Caption = "Статистика форм (детально) муниципалитетов";
            this.documentMunicipalityFormDetailedStatistics.ControlName = "MunicipalityFormDetailedStatistics";
            // 
            // tileMessageList
            // 
            this.tileMessageList.ActivationTarget = this.pageMessageList;
            this.tileMessageList.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(141)))));
            this.tileMessageList.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileMessageList.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileMessageList.Appearances.Normal.Options.UseBackColor = true;
            this.tileMessageList.Appearances.Normal.Options.UseBorderColor = true;
            this.tileMessageList.Appearances.Normal.Options.UseFont = true;
            tileItemElement27.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement27.Text = "0";
            tileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement28.Image = global::EduFormManager.Properties.Resources.email_icon;
            tileItemElement28.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement28.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement28.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement28.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement28.Text = "Сообщения";
            tileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMessageList.Elements.Add(tileItemElement27);
            this.tileMessageList.Elements.Add(tileItemElement28);
            this.tileMessageList.Group = "TileGroup3";
            this.tileContainerMain.SetID(this.tileMessageList, 8);
            this.tileMessageList.Name = "tileMessageList";
            this.tileMessageList.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileMessageList.Tag = "MessageList";
            // 
            // pageMessageList
            // 
            this.pageMessageList.Caption = "Сообщения";
            this.pageMessageList.Document = this.documentMessageList;
            this.pageMessageList.Name = "pageMessageList";
            this.pageMessageList.Parent = this.tileContainerMain;
            // 
            // documentMessageList
            // 
            this.documentMessageList.Caption = "Сообщения";
            this.documentMessageList.ControlName = "MessageList";
            this.documentMessageList.Tag = "MessageList";
            // 
            // tileMessage
            // 
            this.tileMessage.ActivationTarget = this.tileContainerMessage;
            this.tileMessage.Appearances.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileMessage.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileMessage.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileMessage.Appearances.Normal.Options.UseBackColor = true;
            this.tileMessage.Appearances.Normal.Options.UseBorderColor = true;
            this.tileMessage.Appearances.Normal.Options.UseFont = true;
            tileItemElement32.Image = global::EduFormManager.Properties.Resources.email_2_icon;
            tileItemElement32.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement32.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement32.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement32.ImageSize = new System.Drawing.Size(80, 80);
            tileItemElement32.Text = "Отправить сообщение";
            tileItemElement32.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMessage.Elements.Add(tileItemElement32);
            this.tileMessage.Group = "TileGroup3";
            this.tileContainerMain.SetID(this.tileMessage, 7);
            this.tileMessage.Name = "tileMessage";
            this.tileMessage.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileMessage.Tag = "Message";
            // 
            // tileContainerMessage
            // 
            this.tileContainerMessage.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.tileContainerMessage.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileContainerMessage.Caption = "Отправить сообщение";
            this.tileContainerMessage.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileRequestQuery,
            this.tileBugReport});
            this.tileContainerMessage.Name = "tileContainerMessage";
            this.tileContainerMessage.Parent = this.tileContainerMain;
            // 
            // tileRequestQuery
            // 
            this.tileRequestQuery.ActivationTarget = this.pageRequestQuery;
            this.tileRequestQuery.Appearances.Normal.BackColor = System.Drawing.Color.DarkKhaki;
            this.tileRequestQuery.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileRequestQuery.Appearances.Normal.Options.UseBackColor = true;
            this.tileRequestQuery.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement29.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement29.Appearance.Normal.Options.UseFont = true;
            tileItemElement29.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement29.Text = "Новый запрос по требованию";
            tileItemElement30.Image = global::EduFormManager.Properties.Resources.document_add_icon;
            tileItemElement30.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement30.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement30.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement30.ImageSize = new System.Drawing.Size(128, 128);
            tileItemElement30.Text = "";
            this.tileRequestQuery.Elements.Add(tileItemElement29);
            this.tileRequestQuery.Elements.Add(tileItemElement30);
            this.tileRequestQuery.Name = "tileRequestQuery";
            this.tileRequestQuery.Tag = "MessageRequestQuery";
            // 
            // pageRequestQuery
            // 
            this.pageRequestQuery.Document = this.documentRequestQuery;
            this.pageRequestQuery.Name = "pageRequestQuery";
            this.pageRequestQuery.Parent = this.tileContainerMessage;
            // 
            // documentRequestQuery
            // 
            this.documentRequestQuery.Caption = "Запрос по требованию";
            this.documentRequestQuery.ControlName = "RequestQuery";
            // 
            // tileBugReport
            // 
            this.tileBugReport.ActivationTarget = this.pageBugReport;
            this.tileBugReport.Appearances.Normal.BackColor = System.Drawing.Color.DarkKhaki;
            this.tileBugReport.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileBugReport.Appearances.Normal.Options.UseBackColor = true;
            this.tileBugReport.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement31.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement31.Appearance.Normal.Options.UseFont = true;
            tileItemElement31.Image = global::EduFormManager.Properties.Resources.document_file_icon;
            tileItemElement31.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement31.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement31.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement31.ImageSize = new System.Drawing.Size(128, 128);
            tileItemElement31.Text = "Сообщить об ошибке";
            this.tileBugReport.Elements.Add(tileItemElement31);
            this.tileContainerMessage.SetID(this.tileBugReport, 1);
            this.tileBugReport.Name = "tileBugReport";
            this.tileBugReport.Tag = "MessageBugReport";
            // 
            // pageBugReport
            // 
            this.pageBugReport.Caption = "Сообщить об ошибке";
            this.pageBugReport.Document = this.documentBugReport;
            this.pageBugReport.Name = "pageBugReport";
            this.pageBugReport.Parent = this.tileContainerMessage;
            // 
            // documentBugReport
            // 
            this.documentBugReport.Caption = "Сообщение о найденной ошибке";
            this.documentBugReport.ControlName = "BugReport";
            // 
            // tileEduPasport
            // 
            this.tileEduPasport.ActivationTarget = this.pageEduPassport;
            this.tileEduPasport.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileEduPasport.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileEduPasport.Appearances.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileEduPasport.Appearances.Normal.Options.UseBackColor = true;
            this.tileEduPasport.Appearances.Normal.Options.UseBorderColor = true;
            this.tileEduPasport.Appearances.Normal.Options.UseFont = true;
            tileItemElement33.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement33.Text = "Паспорт";
            tileItemElement33.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement34.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement34.Appearance.Normal.Options.UseFont = true;
            tileItemElement34.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement34.Text = "-";
            tileItemElement34.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.tileEduPasport.Elements.Add(tileItemElement33);
            this.tileEduPasport.Elements.Add(tileItemElement34);
            this.tileEduPasport.Group = "TileGroup3";
            this.tileContainerMain.SetID(this.tileEduPasport, 5);
            this.tileEduPasport.Name = "tileEduPasport";
            this.tileEduPasport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileEduPasport.Tag = "EduPassport";
            // 
            // pageEduPassport
            // 
            this.pageEduPassport.Caption = "Паспорт образовательной организации";
            this.pageEduPassport.Document = this.documentEduPasport;
            this.pageEduPassport.Name = "pageEduPassport";
            this.pageEduPassport.Parent = this.tileContainerMain;
            // 
            // documentEduPasport
            // 
            this.documentEduPasport.Caption = "Паспорт";
            this.documentEduPasport.ControlName = "Pasport";
            this.documentEduPasport.Header = "LOL";
            // 
            // flyoutInProgress
            // 
            this.flyoutInProgress.Caption = "Загрузка...";
            this.flyoutInProgress.Document = this.documentInProgress;
            this.flyoutInProgress.Name = "flyoutInProgress";
            // 
            // documentInProgress
            // 
            this.documentInProgress.Caption = "documentInProgress";
            this.documentInProgress.ControlName = "XtraProgress";
            // 
            // flyoutQuit
            // 
            this.flyoutQuit.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.YesNo;
            this.flyoutQuit.Name = "flyoutQuit";
            this.flyoutQuit.Subtitle = "Выйти из приложения?";
            // 
            // flyoutLogin
            // 
            this.flyoutLogin.Document = this.documentLogin;
            this.flyoutLogin.Name = "flyoutLogin";
            // 
            // documentLogin
            // 
            this.documentLogin.Caption = "Вход";
            this.documentLogin.ControlName = "Authentication";
            // 
            // flyoutMessage
            // 
            this.flyoutMessage.Caption = "Сообщение";
            this.flyoutMessage.Name = "flyoutMessage";
            // 
            // pageCheck
            // 
            this.pageCheck.Caption = "Формулы";
            this.pageCheck.Document = this.documentDictCheck;
            this.pageCheck.Name = "pageCheck";
            this.pageCheck.Parent = this.tileContainerDictionaries;
            // 
            // documentDictCheck
            // 
            this.documentDictCheck.Caption = "Формулы";
            this.documentDictCheck.ControlName = "DictCheck";
            // 
            // pageQuestionary
            // 
            this.pageQuestionary.Caption = "Анкеты";
            this.pageQuestionary.Document = this.documentDictQuestionary;
            this.pageQuestionary.Name = "pageQuestionary";
            this.pageQuestionary.Parent = this.tileContainerDictionaries;
            // 
            // documentDictQuestionary
            // 
            this.documentDictQuestionary.Caption = "Анекта";
            this.documentDictQuestionary.ControlName = "DictQuestionary";
            // 
            // flyoutExportReport
            // 
            this.flyoutExportReport.Caption = "Экспорт";
            this.flyoutExportReport.Document = this.documentExportReport;
            this.flyoutExportReport.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OKCancel;
            this.flyoutExportReport.Name = "flyoutExportReport";
            // 
            // documentExportReport
            // 
            this.documentExportReport.Caption = "documentExportReport";
            this.documentExportReport.ControlName = "ExportReport";
            // 
            // pageDetailedStatisticsReport
            // 
            this.pageDetailedStatisticsReport.Caption = "Статистика форм (детально)";
            this.pageDetailedStatisticsReport.Document = this.documentFormDetailedStatisticsReport;
            this.pageDetailedStatisticsReport.Name = "pageDetailedStatisticsReport";
            this.pageDetailedStatisticsReport.Parent = this.tabbedGroupStatistics;
            // 
            // documentFormDetailedStatisticsReport
            // 
            this.documentFormDetailedStatisticsReport.Caption = "Статистика форм (детально) отчет";
            this.documentFormDetailedStatisticsReport.ControlName = "FormDetailedStatisticsReport";
            // 
            // tabbedGroupQueryReports
            // 
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Hovered.Options.UseTextOptions = true;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Normal.Options.UseTextOptions = true;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Pressed.Options.UseTextOptions = true;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tabbedGroupQueryReports.AppearanceHeaderButton.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tabbedGroupQueryReports.Caption = "Результаты запросов";
            this.tabbedGroupQueryReports.Name = "tabbedGroupQueryReports";
            this.tabbedGroupQueryReports.Properties.AllowHtmlDrawHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.tabbedGroupQueryReports.Properties.HeaderStyle = DevExpress.XtraBars.Docking2010.Views.WindowsUI.HeaderStyle.Tile;
            this.tabbedGroupQueryReports.Properties.TileSize = 150;
            // 
            // pageDetailedMunicipalityStatisticsReport
            // 
            this.pageDetailedMunicipalityStatisticsReport.Caption = "Статистика форм муниципалитетов (детально)";
            this.pageDetailedMunicipalityStatisticsReport.Document = this.documentMunicipalityFormDetailedStatisticsReport;
            this.pageDetailedMunicipalityStatisticsReport.Name = "pageDetailedMunicipalityStatisticsReport";
            this.pageDetailedMunicipalityStatisticsReport.Parent = this.tabbedGroupStatistics;
            // 
            // documentMunicipalityFormDetailedStatisticsReport
            // 
            this.documentMunicipalityFormDetailedStatisticsReport.Caption = "Статистика форм муниципалитетов (детально) отчет";
            this.documentMunicipalityFormDetailedStatisticsReport.ControlName = "MunicipalityFormDetailedStatisticsReport";
            // 
            // tileDictCheck
            // 
            this.tileDictCheck.ActivationTarget = this.pageCheck;
            tileItemElement35.ImageBorderColor = System.Drawing.Color.Empty;
            tileItemElement35.Text = "Формулы";
            this.tileDictCheck.Elements.Add(tileItemElement35);
            this.tileDictCheck.Name = "tileDictCheck";
            this.tileDictCheck.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = null;
            // 
            // tileItem1
            // 
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            this.tileItem3.Name = "tileItem3";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileItem4
            // 
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem5
            // 
            this.tileItem5.Name = "tileItem5";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loggedUserControl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowLogs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.54545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.22727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 88);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Министерство образования и науки Астраханской области";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Государственное бюджетное учреждение Астраханской области";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"Центр мониторинга в образовании\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::EduFormManager.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(197, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loggedUserControl
            // 
            this.loggedUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedUserControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loggedUserControl.Appearance.Options.UseBackColor = true;
            this.loggedUserControl.Location = new System.Drawing.Point(790, 10);
            this.loggedUserControl.Name = "loggedUserControl";
            this.tableLayoutPanel1.SetRowSpan(this.loggedUserControl, 3);
            this.loggedUserControl.Size = new System.Drawing.Size(360, 68);
            this.loggedUserControl.TabIndex = 4;
            // 
            // buttonShowLogs
            // 
            this.buttonShowLogs.FlatAppearance.BorderSize = 0;
            this.buttonShowLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowLogs.Image = global::EduFormManager.Properties.Resources.glyphicons_144_folder_open_white;
            this.buttonShowLogs.Location = new System.Drawing.Point(1156, 3);
            this.buttonShowLogs.Name = "buttonShowLogs";
            this.buttonShowLogs.Size = new System.Drawing.Size(24, 20);
            this.buttonShowLogs.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonShowLogs, "Открыть каталог с логами");
            this.buttonShowLogs.UseVisualStyleBackColor = true;
            this.buttonShowLogs.Click += new System.EventHandler(this.buttonShowLogs_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EduFormManager.Properties.Resources.Exclamation_24_white;
            this.button1.Location = new System.Drawing.Point(1156, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.toolTip.SetToolTip(this.button1, "Показать уведомления");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // navigationBar
            // 
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar.Home = this.tileContainerMain;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(1186, 32);
            this.navigationBar.TabIndex = 5;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.LookAndFeel.SkinName = "Office 2013";
            this.splitContainerControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.flyoutPanel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.navigationBar);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1186, 706);
            this.splitContainerControl2.SplitterPosition = 88;
            this.splitContainerControl2.TabIndex = 6;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.flyoutPanel1.Appearance.Options.UseBackColor = true;
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(758, 32);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.flyoutPanel1.OptionsButtonPanel.AppearanceButton.Normal.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanel1.OptionsButtonPanel.AppearanceButton.Normal.Options.UseBackColor = true;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelHeight = 35;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Close", global::EduFormManager.Properties.Resources.close01_white1, false, true, "Закрыть панель")});
            this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanel1.OwnerControl = this.splitContainerControl2;
            this.flyoutPanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.flyoutPanel1.ParentForm = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(361, 124);
            this.flyoutPanel1.TabIndex = 7;
            this.flyoutPanel1.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flyoutPanel1_ButtonClick);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelControl1.Controls.Add(this.collapsableSideListBoxControl1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 35);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(361, 89);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // collapsableSideListBoxControl1
            // 
            this.collapsableSideListBoxControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.collapsableSideListBoxControl1.Appearance.Options.UseForeColor = true;
            this.collapsableSideListBoxControl1.ControlType = EduFormManager.Forms.UserControls.XtraBaseControl.Type.Form;
            this.collapsableSideListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapsableSideListBoxControl1.FormDataSource = null;
            this.collapsableSideListBoxControl1.FormTypeDataSource = null;
            this.collapsableSideListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.collapsableSideListBoxControl1.LookAndFeel.SkinName = "Office 2013";
            this.collapsableSideListBoxControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.collapsableSideListBoxControl1.Name = "collapsableSideListBoxControl1";
            this.collapsableSideListBoxControl1.Repo = null;
            this.collapsableSideListBoxControl1.Size = new System.Drawing.Size(361, 89);
            this.collapsableSideListBoxControl1.TabIndex = 0;
            this.collapsableSideListBoxControl1.View = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.docContainer);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 571);
            this.panel1.TabIndex = 8;
            // 
            // expireWarnBindingSource
            // 
            this.expireWarnBindingSource.DataSource = typeof(EduFormManager.Notifications.ExpireWarn);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            // 
            // mainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(1186, 705);
            this.Controls.Add(this.splitContainerControl2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSpreadsheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupUploadForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAdditionalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveAdditionalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityAdditonalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityAdditonalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesMunicipality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerDictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictMunicipality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMunit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictMunicipality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictMunicipalityFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMunicipalityFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictMunicipalityFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatisticsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSignInOutLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMessageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMessageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMessageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileRequestQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequestQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRequestQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEduPasport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEduPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentEduPasport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageQuestionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDictQuestionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutExportReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentExportReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDetailedStatisticsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatisticsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupQueryReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDetailedMunicipalityStatisticsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatisticsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileDictCheck)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expireWarnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private DocumentManager documentManagerMain;
        private WindowsUIView windowsUIViewMain;
        private Document documentQueriesEdu;
        private Document documentDictMunicipality;
        private Document documentDictCheck;
        private Document documentDictEdu;
        private Document documentDictTemplate;
        private TileGroup tileGroup1;
        private TileItem tileItem1;
        private TileItem tileItem2;
        private TileItem tileItem3;
        private TileGroup tileGroup2;
        private TileItem tileItem4;
        private TileItem tileItem5;
        private TileGroup tileGroup4;
        private Document documentLogin;
        private Document documentUploadSheetFromFile;
        private Document documentInProgress;
        private Document documentCreateQuery;

        private DocumentManagerContainer docContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Document documentEduPasport;
        private PictureBox pictureBox1;


        private Document documentRequestQuery;
        private Document documentBugReport;
        private TileContainer tileContainerMain;
        private Tile tileForms;
        private Tile tileQueries;
        private Tile tileDictionaries;
        private TileContainer tileContainerDictionaries;
        private Tile tileDictMunicipality;
        private Tile tileDictCheck;
        private Tile tileDictEdu;
        private Tile tileDictTemplate;
        private Tile tileCreateQuery;
        private Tile tileMessage;
        private TileContainer tileContainerMessage;
        private Tile tileRequestQuery;
        private Tile tileBugReport;
        private Tile tileArchiveForms;
        private Tile tileEduPasport;
        private Tile tileAdditionalForms;
        private Tile tileSpreadsheet;
        private Tile tileMessageList;
        private Document documentMessageList;
        private Flyout flyoutInProgress;
        private Flyout flyoutQuit;
        private Flyout flyoutLogin;
        private Flyout flyoutMessage;
        private Tile tileDictForms;
        private Document documentDictForms;
        private XtraLoggedUserControl loggedUserControl;
        private NavigationBar navigationBar;
        private Page pageEduPassport;
        private Page pageMunit;
        private Page pageCheck;
        private Page pageEdu;
        private Page pageCreateQuery;
        private Page pageForms;
        private Page pageRequestQuery;
        private Page pageBugReport;
        private Page pageMessageList;
        private Tile tileFormStatistics;
        private Document documentFormStatistics;
        private Document documentFormStatisticsSummary;
        private PageGroup pageGroupUploadForm;
        private Document documentUploadSheetFromTemplate;
        private SplitContainerControl splitContainerControl2;
        private FlyoutPanel flyoutPanel1;
        private FlyoutPanelControl flyoutPanelControl1;
        private BindingSource expireWarnBindingSource;
        private CollapsableSideListBoxControl collapsableSideListBoxControl1;
        private Button button1;
        private Panel panel1;
        private Button buttonShowLogs;
        private Document documentSignInOutLog;
        private Tile tileMunicipalityForms;
        private Tile tileArchiveAdditionalForms;
        private Tile tileArchiveMunicipalityForms;
        private Tile tileDictMunicipalityFormula;
        private Page pageMunicipalityFormula;
        private Document documentDictMunicipalityFormula;
        private Document documentDictQuestionary;
        private Page pageQuestionary;
        private ToolTip toolTip;
        private Flyout flyoutExportReport;
        private Document documentExportReport;
        private Document documentFormDetailedStatistics;
        private Page pageDetailedStatisticsReport;
        private Document documentFormDetailedStatisticsReport;
        private TabbedGroup tabbedGroupQueryReports;
        private TabbedGroup tabbedGroupStatistics;
        private Tile tileMunicipalityAdditonalForms;
        private Tile tileArchiveMunicipalityAdditonalForms;
        private Document documentMunicipalityFormStatistics;
        private Document documentMunicipalityFormDetailedStatistics;
        private Page pageDetailedMunicipalityStatisticsReport;
        private Document documentMunicipalityFormDetailedStatisticsReport;
        private PageGroup pageGroupQueries;
        private Document documentQueriesMunicipality;
        private Page pageTemplate;
    }
}

