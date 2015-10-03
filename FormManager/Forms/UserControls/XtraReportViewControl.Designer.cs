using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting.Preview;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraReportViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportViewControl));
            this.documentViewerReport = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(this.components);
            this.previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.printPreviewBarItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.zoomBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
            this.printPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
            this.printPreviewBarItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.previewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.progressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.printPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.zoomTrackBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printPreviewSubItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            this.printPreviewBarItem27 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem28 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.printPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            this.printPreviewBarCheckItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewerReport
            // 
            this.documentViewerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewerReport.IsMetric = false;
            this.documentViewerReport.Location = new System.Drawing.Point(0, 28);
            this.documentViewerReport.Name = "documentViewerReport";
            this.documentViewerReport.Size = new System.Drawing.Size(1023, 560);
            this.documentViewerReport.TabIndex = 0;
            // 
            // documentViewerBarManager1
            // 
            this.documentViewerBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.previewBar1,
            this.previewBar2});
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlTop);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlBottom);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlLeft);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlRight);
            this.documentViewerBarManager1.DocumentViewer = this.documentViewerReport;
            this.documentViewerBarManager1.Form = this;
            this.documentViewerBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("documentViewerBarManager1.ImageStream")));
            this.documentViewerBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.printPreviewStaticItem1,
            this.barStaticItem1,
            this.progressBarEditItem1,
            this.printPreviewBarItem1,
            this.barButtonItem1,
            this.printPreviewStaticItem2,
            this.zoomTrackBarEditItem1,
            this.printPreviewBarItem8,
            this.printPreviewBarItem9,
            this.printPreviewBarItem10,
            this.printPreviewBarItem12,
            this.zoomBarEditItem1,
            this.printPreviewBarItem17,
            this.printPreviewBarItem18,
            this.printPreviewBarItem19,
            this.printPreviewBarItem20,
            this.printPreviewSubItem4,
            this.printPreviewBarItem27,
            this.printPreviewBarItem28,
            this.barToolbarsListItem1,
            this.printPreviewBarCheckItem1,
            this.printPreviewBarCheckItem2,
            this.printPreviewBarCheckItem3,
            this.printPreviewBarCheckItem4,
            this.printPreviewBarCheckItem5,
            this.printPreviewBarCheckItem6,
            this.printPreviewBarCheckItem7,
            this.printPreviewBarCheckItem8,
            this.printPreviewBarCheckItem9,
            this.printPreviewBarCheckItem10,
            this.printPreviewBarCheckItem11,
            this.printPreviewBarCheckItem12,
            this.printPreviewBarCheckItem13,
            this.printPreviewBarCheckItem14,
            this.printPreviewBarCheckItem15,
            this.printPreviewBarCheckItem16,
            this.printPreviewBarCheckItem17,
            this.barButtonItemExport});
            this.documentViewerBarManager1.MaxItemId = 58;
            this.documentViewerBarManager1.PreviewBar = this.previewBar1;
            this.documentViewerBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1,
            this.printPreviewRepositoryItemComboBox1});
            this.documentViewerBarManager1.StatusBar = this.previewBar2;
            this.documentViewerBarManager1.TransparentEditors = true;
            // 
            // previewBar1
            // 
            this.previewBar1.BarName = "Toolbar";
            this.previewBar1.DockCol = 0;
            this.previewBar1.DockRow = 0;
            this.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem8, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem17, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExport)});
            this.previewBar1.OptionsBar.AllowQuickCustomization = false;
            this.previewBar1.Text = "Toolbar";
            // 
            // printPreviewBarItem8
            // 
            this.printPreviewBarItem8.Caption = "&Print...";
            this.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            this.printPreviewBarItem8.Enabled = false;
            this.printPreviewBarItem8.Hint = "Print";
            this.printPreviewBarItem8.Id = 13;
            this.printPreviewBarItem8.ImageIndex = 0;
            this.printPreviewBarItem8.Name = "printPreviewBarItem8";
            // 
            // printPreviewBarItem9
            // 
            this.printPreviewBarItem9.Caption = "P&rint";
            this.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            this.printPreviewBarItem9.Enabled = false;
            this.printPreviewBarItem9.Hint = "Quick Print";
            this.printPreviewBarItem9.Id = 14;
            this.printPreviewBarItem9.ImageIndex = 1;
            this.printPreviewBarItem9.Name = "printPreviewBarItem9";
            // 
            // printPreviewBarItem10
            // 
            this.printPreviewBarItem10.Caption = "Page Set&up...";
            this.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            this.printPreviewBarItem10.Enabled = false;
            this.printPreviewBarItem10.Hint = "Page Setup";
            this.printPreviewBarItem10.Id = 15;
            this.printPreviewBarItem10.ImageIndex = 2;
            this.printPreviewBarItem10.Name = "printPreviewBarItem10";
            // 
            // printPreviewBarItem12
            // 
            this.printPreviewBarItem12.ActAsDropDown = true;
            this.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem12.Caption = "Scale";
            this.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            this.printPreviewBarItem12.Enabled = false;
            this.printPreviewBarItem12.Hint = "Scale";
            this.printPreviewBarItem12.Id = 17;
            this.printPreviewBarItem12.ImageIndex = 25;
            this.printPreviewBarItem12.Name = "printPreviewBarItem12";
            // 
            // zoomBarEditItem1
            // 
            this.zoomBarEditItem1.Caption = "Zoom";
            this.zoomBarEditItem1.Edit = this.printPreviewRepositoryItemComboBox1;
            this.zoomBarEditItem1.EditValue = "100%";
            this.zoomBarEditItem1.Enabled = false;
            this.zoomBarEditItem1.Hint = "Zoom";
            this.zoomBarEditItem1.Id = 21;
            this.zoomBarEditItem1.Name = "zoomBarEditItem1";
            this.zoomBarEditItem1.Width = 70;
            // 
            // printPreviewRepositoryItemComboBox1
            // 
            this.printPreviewRepositoryItemComboBox1.AutoComplete = false;
            this.printPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.printPreviewRepositoryItemComboBox1.DropDownRows = 11;
            this.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1";
            // 
            // printPreviewBarItem17
            // 
            this.printPreviewBarItem17.Caption = "First Page";
            this.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            this.printPreviewBarItem17.Enabled = false;
            this.printPreviewBarItem17.Hint = "First Page";
            this.printPreviewBarItem17.Id = 23;
            this.printPreviewBarItem17.ImageIndex = 7;
            this.printPreviewBarItem17.Name = "printPreviewBarItem17";
            // 
            // printPreviewBarItem18
            // 
            this.printPreviewBarItem18.Caption = "Previous Page";
            this.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            this.printPreviewBarItem18.Enabled = false;
            this.printPreviewBarItem18.Hint = "Previous Page";
            this.printPreviewBarItem18.Id = 24;
            this.printPreviewBarItem18.ImageIndex = 8;
            this.printPreviewBarItem18.Name = "printPreviewBarItem18";
            // 
            // printPreviewBarItem19
            // 
            this.printPreviewBarItem19.Caption = "Next Page";
            this.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            this.printPreviewBarItem19.Enabled = false;
            this.printPreviewBarItem19.Hint = "Next Page";
            this.printPreviewBarItem19.Id = 25;
            this.printPreviewBarItem19.ImageIndex = 9;
            this.printPreviewBarItem19.Name = "printPreviewBarItem19";
            // 
            // printPreviewBarItem20
            // 
            this.printPreviewBarItem20.Caption = "Last Page";
            this.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            this.printPreviewBarItem20.Enabled = false;
            this.printPreviewBarItem20.Hint = "Last Page";
            this.printPreviewBarItem20.Id = 26;
            this.printPreviewBarItem20.ImageIndex = 10;
            this.printPreviewBarItem20.Name = "printPreviewBarItem20";
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "Экспорт";
            this.barButtonItemExport.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemExport.Glyph")));
            this.barButtonItemExport.Id = 57;
            this.barButtonItemExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemExport.LargeGlyph")));
            this.barButtonItemExport.Name = "barButtonItemExport";
            // 
            // previewBar2
            // 
            this.previewBar2.BarName = "Status Bar";
            this.previewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.previewBar2.DockCol = 0;
            this.previewBar2.DockRow = 0;
            this.previewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.previewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.progressBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomTrackBarEditItem1)});
            this.previewBar2.OptionsBar.AllowQuickCustomization = false;
            this.previewBar2.OptionsBar.DrawDragBorder = false;
            this.previewBar2.OptionsBar.UseWholeRow = true;
            this.previewBar2.Text = "Status Bar";
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 0;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // progressBarEditItem1
            // 
            this.progressBarEditItem1.Edit = this.repositoryItemProgressBar1;
            this.progressBarEditItem1.EditHeight = 12;
            this.progressBarEditItem1.Id = 2;
            this.progressBarEditItem1.Name = "progressBarEditItem1";
            this.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.progressBarEditItem1.Width = 150;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // printPreviewBarItem1
            // 
            this.printPreviewBarItem1.Caption = "Stop";
            this.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            this.printPreviewBarItem1.Enabled = false;
            this.printPreviewBarItem1.Hint = "Stop";
            this.printPreviewBarItem1.Id = 3;
            this.printPreviewBarItem1.Name = "printPreviewBarItem1";
            this.printPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 5;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far;
            this.printPreviewStaticItem2.Type = "ZoomFactor";
            this.printPreviewStaticItem2.Width = 40;
            // 
            // zoomTrackBarEditItem1
            // 
            this.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomTrackBarEditItem1.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomTrackBarEditItem1.EditValue = 90;
            this.zoomTrackBarEditItem1.Enabled = false;
            this.zoomTrackBarEditItem1.Id = 6;
            this.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1";
            this.zoomTrackBarEditItem1.Range = new int[] {
        10,
        500};
            this.zoomTrackBarEditItem1.Width = 140;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Middle = 5;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1023, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Size = new System.Drawing.Size(1023, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1023, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // printPreviewSubItem4
            // 
            this.printPreviewSubItem4.Caption = "&Page Layout";
            this.printPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
            this.printPreviewSubItem4.Id = 36;
            this.printPreviewSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem28)});
            this.printPreviewSubItem4.Name = "printPreviewSubItem4";
            // 
            // printPreviewBarItem27
            // 
            this.printPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem27.Caption = "&Facing";
            this.printPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
            this.printPreviewBarItem27.Enabled = false;
            this.printPreviewBarItem27.GroupIndex = 100;
            this.printPreviewBarItem27.Id = 37;
            this.printPreviewBarItem27.Name = "printPreviewBarItem27";
            // 
            // printPreviewBarItem28
            // 
            this.printPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem28.Caption = "&Continuous";
            this.printPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
            this.printPreviewBarItem28.Down = true;
            this.printPreviewBarItem28.Enabled = false;
            this.printPreviewBarItem28.GroupIndex = 100;
            this.printPreviewBarItem28.Id = 38;
            this.printPreviewBarItem28.Name = "printPreviewBarItem28";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "Bars";
            this.barToolbarsListItem1.Id = 39;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // printPreviewBarCheckItem1
            // 
            //this.printPreviewBarCheckItem1.BindableChecked = true;
            this.printPreviewBarCheckItem1.Caption = "PDF File";
            this.printPreviewBarCheckItem1.Checked = true;
            this.printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
            this.printPreviewBarCheckItem1.Enabled = false;
            this.printPreviewBarCheckItem1.GroupIndex = 2;
            this.printPreviewBarCheckItem1.Hint = "PDF File";
            this.printPreviewBarCheckItem1.Id = 40;
            this.printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1";
            // 
            // printPreviewBarCheckItem2
            // 
            this.printPreviewBarCheckItem2.Caption = "HTML File";
            this.printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
            this.printPreviewBarCheckItem2.Enabled = false;
            this.printPreviewBarCheckItem2.GroupIndex = 2;
            this.printPreviewBarCheckItem2.Hint = "HTML File";
            this.printPreviewBarCheckItem2.Id = 41;
            this.printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2";
            // 
            // printPreviewBarCheckItem3
            // 
            this.printPreviewBarCheckItem3.Caption = "MHT File";
            this.printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
            this.printPreviewBarCheckItem3.Enabled = false;
            this.printPreviewBarCheckItem3.GroupIndex = 2;
            this.printPreviewBarCheckItem3.Hint = "MHT File";
            this.printPreviewBarCheckItem3.Id = 42;
            this.printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3";
            // 
            // printPreviewBarCheckItem4
            // 
            this.printPreviewBarCheckItem4.Caption = "RTF File";
            this.printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
            this.printPreviewBarCheckItem4.Enabled = false;
            this.printPreviewBarCheckItem4.GroupIndex = 2;
            this.printPreviewBarCheckItem4.Hint = "RTF File";
            this.printPreviewBarCheckItem4.Id = 43;
            this.printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4";
            // 
            // printPreviewBarCheckItem5
            // 
            this.printPreviewBarCheckItem5.Caption = "XLS File";
            this.printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
            this.printPreviewBarCheckItem5.Enabled = false;
            this.printPreviewBarCheckItem5.GroupIndex = 2;
            this.printPreviewBarCheckItem5.Hint = "XLS File";
            this.printPreviewBarCheckItem5.Id = 44;
            this.printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5";
            // 
            // printPreviewBarCheckItem6
            // 
            this.printPreviewBarCheckItem6.Caption = "XLSX File";
            this.printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
            this.printPreviewBarCheckItem6.Enabled = false;
            this.printPreviewBarCheckItem6.GroupIndex = 2;
            this.printPreviewBarCheckItem6.Hint = "XLSX File";
            this.printPreviewBarCheckItem6.Id = 45;
            this.printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6";
            // 
            // printPreviewBarCheckItem7
            // 
            this.printPreviewBarCheckItem7.Caption = "CSV File";
            this.printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
            this.printPreviewBarCheckItem7.Enabled = false;
            this.printPreviewBarCheckItem7.GroupIndex = 2;
            this.printPreviewBarCheckItem7.Hint = "CSV File";
            this.printPreviewBarCheckItem7.Id = 46;
            this.printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7";
            // 
            // printPreviewBarCheckItem8
            // 
            this.printPreviewBarCheckItem8.Caption = "Text File";
            this.printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
            this.printPreviewBarCheckItem8.Enabled = false;
            this.printPreviewBarCheckItem8.GroupIndex = 2;
            this.printPreviewBarCheckItem8.Hint = "Text File";
            this.printPreviewBarCheckItem8.Id = 47;
            this.printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8";
            // 
            // printPreviewBarCheckItem9
            // 
            this.printPreviewBarCheckItem9.Caption = "Image File";
            this.printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
            this.printPreviewBarCheckItem9.Enabled = false;
            this.printPreviewBarCheckItem9.GroupIndex = 2;
            this.printPreviewBarCheckItem9.Hint = "Image File";
            this.printPreviewBarCheckItem9.Id = 48;
            this.printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9";
            // 
            // printPreviewBarCheckItem10
            // 
            //this.printPreviewBarCheckItem10.BindableChecked = true;
            this.printPreviewBarCheckItem10.Caption = "PDF File";
            this.printPreviewBarCheckItem10.Checked = true;
            this.printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
            this.printPreviewBarCheckItem10.Enabled = false;
            this.printPreviewBarCheckItem10.GroupIndex = 1;
            this.printPreviewBarCheckItem10.Hint = "PDF File";
            this.printPreviewBarCheckItem10.Id = 49;
            this.printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10";
            // 
            // printPreviewBarCheckItem11
            // 
            this.printPreviewBarCheckItem11.Caption = "MHT File";
            this.printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
            this.printPreviewBarCheckItem11.Enabled = false;
            this.printPreviewBarCheckItem11.GroupIndex = 1;
            this.printPreviewBarCheckItem11.Hint = "MHT File";
            this.printPreviewBarCheckItem11.Id = 50;
            this.printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11";
            // 
            // printPreviewBarCheckItem12
            // 
            this.printPreviewBarCheckItem12.Caption = "RTF File";
            this.printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
            this.printPreviewBarCheckItem12.Enabled = false;
            this.printPreviewBarCheckItem12.GroupIndex = 1;
            this.printPreviewBarCheckItem12.Hint = "RTF File";
            this.printPreviewBarCheckItem12.Id = 51;
            this.printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12";
            // 
            // printPreviewBarCheckItem13
            // 
            this.printPreviewBarCheckItem13.Caption = "XLS File";
            this.printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
            this.printPreviewBarCheckItem13.Enabled = false;
            this.printPreviewBarCheckItem13.GroupIndex = 1;
            this.printPreviewBarCheckItem13.Hint = "XLS File";
            this.printPreviewBarCheckItem13.Id = 52;
            this.printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13";
            // 
            // printPreviewBarCheckItem14
            // 
            this.printPreviewBarCheckItem14.Caption = "XLSX File";
            this.printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
            this.printPreviewBarCheckItem14.Enabled = false;
            this.printPreviewBarCheckItem14.GroupIndex = 1;
            this.printPreviewBarCheckItem14.Hint = "XLSX File";
            this.printPreviewBarCheckItem14.Id = 53;
            this.printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14";
            // 
            // printPreviewBarCheckItem15
            // 
            this.printPreviewBarCheckItem15.Caption = "CSV File";
            this.printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
            this.printPreviewBarCheckItem15.Enabled = false;
            this.printPreviewBarCheckItem15.GroupIndex = 1;
            this.printPreviewBarCheckItem15.Hint = "CSV File";
            this.printPreviewBarCheckItem15.Id = 54;
            this.printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15";
            // 
            // printPreviewBarCheckItem16
            // 
            this.printPreviewBarCheckItem16.Caption = "Text File";
            this.printPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
            this.printPreviewBarCheckItem16.Enabled = false;
            this.printPreviewBarCheckItem16.GroupIndex = 1;
            this.printPreviewBarCheckItem16.Hint = "Text File";
            this.printPreviewBarCheckItem16.Id = 55;
            this.printPreviewBarCheckItem16.Name = "printPreviewBarCheckItem16";
            // 
            // printPreviewBarCheckItem17
            // 
            this.printPreviewBarCheckItem17.Caption = "Image File";
            this.printPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
            this.printPreviewBarCheckItem17.Enabled = false;
            this.printPreviewBarCheckItem17.GroupIndex = 1;
            this.printPreviewBarCheckItem17.Hint = "Image File";
            this.printPreviewBarCheckItem17.Id = 56;
            this.printPreviewBarCheckItem17.Name = "printPreviewBarCheckItem17";
            // 
            // XtraReportViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentViewerReport);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraReportViewControl";
            this.Size = new System.Drawing.Size(1023, 612);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DocumentViewer documentViewerReport;
        private DocumentViewerBarManager documentViewerBarManager1;
        private PreviewBar previewBar1;
        private PrintPreviewBarItem printPreviewBarItem8;
        private PrintPreviewBarItem printPreviewBarItem9;
        private PrintPreviewBarItem printPreviewBarItem10;
        private PrintPreviewBarItem printPreviewBarItem12;
        private ZoomBarEditItem zoomBarEditItem1;
        private PrintPreviewRepositoryItemComboBox printPreviewRepositoryItemComboBox1;
        private PrintPreviewBarItem printPreviewBarItem17;
        private PrintPreviewBarItem printPreviewBarItem18;
        private PrintPreviewBarItem printPreviewBarItem19;
        private PrintPreviewBarItem printPreviewBarItem20;
        private PreviewBar previewBar2;
        private PrintPreviewStaticItem printPreviewStaticItem1;
        private BarStaticItem barStaticItem1;
        private ProgressBarEditItem progressBarEditItem1;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private PrintPreviewBarItem printPreviewBarItem1;
        private BarButtonItem barButtonItem1;
        private PrintPreviewStaticItem printPreviewStaticItem2;
        private ZoomTrackBarEditItem zoomTrackBarEditItem1;
        private RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private PrintPreviewSubItem printPreviewSubItem4;
        private PrintPreviewBarItem printPreviewBarItem27;
        private PrintPreviewBarItem printPreviewBarItem28;
        private BarToolbarsListItem barToolbarsListItem1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem1;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem2;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem3;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem4;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem5;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem6;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem7;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem8;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem9;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem10;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem11;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem12;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem13;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem14;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem15;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem16;
        private PrintPreviewBarCheckItem printPreviewBarCheckItem17;
        private BarButtonItem barButtonItemExport;
    }
}
