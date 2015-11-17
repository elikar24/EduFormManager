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
    partial class MainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement20 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement21 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement22 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement23 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement24 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement33 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement29 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement30 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement31 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement32 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement34 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.docContainer = new EduFormManager.Forms.DocumentManagerContainer();
            this.windowsUIViewMain = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainerMain = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileMunicipalityForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveMunicipalityAdditonalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileMunicipalityAdditonalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileAdditionalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveAdditionalForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveMunicipalityForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileArchiveForms = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileSpreadsheet = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroupUploadForm = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.documentUploadSheetFromTemplate = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentUploadSheetFromFile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroupQueries = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.documentQueriesEdu = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentQueriesMunicipality = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentCreateQuery = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileEduPasport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageEduPassport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.documentEduPasport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
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
            this.tileFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tabbedGroupStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
            this.documentFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentFormStatisticsSummary = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentFormDetailedStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentSignInOutLog = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentMunicipalityFormStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentMunicipalityFormDetailedStatistics = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonShowNotifications = new DevExpress.XtraEditors.SimpleButton();
            this.buttonShowLogs = new DevExpress.XtraEditors.SimpleButton();
            this.labelLoggedUser = new DevExpress.XtraEditors.LabelControl();
            this.labelHeader = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flyoutPanelNotifications = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelNotificationsControl = new DevExpress.Utils.FlyoutPanelControl();
            this.collapsableSideListBoxControl1 = new EduFormManager.Forms.CollapsableSideListBoxControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraNavPane = new EduFormManager.Forms.UserControls.XtraNavPane();
            this.expireWarnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityAdditonalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityAdditonalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAdditionalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveAdditionalForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSpreadsheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupUploadForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesMunicipality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCreateQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEduPasport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEduPassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentEduPasport)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tileFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatisticsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSignInOutLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatistics)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotifications)).BeginInit();
            this.flyoutPanelNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotificationsControl)).BeginInit();
            this.flyoutPanelNotificationsControl.SuspendLayout();
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
            this.docContainer.Size = new System.Drawing.Size(1186, 549);
            this.docContainer.TabIndex = 0;
            // 
            // windowsUIViewMain
            // 
            this.windowsUIViewMain.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            this.windowsUIViewMain.AppearanceCaption.Options.UseTextOptions = true;
            this.windowsUIViewMain.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
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
            this.windowsUIViewMain.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIViewMain_QueryControl);
            this.windowsUIViewMain.ControlReleasing += new DevExpress.XtraBars.Docking2010.Views.ControlReleasingEventHandler(this.windowsUIViewMain_ControlReleasing);
            // 
            // tileContainerMain
            // 
            this.tileContainerMain.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.tileContainerMain.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileContainerMain.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileContainerMain.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileContainerMain.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileContainerMain.AppearanceItem.Normal.Options.UseFont = true;
            this.tileContainerMain.Caption = "\"Региональная образовательная статистика\"";
            this.tileContainerMain.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileForms,
            this.tileMunicipalityForms,
            this.tileArchiveMunicipalityAdditonalForms,
            this.tileMunicipalityAdditonalForms,
            this.tileAdditionalForms,
            this.tileArchiveAdditionalForms,
            this.tileArchiveMunicipalityForms,
            this.tileArchiveForms,
            this.tileSpreadsheet,
            this.tileQueries,
            this.tileCreateQuery,
            this.tileEduPasport,
            this.tileMessageList,
            this.tileMessage,
            this.tileFormStatistics,
            this.tileDictionaries});
            this.tileContainerMain.Name = "tileContainerMain";
            this.tileContainerMain.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileContainerMain.Properties.AllowItemHover = DevExpress.Utils.DefaultBoolean.True;
            this.tileContainerMain.Properties.IndentBetweenGroups = 24;
            this.tileContainerMain.Properties.IndentBetweenItems = 6;
            this.tileContainerMain.Properties.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.None;
            this.tileContainerMain.Properties.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft;
            this.tileContainerMain.Properties.ItemSize = 95;
            this.tileContainerMain.Properties.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Default;
            this.tileContainerMain.Properties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tileContainerMain.Properties.RowCount = 3;
            this.tileContainerMain.Subtitle = "Программный комплекс";
            // 
            // tileForms
            // 
            this.tileForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement1.Image = global::EduFormManager.Properties.Resources.Box_32;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement1.Text = "Формы ФСН";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Образовательные организации";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileForms.Elements.Add(tileItemElement1);
            this.tileForms.Elements.Add(tileItemElement2);
            this.tileForms.Group = "1Group";
            this.tileForms.Name = "tileForms";
            this.tileForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileForms.Tag = "Forms";
            // 
            // tileMunicipalityForms
            // 
            this.tileMunicipalityForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileMunicipalityForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement3.Image = global::EduFormManager.Properties.Resources.Box_32;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement3.Text = "Формы ФСН";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Муниципалитет";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMunicipalityForms.Elements.Add(tileItemElement3);
            this.tileMunicipalityForms.Elements.Add(tileItemElement4);
            this.tileMunicipalityForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileMunicipalityForms, 10);
            this.tileMunicipalityForms.Name = "tileMunicipalityForms";
            this.tileMunicipalityForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileMunicipalityForms.Tag = "MunitForms";
            // 
            // tileArchiveMunicipalityAdditonalForms
            // 
            tileItemElement5.Text = "Архив доп. форм";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Text = "Муниципалитет";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveMunicipalityAdditonalForms.Elements.Add(tileItemElement5);
            this.tileArchiveMunicipalityAdditonalForms.Elements.Add(tileItemElement6);
            this.tileArchiveMunicipalityAdditonalForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileArchiveMunicipalityAdditonalForms, 15);
            this.tileArchiveMunicipalityAdditonalForms.Name = "tileArchiveMunicipalityAdditonalForms";
            this.tileArchiveMunicipalityAdditonalForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityAdditonalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityAdditonalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // tileMunicipalityAdditonalForms
            // 
            tileItemElement7.Text = "Доп. формы";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.Text = "Муниципалитет";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileMunicipalityAdditonalForms.Elements.Add(tileItemElement7);
            this.tileMunicipalityAdditonalForms.Elements.Add(tileItemElement8);
            this.tileMunicipalityAdditonalForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileMunicipalityAdditonalForms, 13);
            this.tileMunicipalityAdditonalForms.Name = "tileMunicipalityAdditonalForms";
            this.tileMunicipalityAdditonalForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityAdditonalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMunicipalityAdditonalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // tileAdditionalForms
            // 
            this.tileAdditionalForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileAdditionalForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement9.Appearance.Normal.BorderColor = System.Drawing.Color.Transparent;
            tileItemElement9.Appearance.Normal.Options.UseBorderColor = true;
            tileItemElement9.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement9.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement9.Text = "Доп. формы";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement10.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement10.Appearance.Normal.Options.UseFont = true;
            tileItemElement10.Text = "Образовательные организации";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileAdditionalForms.Elements.Add(tileItemElement9);
            this.tileAdditionalForms.Elements.Add(tileItemElement10);
            this.tileAdditionalForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileAdditionalForms, 4);
            this.tileAdditionalForms.Name = "tileAdditionalForms";
            this.tileAdditionalForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileAdditionalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileAdditionalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileAdditionalForms.Properties.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Default;
            this.tileAdditionalForms.Tag = "Forms2";
            // 
            // tileArchiveAdditionalForms
            // 
            this.tileArchiveAdditionalForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveAdditionalForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement11.Text = "Архив доп. форм ";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement12.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement12.Appearance.Normal.Options.UseFont = true;
            tileItemElement12.Text = "Образовательные организации";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveAdditionalForms.Elements.Add(tileItemElement11);
            this.tileArchiveAdditionalForms.Elements.Add(tileItemElement12);
            this.tileArchiveAdditionalForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileArchiveAdditionalForms, 12);
            this.tileArchiveAdditionalForms.Name = "tileArchiveAdditionalForms";
            this.tileArchiveAdditionalForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveAdditionalForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveAdditionalForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // tileArchiveMunicipalityForms
            // 
            this.tileArchiveMunicipalityForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveMunicipalityForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement13.Image = global::EduFormManager.Properties.Resources.BoxFilled_32;
            tileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement13.Text = "Архив";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement14.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement14.Appearance.Normal.Options.UseFont = true;
            tileItemElement14.Text = "Муниципалитет";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveMunicipalityForms.Elements.Add(tileItemElement13);
            this.tileArchiveMunicipalityForms.Elements.Add(tileItemElement14);
            this.tileArchiveMunicipalityForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileArchiveMunicipalityForms, 11);
            this.tileArchiveMunicipalityForms.Name = "tileArchiveMunicipalityForms";
            this.tileArchiveMunicipalityForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveMunicipalityForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // tileArchiveForms
            // 
            this.tileArchiveForms.Appearances.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileArchiveForms.Appearances.Normal.Options.UseBorderColor = true;
            tileItemElement15.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileItemElement15.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement15.Image = global::EduFormManager.Properties.Resources.BoxFilled_32;
            tileItemElement15.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement15.Text = "Архив";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement16.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            tileItemElement16.Appearance.Normal.Options.UseFont = true;
            tileItemElement16.Text = "Образовательные организации";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileArchiveForms.Elements.Add(tileItemElement15);
            this.tileArchiveForms.Elements.Add(tileItemElement16);
            this.tileArchiveForms.Group = "1Group";
            this.tileContainerMain.SetID(this.tileArchiveForms, 3);
            this.tileArchiveForms.Name = "tileArchiveForms";
            this.tileArchiveForms.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveForms.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileArchiveForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileArchiveForms.Tag = "ArchiveForms";
            // 
            // tileSpreadsheet
            // 
            this.tileSpreadsheet.ActivationTarget = this.pageGroupUploadForm;
            tileItemElement17.AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            tileItemElement17.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement17.Appearance.Normal.Options.UseFont = true;
            tileItemElement17.Image = global::EduFormManager.Properties.Resources.Upload_32;
            tileItemElement17.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement17.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement17.Text = "Отправить форму";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileSpreadsheet.Elements.Add(tileItemElement17);
            this.tileSpreadsheet.Group = "2Group";
            this.tileContainerMain.SetID(this.tileSpreadsheet, 4);
            this.tileSpreadsheet.Name = "tileSpreadsheet";
            this.tileSpreadsheet.Properties.AllowCheck = DevExpress.Utils.DefaultBoolean.True;
            this.tileSpreadsheet.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileSpreadsheet.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            this.pageGroupUploadForm.Subtitle = "Загрузка формы";
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
            // tileQueries
            // 
            this.tileQueries.ActivationTarget = this.pageGroupQueries;
            tileItemElement18.Image = global::EduFormManager.Properties.Resources.List_32;
            tileItemElement18.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement18.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement18.Text = "Запросы";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileQueries.Elements.Add(tileItemElement18);
            this.tileQueries.Group = "3Group";
            this.tileContainerMain.SetID(this.tileQueries, 1);
            this.tileQueries.Name = "tileQueries";
            this.tileQueries.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileQueries.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileQueries.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement19.Image = global::EduFormManager.Properties.Resources.AddList_32;
            tileItemElement19.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement19.Text = "Создать запрос";
            tileItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileCreateQuery.Elements.Add(tileItemElement19);
            this.tileCreateQuery.Group = "3Group";
            this.tileContainerMain.SetID(this.tileCreateQuery, 14);
            this.tileCreateQuery.Name = "tileCreateQuery";
            this.tileCreateQuery.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileCreateQuery.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            // tileEduPasport
            // 
            this.tileEduPasport.ActivationTarget = this.pageEduPassport;
            tileItemElement20.Image = global::EduFormManager.Properties.Resources.BusinessContact_32;
            tileItemElement20.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement20.Text = "Паспорт";
            tileItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement21.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tileItemElement21.Appearance.Normal.Options.UseFont = true;
            tileItemElement21.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement21.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement21.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            tileItemElement21.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileItemElement21.Text = "-";
            tileItemElement21.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.tileEduPasport.Elements.Add(tileItemElement20);
            this.tileEduPasport.Elements.Add(tileItemElement21);
            this.tileEduPasport.Group = "4Group";
            this.tileContainerMain.SetID(this.tileEduPasport, 5);
            this.tileEduPasport.Name = "tileEduPasport";
            this.tileEduPasport.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileEduPasport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            // tileMessageList
            // 
            this.tileMessageList.ActivationTarget = this.pageMessageList;
            tileItemElement22.Text = "0";
            tileItemElement22.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement23.Image = global::EduFormManager.Properties.Resources.Message_32;
            tileItemElement23.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement23.Text = "Входящие<br>сообщения";
            tileItemElement23.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileMessageList.Elements.Add(tileItemElement22);
            this.tileMessageList.Elements.Add(tileItemElement23);
            this.tileMessageList.Group = "4Group";
            this.tileContainerMain.SetID(this.tileMessageList, 8);
            this.tileMessageList.Name = "tileMessageList";
            this.tileMessageList.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileMessageList.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMessageList.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement26.Image = global::EduFormManager.Properties.Resources.Feedback_32;
            tileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement26.Text = "Отправить<br>сообщение";
            tileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileMessage.Elements.Add(tileItemElement26);
            this.tileMessage.Group = "4Group";
            this.tileContainerMain.SetID(this.tileMessage, 7);
            this.tileMessage.Name = "tileMessage";
            this.tileMessage.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileMessage.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.tileMessage.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileMessage.Tag = "Message";
            // 
            // tileContainerMessage
            // 
            this.tileContainerMessage.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.tileContainerMessage.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileContainerMessage.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileContainerMessage.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileContainerMessage.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileContainerMessage.AppearanceItem.Normal.Options.UseFont = true;
            this.tileContainerMessage.Caption = "Отправить сообщение";
            this.tileContainerMessage.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileRequestQuery,
            this.tileBugReport});
            this.tileContainerMessage.Name = "tileContainerMessage";
            this.tileContainerMessage.Parent = this.tileContainerMain;
            this.tileContainerMessage.Properties.ItemSize = 95;
            // 
            // tileRequestQuery
            // 
            this.tileRequestQuery.ActivationTarget = this.pageRequestQuery;
            tileItemElement24.Text = "Новый запрос по требованию";
            tileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileRequestQuery.Elements.Add(tileItemElement24);
            this.tileRequestQuery.Name = "tileRequestQuery";
            this.tileRequestQuery.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileRequestQuery.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileRequestQuery.Tag = "MessageRequestQuery";
            // 
            // pageRequestQuery
            // 
            this.pageRequestQuery.Caption = "Сообщение";
            this.pageRequestQuery.Document = this.documentRequestQuery;
            this.pageRequestQuery.Name = "pageRequestQuery";
            this.pageRequestQuery.Parent = this.tileContainerMessage;
            // 
            // documentRequestQuery
            // 
            this.documentRequestQuery.Caption = "Сообщение";
            this.documentRequestQuery.ControlName = "RequestQuery";
            // 
            // tileBugReport
            // 
            this.tileBugReport.ActivationTarget = this.pageBugReport;
            tileItemElement25.Text = "Сообщить об ошибке";
            tileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileBugReport.Elements.Add(tileItemElement25);
            this.tileContainerMessage.SetID(this.tileBugReport, 1);
            this.tileBugReport.Name = "tileBugReport";
            this.tileBugReport.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileBugReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            // tileFormStatistics
            // 
            this.tileFormStatistics.ActivationTarget = this.tabbedGroupStatistics;
            tileItemElement27.Image = global::EduFormManager.Properties.Resources.Statistics_32;
            tileItemElement27.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement27.Text = "Статистика";
            tileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileFormStatistics.Elements.Add(tileItemElement27);
            this.tileFormStatistics.Group = "4Group";
            this.tileContainerMain.SetID(this.tileFormStatistics, 9);
            this.tileFormStatistics.Name = "tileFormStatistics";
            this.tileFormStatistics.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileFormStatistics.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            // tileDictionaries
            // 
            this.tileDictionaries.ActivationTarget = this.tileContainerDictionaries;
            tileItemElement33.Image = global::EduFormManager.Properties.Resources.Library_32;
            tileItemElement33.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement33.Text = "Справочники";
            tileItemElement33.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictionaries.Elements.Add(tileItemElement33);
            this.tileDictionaries.Enabled = true;
            this.tileDictionaries.Group = "4Group";
            this.tileContainerMain.SetID(this.tileDictionaries, 2);
            this.tileDictionaries.Name = "tileDictionaries";
            this.tileDictionaries.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileDictionaries.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDictionaries.Tag = "Dictionaries";
            // 
            // tileContainerDictionaries
            // 
            this.tileContainerDictionaries.AppearanceButton.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.tileContainerDictionaries.AppearanceButton.Normal.Options.UseForeColor = true;
            this.tileContainerDictionaries.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.tileContainerDictionaries.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileContainerDictionaries.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.tileContainerDictionaries.Properties.IndentBetweenItems = 6;
            this.tileContainerDictionaries.Properties.ItemSize = 95;
            // 
            // tileDictMunicipality
            // 
            this.tileDictMunicipality.ActivationTarget = this.pageMunit;
            tileItemElement28.Text = "Муниципалитеты";
            tileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictMunicipality.Elements.Add(tileItemElement28);
            this.tileDictMunicipality.Name = "tileDictMunicipality";
            this.tileDictMunicipality.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement29.Text = "Образовательные организации";
            tileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictEdu.Elements.Add(tileItemElement29);
            this.tileContainerDictionaries.SetID(this.tileDictEdu, 2);
            this.tileDictEdu.Name = "tileDictEdu";
            this.tileDictEdu.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement30.Text = "Шаблоны форм";
            tileItemElement30.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictTemplate.Elements.Add(tileItemElement30);
            this.tileContainerDictionaries.SetID(this.tileDictTemplate, 3);
            this.tileDictTemplate.Name = "tileDictTemplate";
            this.tileDictTemplate.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement31.Text = "Формы";
            tileItemElement31.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictForms.Elements.Add(tileItemElement31);
            this.tileContainerDictionaries.SetID(this.tileDictForms, 5);
            this.tileDictForms.Name = "tileDictForms";
            this.tileDictForms.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement32.Text = "Формулы для заполнения муниципалитетных форм";
            tileItemElement32.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictMunicipalityFormula.Elements.Add(tileItemElement32);
            this.tileContainerDictionaries.SetID(this.tileDictMunicipalityFormula, 1);
            this.tileDictMunicipalityFormula.Name = "tileDictMunicipalityFormula";
            this.tileDictMunicipalityFormula.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            tileItemElement34.Text = "Формулы";
            tileItemElement34.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileDictCheck.Elements.Add(tileItemElement34);
            this.tileDictCheck.Name = "tileDictCheck";
            this.tileDictCheck.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
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
            this.splitContainerControl2.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.flyoutPanelNotifications);
            this.splitContainerControl2.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.xtraNavPane);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1186, 706);
            this.splitContainerControl2.SplitterPosition = 110;
            this.splitContainerControl2.TabIndex = 6;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonShowNotifications);
            this.layoutControl1.Controls.Add(this.buttonShowLogs);
            this.layoutControl1.Controls.Add(this.labelLoggedUser);
            this.layoutControl1.Controls.Add(this.labelHeader);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1195, 159, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1186, 110);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonShowNotifications
            // 
            this.buttonShowNotifications.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.buttonShowNotifications.Image = global::EduFormManager.Properties.Resources.Info_26;
            this.buttonShowNotifications.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.buttonShowNotifications.Location = new System.Drawing.Point(1129, 48);
            this.buttonShowNotifications.Name = "buttonShowNotifications";
            this.buttonShowNotifications.Size = new System.Drawing.Size(45, 32);
            this.buttonShowNotifications.TabIndex = 4;
            this.buttonShowNotifications.Click += new System.EventHandler(this.buttonShowNotifications_Click);
            // 
            // buttonShowLogs
            // 
            this.buttonShowLogs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.buttonShowLogs.Image = global::EduFormManager.Properties.Resources.Folder_26;
            this.buttonShowLogs.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.buttonShowLogs.Location = new System.Drawing.Point(1129, 12);
            this.buttonShowLogs.Name = "buttonShowLogs";
            this.buttonShowLogs.Size = new System.Drawing.Size(45, 32);
            this.buttonShowLogs.TabIndex = 8;
            this.buttonShowLogs.Click += new System.EventHandler(this.buttonShowLogs_Click);
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoggedUser.Appearance.Image = global::EduFormManager.Properties.Resources.User_32;
            this.labelLoggedUser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelLoggedUser.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelLoggedUser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelLoggedUser.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.labelLoggedUser.Location = new System.Drawing.Point(668, 12);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(457, 36);
            this.labelLoggedUser.StyleController = this.layoutControl1;
            this.labelLoggedUser.TabIndex = 6;
            this.labelLoggedUser.Text = "user";
            // 
            // labelHeader
            // 
            this.labelHeader.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.labelHeader.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Appearance.Image = global::EduFormManager.Properties.Resources.Logo_small;
            this.labelHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelHeader.Location = new System.Drawing.Point(12, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(652, 84);
            this.labelHeader.StyleController = this.layoutControl1;
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Министерство образования и науки Астраханской области\r\nГосударственное бюджетное " +
    "учреждение Астраханской области\r\nЦентр мониторинга в образовании";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1186, 110);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelHeader;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(656, 90);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelLoggedUser;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem1.Location = new System.Drawing.Point(656, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(461, 90);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonShowLogs;
            this.layoutControlItem3.Location = new System.Drawing.Point(1117, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(49, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonShowNotifications;
            this.layoutControlItem4.Location = new System.Drawing.Point(1117, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(49, 54);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // flyoutPanelNotifications
            // 
            this.flyoutPanelNotifications.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.flyoutPanelNotifications.Appearance.ForeColor = System.Drawing.Color.White;
            this.flyoutPanelNotifications.Appearance.Options.UseBackColor = true;
            this.flyoutPanelNotifications.Appearance.Options.UseForeColor = true;
            this.flyoutPanelNotifications.Controls.Add(this.flyoutPanelNotificationsControl);
            this.flyoutPanelNotifications.Location = new System.Drawing.Point(758, 32);
            this.flyoutPanelNotifications.Name = "flyoutPanelNotifications";
            this.flyoutPanelNotifications.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelNotifications.Options.CloseOnOuterClick = true;
            this.flyoutPanelNotifications.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(116)))), ((int)(((byte)(169)))));
            this.flyoutPanelNotifications.OptionsButtonPanel.AllowGlyphSkinning = true;
            this.flyoutPanelNotifications.OptionsButtonPanel.AppearanceButton.Normal.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanelNotifications.OptionsButtonPanel.AppearanceButton.Normal.Options.UseBackColor = true;
            this.flyoutPanelNotifications.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.flyoutPanelNotifications.OptionsButtonPanel.ButtonPanelHeight = 35;
            this.flyoutPanelNotifications.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top;
            this.flyoutPanelNotifications.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Close", global::EduFormManager.Properties.Resources.Cancel_26, false, true, "Закрыть панель")});
            this.flyoutPanelNotifications.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanelNotifications.OwnerControl = this.splitContainerControl2;
            this.flyoutPanelNotifications.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.flyoutPanelNotifications.ParentForm = this;
            this.flyoutPanelNotifications.Size = new System.Drawing.Size(361, 124);
            this.flyoutPanelNotifications.TabIndex = 7;
            this.flyoutPanelNotifications.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flyoutPanel1_ButtonClick);
            // 
            // flyoutPanelNotificationsControl
            // 
            this.flyoutPanelNotificationsControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelNotificationsControl.Controls.Add(this.collapsableSideListBoxControl1);
            this.flyoutPanelNotificationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelNotificationsControl.FlyoutPanel = this.flyoutPanelNotifications;
            this.flyoutPanelNotificationsControl.Location = new System.Drawing.Point(0, 35);
            this.flyoutPanelNotificationsControl.Name = "flyoutPanelNotificationsControl";
            this.flyoutPanelNotificationsControl.Size = new System.Drawing.Size(361, 89);
            this.flyoutPanelNotificationsControl.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(1186, 549);
            this.panel1.TabIndex = 8;
            // 
            // xtraNavPane
            // 
            this.xtraNavPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraNavPane.Home = null;
            this.xtraNavPane.Location = new System.Drawing.Point(0, 0);
            this.xtraNavPane.MaximumSize = new System.Drawing.Size(0, 26);
            this.xtraNavPane.Name = "xtraNavPane";
            this.xtraNavPane.Size = new System.Drawing.Size(1186, 26);
            this.xtraNavPane.TabIndex = 9;
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
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(1186, 705);
            this.Controls.Add(this.splitContainerControl2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityAdditonalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileMunicipalityAdditonalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAdditionalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveAdditionalForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveMunicipalityForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileArchiveForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSpreadsheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupUploadForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentUploadSheetFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentQueriesMunicipality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCreateQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEduPasport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageEduPassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentEduPasport)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tileFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedGroupStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormStatisticsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentFormDetailedStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSignInOutLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMunicipalityFormDetailedStatistics)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotifications)).EndInit();
            this.flyoutPanelNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotificationsControl)).EndInit();
            this.flyoutPanelNotificationsControl.ResumeLayout(false);
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
        private Document documentEduPasport;


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
        private FlyoutPanel flyoutPanelNotifications;
        private FlyoutPanelControl flyoutPanelNotificationsControl;
        private BindingSource expireWarnBindingSource;
        private CollapsableSideListBoxControl collapsableSideListBoxControl1;
        private Panel panel1;
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private LabelControl labelHeader;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private LabelControl labelLoggedUser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private SimpleButton buttonShowLogs;
        private SimpleButton buttonShowNotifications;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraNavPane xtraNavPane;
    }
}

