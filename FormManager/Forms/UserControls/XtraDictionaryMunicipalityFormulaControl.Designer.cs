using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraLayout;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.UI;
using EduFormManager.Forms.UserControls.FormulaEdit;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraDictionaryMunicipalityFormulaControl
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
            this.spreadsheetControlEdu = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.spreadsheetCommandBarCheckItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetControlMunit = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.formulaEditControl1 = new EduFormManager.Forms.UserControls.FormulaEdit.FormulaEditControl();
            this.comboBoxFormEdu = new System.Windows.Forms.ComboBox();
            this.allformBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFormMunit = new System.Windows.Forms.ComboBox();
            this.allformBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.spreadsheetDockManager1 = new DevExpress.XtraSpreadsheet.SpreadsheetDockManager(this.components);
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.spreadsheetBarController2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.spreadsheetCommandBarCheckItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.formBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label4 = new System.Windows.Forms.Label();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allformBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allformBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControlEdu
            // 
            this.spreadsheetControlEdu.Location = new System.Drawing.Point(630, 61);
            this.spreadsheetControlEdu.MenuManager = this.barManager1;
            this.spreadsheetControlEdu.Name = "spreadsheetControlEdu";
            this.spreadsheetControlEdu.Size = new System.Drawing.Size(558, 244);
            this.spreadsheetControlEdu.TabIndex = 0;
            this.spreadsheetControlEdu.Text = "spreadsheetControl1";
            this.spreadsheetControlEdu.PopupMenuShowing += new DevExpress.XtraSpreadsheet.PopupMenuShowingEventHandler(this.spreadsheetControlEdu_PopupMenuShowing);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.spreadsheetCommandBarCheckItem1,
            this.spreadsheetCommandBarCheckItem2,
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarSubItem1,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7});
            this.barManager1.MaxItemId = 10;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // spreadsheetCommandBarCheckItem1
            // 
            this.spreadsheetCommandBarCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem1.CommandName = "ViewShowGridlines";
            this.spreadsheetCommandBarCheckItem1.Id = 3;
            this.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1";
            // 
            // spreadsheetCommandBarCheckItem2
            // 
            this.spreadsheetCommandBarCheckItem2.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem2.CommandName = "ViewShowHeadings";
            this.spreadsheetCommandBarCheckItem2.Id = 4;
            this.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2";
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "ViewZoomOut";
            this.spreadsheetCommandBarButtonItem1.Id = 0;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "ViewZoomIn";
            this.spreadsheetCommandBarButtonItem2.Id = 1;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "ViewZoom100Percent";
            this.spreadsheetCommandBarButtonItem3.Id = 2;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarSubItem1
            // 
            this.spreadsheetCommandBarSubItem1.CommandName = "ViewFreezePanesCommandGroup";
            this.spreadsheetCommandBarSubItem1.Id = 5;
            this.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem7)});
            this.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "ViewFreezePanes";
            this.spreadsheetCommandBarButtonItem4.Id = 6;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "ViewUnfreezePanes";
            this.spreadsheetCommandBarButtonItem5.Id = 7;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "ViewFreezeTopRow";
            this.spreadsheetCommandBarButtonItem6.Id = 8;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "ViewFreezeFirstColumn";
            this.spreadsheetCommandBarButtonItem7.Id = 9;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetControlMunit
            // 
            this.spreadsheetControlMunit.Location = new System.Drawing.Point(12, 61);
            this.spreadsheetControlMunit.MenuManager = this.barManager1;
            this.spreadsheetControlMunit.Name = "spreadsheetControlMunit";
            this.spreadsheetControlMunit.Size = new System.Drawing.Size(602, 244);
            this.spreadsheetControlMunit.TabIndex = 0;
            this.spreadsheetControlMunit.Text = "spreadsheetControl2";
            this.spreadsheetControlMunit.PopupMenuShowing += new DevExpress.XtraSpreadsheet.PopupMenuShowingEventHandler(this.spreadsheetControlMunit_PopupMenuShowing);
            // 
            // formulaEditControl1
            // 
            this.formulaEditControl1.Location = new System.Drawing.Point(12, 321);
            this.formulaEditControl1.Name = "formulaEditControl1";
            this.formulaEditControl1.Size = new System.Drawing.Size(1176, 256);
            this.formulaEditControl1.TabIndex = 1;
            // 
            // comboBoxFormEdu
            // 
            this.comboBoxFormEdu.DataSource = this.allformBindingSource1;
            this.comboBoxFormEdu.DisplayMember = "name";
            this.comboBoxFormEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormEdu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFormEdu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormEdu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxFormEdu.FormattingEnabled = true;
            this.comboBoxFormEdu.Location = new System.Drawing.Point(970, 36);
            this.comboBoxFormEdu.Name = "comboBoxFormEdu";
            this.comboBoxFormEdu.Size = new System.Drawing.Size(218, 23);
            this.comboBoxFormEdu.TabIndex = 2;
            // 
            // allformBindingSource1
            // 
            this.allformBindingSource1.DataSource = typeof(EduFormManager.Models.form);
            // 
            // comboBoxFormMunit
            // 
            this.comboBoxFormMunit.DataSource = this.allformBindingSource2;
            this.comboBoxFormMunit.DisplayMember = "name";
            this.comboBoxFormMunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormMunit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFormMunit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormMunit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxFormMunit.FormattingEnabled = true;
            this.comboBoxFormMunit.Location = new System.Drawing.Point(317, 36);
            this.comboBoxFormMunit.Name = "comboBoxFormMunit";
            this.comboBoxFormMunit.Size = new System.Drawing.Size(297, 23);
            this.comboBoxFormMunit.TabIndex = 3;
            // 
            // allformBindingSource2
            // 
            this.allformBindingSource2.DataSource = typeof(EduFormManager.Models.form);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label4);
            this.layoutControl1.Controls.Add(this.label3);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.spreadsheetControlEdu);
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Controls.Add(this.formulaEditControl1);
            this.layoutControl1.Controls.Add(this.comboBoxFormMunit);
            this.layoutControl1.Controls.Add(this.spreadsheetControlMunit);
            this.layoutControl1.Controls.Add(this.comboBoxFormEdu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(856, 345, 458, 478);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 589);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allformBindingSource1, "name", true));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(630, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allformBindingSource2, "name", true));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.splitterItem1,
            this.splitterItem2,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 589);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spreadsheetControlMunit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(606, 248);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.formulaEditControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 309);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1180, 260);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(130, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(45, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(774, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(54, 25);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxFormEdu;
            this.layoutControlItem3.Location = new System.Drawing.Point(828, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(352, 25);
            this.layoutControlItem3.Text = "Выбрать форму";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxFormMunit;
            this.layoutControlItem4.Location = new System.Drawing.Point(175, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(431, 25);
            this.layoutControlItem4.Text = "Выбрать сводную форму";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(127, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(618, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(156, 25);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.label2;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(130, 25);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.spreadsheetControlEdu;
            this.layoutControlItem7.Location = new System.Drawing.Point(618, 49);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(562, 248);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(606, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 297);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 297);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(1180, 12);
            // 
            // spreadsheetDockManager1
            // 
            this.spreadsheetDockManager1.Form = this;
            this.spreadsheetDockManager1.SpreadsheetControl = this.spreadsheetControlEdu;
            this.spreadsheetDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.Control = this.spreadsheetControlEdu;
            // 
            // spreadsheetBarController2
            // 
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarCheckItem3);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarCheckItem4);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarSubItem2);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem12);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem13);
            this.spreadsheetBarController2.BarItems.Add(this.spreadsheetCommandBarButtonItem14);
            this.spreadsheetBarController2.Control = this.spreadsheetControlMunit;
            // 
            // spreadsheetCommandBarCheckItem3
            // 
            this.spreadsheetCommandBarCheckItem3.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem3.CommandName = "ViewShowGridlines";
            this.spreadsheetCommandBarCheckItem3.Id = -1;
            this.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3";
            // 
            // spreadsheetCommandBarCheckItem4
            // 
            this.spreadsheetCommandBarCheckItem4.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem4.CommandName = "ViewShowHeadings";
            this.spreadsheetCommandBarCheckItem4.Id = -1;
            this.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "ViewZoomOut";
            this.spreadsheetCommandBarButtonItem8.Id = -1;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "ViewZoomIn";
            this.spreadsheetCommandBarButtonItem9.Id = -1;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "ViewZoom100Percent";
            this.spreadsheetCommandBarButtonItem10.Id = -1;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarSubItem2
            // 
            this.spreadsheetCommandBarSubItem2.CommandName = "ViewFreezePanesCommandGroup";
            this.spreadsheetCommandBarSubItem2.Id = -1;
            this.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem7)});
            this.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "ViewFreezePanes";
            this.spreadsheetCommandBarButtonItem11.Id = -1;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // spreadsheetCommandBarButtonItem12
            // 
            this.spreadsheetCommandBarButtonItem12.CommandName = "ViewUnfreezePanes";
            this.spreadsheetCommandBarButtonItem12.Id = -1;
            this.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12";
            // 
            // spreadsheetCommandBarButtonItem13
            // 
            this.spreadsheetCommandBarButtonItem13.CommandName = "ViewFreezeTopRow";
            this.spreadsheetCommandBarButtonItem13.Id = -1;
            this.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13";
            // 
            // spreadsheetCommandBarButtonItem14
            // 
            this.spreadsheetCommandBarButtonItem14.CommandName = "ViewFreezeFirstColumn";
            this.spreadsheetCommandBarButtonItem14.Id = -1;
            this.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14";
            // 
            // formBindingSource1
            // 
            this.formBindingSource1.DataSource = typeof(EduFormManager.Models.form);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сводная форма муниципалитета";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.label3;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(606, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(558, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Форма организации";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.label4;
            this.layoutControlItem9.Location = new System.Drawing.Point(618, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(562, 24);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // XtraDictionaryMunicipalityFormulaControl
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDictionaryMunicipalityFormulaControl";
            this.Size = new System.Drawing.Size(1200, 589);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allformBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allformBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetControlEdu;
        private SpreadsheetControl spreadsheetControlMunit;
        private FormulaEditControl formulaEditControl1;
        private ComboBox comboBoxFormEdu;
        private ComboBox comboBoxFormMunit;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem5;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem2;
        private BindingSource allformBindingSource1;
        private BindingSource allformBindingSource2;
        private Label label2;
        private Label label1;
        private SpreadsheetDockManager spreadsheetDockManager1;
        private BarManager barManager1;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem1;
        private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem2;
        private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem1;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private SpreadsheetBarController spreadsheetBarController1;
        private SpreadsheetBarController spreadsheetBarController2;
        private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem3;
        private SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem4;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem2;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem12;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem13;
        private SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem14;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem7;
        private SplitterItem splitterItem1;
        private SplitterItem splitterItem2;
        private BindingSource formBindingSource1;
        private Label label4;
        private Label label3;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem9;
    }
}
