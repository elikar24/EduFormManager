using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using ComboBox = System.Windows.Forms.ComboBox;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    partial class XtraQueryEduControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewSummaryEdu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShortName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlQuerySummary = new DevExpress.XtraGrid.GridControl();
            this.querySummaryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewSummaryQuery = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colForm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlEdu = new DevExpress.XtraGrid.GridControl();
            this.gridViewEdu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMunicipality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.queryControl = new EduFormManager.Forms.UserControls.QueryControl.QueryCheckListControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonMenuFlyout = new DevExpress.XtraEditors.SimpleButton();
            this.popupQuerySummaryModel = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerQueryModel = new DevExpress.XtraEditors.PopupContainerControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonClosePopup = new DevExpress.XtraEditors.SimpleButton();
            this.checkBoxOnlyPassport = new System.Windows.Forms.CheckBox();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.flyoutPanelMenu = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControlMenu = new DevExpress.Utils.FlyoutPanelControl();
            this.windowsUIButtonPanelActions = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummaryEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuerySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querySummaryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummaryQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupQuerySummaryModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerQueryModel)).BeginInit();
            this.popupContainerQueryModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelMenu)).BeginInit();
            this.flyoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControlMenu)).BeginInit();
            this.flyoutPanelControlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewSummaryEdu
            // 
            this.gridViewSummaryEdu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShortName1});
            this.gridViewSummaryEdu.GridControl = this.gridControlQuerySummary;
            this.gridViewSummaryEdu.Name = "gridViewSummaryEdu";
            this.gridViewSummaryEdu.OptionsBehavior.Editable = false;
            this.gridViewSummaryEdu.OptionsView.ShowColumnHeaders = false;
            this.gridViewSummaryEdu.OptionsView.ShowGroupPanel = false;
            this.gridViewSummaryEdu.Tag = "SummaryEduView";
            this.gridViewSummaryEdu.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.view_PopupMenuShowing);
            // 
            // colShortName1
            // 
            this.colShortName1.Caption = "Организация";
            this.colShortName1.FieldName = "name";
            this.colShortName1.Name = "colShortName1";
            this.colShortName1.Visible = true;
            this.colShortName1.VisibleIndex = 0;
            // 
            // gridControlQuerySummary
            // 
            this.gridControlQuerySummary.DataSource = this.querySummaryModelBindingSource;
            gridLevelNode1.LevelTemplate = this.gridViewSummaryEdu;
            gridLevelNode1.RelationName = "EduList";
            gridLevelNode2.LevelTemplate = this.gridViewSummaryQuery;
            gridLevelNode2.RelationName = "QueryList";
            this.gridControlQuerySummary.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlQuerySummary.Location = new System.Drawing.Point(613, 89);
            this.gridControlQuerySummary.MainView = this.gridViewSummary;
            this.gridControlQuerySummary.Name = "gridControlQuerySummary";
            this.gridControlQuerySummary.Size = new System.Drawing.Size(515, 674);
            this.gridControlQuerySummary.TabIndex = 5;
            this.gridControlQuerySummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSummaryQuery,
            this.gridViewSummary,
            this.gridViewSummaryEdu});
            // 
            // querySummaryModelBindingSource
            // 
            this.querySummaryModelBindingSource.DataSource = typeof(EduFormManager.Forms.UserControls.QueryControl.QueryEduSummaryModel);
            // 
            // gridViewSummaryQuery
            // 
            this.gridViewSummaryQuery.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle});
            this.gridViewSummaryQuery.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewSummaryQuery.GridControl = this.gridControlQuerySummary;
            this.gridViewSummaryQuery.Name = "gridViewSummaryQuery";
            this.gridViewSummaryQuery.OptionsBehavior.Editable = false;
            this.gridViewSummaryQuery.OptionsView.ShowColumnHeaders = false;
            this.gridViewSummaryQuery.OptionsView.ShowGroupPanel = false;
            this.gridViewSummaryQuery.Tag = "SummaryQueryView";
            this.gridViewSummaryQuery.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.view_PopupMenuShowing);
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Запрос";
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // gridViewSummary
            // 
            this.gridViewSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colForm,
            this.colYear});
            this.gridViewSummary.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewSummary.GridControl = this.gridControlQuerySummary;
            this.gridViewSummary.Name = "gridViewSummary";
            this.gridViewSummary.OptionsBehavior.Editable = false;
            this.gridViewSummary.OptionsView.ShowGroupPanel = false;
            this.gridViewSummary.Tag = "SummaryView";
            this.gridViewSummary.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewSummary_MasterRowGetRelationDisplayCaption);
            this.gridViewSummary.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.view_PopupMenuShowing);
            // 
            // colForm
            // 
            this.colForm.Caption = "Форма";
            this.colForm.FieldName = "Form.name";
            this.colForm.Name = "colForm";
            this.colForm.Visible = true;
            this.colForm.VisibleIndex = 0;
            // 
            // colYear
            // 
            this.colYear.Caption = "Год";
            this.colYear.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // gridControlEdu
            // 
            this.gridControlEdu.DataSource = this.eduBindingSource;
            this.gridControlEdu.Location = new System.Drawing.Point(12, 102);
            this.gridControlEdu.MainView = this.gridViewEdu;
            this.gridControlEdu.Name = "gridControlEdu";
            this.gridControlEdu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlEdu.Size = new System.Drawing.Size(573, 673);
            this.gridControlEdu.TabIndex = 0;
            this.gridControlEdu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEdu});
            // 
            // gridViewEdu
            // 
            this.gridViewEdu.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridViewEdu.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewEdu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMunicipality,
            this.colShortName});
            this.gridViewEdu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewEdu.GridControl = this.gridControlEdu;
            this.gridViewEdu.GroupCount = 1;
            this.gridViewEdu.GroupFormat = "{1}";
            this.gridViewEdu.Name = "gridViewEdu";
            this.gridViewEdu.OptionsBehavior.Editable = false;
            this.gridViewEdu.OptionsSelection.MultiSelect = true;
            this.gridViewEdu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewEdu.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewEdu.OptionsView.ShowColumnHeaders = false;
            this.gridViewEdu.OptionsView.ShowGroupPanel = false;
            this.gridViewEdu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMunicipality, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMunicipality
            // 
            this.colMunicipality.FieldName = "municipality.name";
            this.colMunicipality.GroupFormat.FormatString = "{1}";
            this.colMunicipality.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMunicipality.Name = "colMunicipality";
            this.colMunicipality.OptionsColumn.AllowEdit = false;
            this.colMunicipality.OptionsColumn.ReadOnly = true;
            this.colMunicipality.Visible = true;
            this.colMunicipality.VisibleIndex = 1;
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "name";
            this.colShortName.Name = "colShortName";
            this.colShortName.OptionsColumn.AllowEdit = false;
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxForm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Location = new System.Drawing.Point(62, 12);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(223, 29);
            this.comboBoxForm.Sorted = true;
            this.comboBoxForm.TabIndex = 2;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxYear.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(62, 53);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(223, 29);
            this.comboBoxYear.Sorted = true;
            this.comboBoxYear.TabIndex = 3;
            // 
            // queryControl
            // 
            this.queryControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.queryControl.Appearance.Options.UseForeColor = true;
            this.queryControl.ControlType = EduFormManager.Forms.UserControls.XtraBaseControl.Type.Form;
            this.queryControl.FormDataSource = null;
            this.queryControl.FormTypeDataSource = null;
            this.queryControl.Location = new System.Drawing.Point(613, 89);
            this.queryControl.LookAndFeel.SkinName = "Office 2013";
            this.queryControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.queryControl.Name = "queryControl";
            this.queryControl.Repo = null;
            this.queryControl.Size = new System.Drawing.Size(515, 674);
            this.queryControl.TabIndex = 4;
            this.queryControl.View = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonMenuFlyout);
            this.layoutControl1.Controls.Add(this.popupQuerySummaryModel);
            this.layoutControl1.Controls.Add(this.gridControlEdu);
            this.layoutControl1.Controls.Add(this.queryControl);
            this.layoutControl1.Controls.Add(this.gridControlQuerySummary);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(47, 406, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1152, 787);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonMenuFlyout
            // 
            this.buttonMenuFlyout.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenuFlyout.Appearance.Options.UseFont = true;
            this.buttonMenuFlyout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.buttonMenuFlyout.Location = new System.Drawing.Point(1024, 12);
            this.buttonMenuFlyout.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonMenuFlyout.Name = "buttonMenuFlyout";
            this.buttonMenuFlyout.Size = new System.Drawing.Size(116, 30);
            this.buttonMenuFlyout.TabIndex = 8;
            this.buttonMenuFlyout.Text = "Меню";
            // 
            // popupQuerySummaryModel
            // 
            this.popupQuerySummaryModel.EditValue = "Выбрать форму";
            this.popupQuerySummaryModel.Location = new System.Drawing.Point(12, 46);
            this.popupQuerySummaryModel.Name = "popupQuerySummaryModel";
            this.popupQuerySummaryModel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupQuerySummaryModel.Properties.Appearance.Options.UseFont = true;
            this.popupQuerySummaryModel.Properties.Appearance.Options.UseTextOptions = true;
            this.popupQuerySummaryModel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.popupQuerySummaryModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupQuerySummaryModel.Properties.CloseOnLostFocus = false;
            this.popupQuerySummaryModel.Properties.CloseOnOuterMouseClick = false;
            this.popupQuerySummaryModel.Properties.PopupControl = this.popupContainerQueryModel;
            this.popupQuerySummaryModel.Properties.ShowPopupCloseButton = false;
            this.popupQuerySummaryModel.Size = new System.Drawing.Size(573, 28);
            this.popupQuerySummaryModel.StyleController = this.layoutControl1;
            this.popupQuerySummaryModel.TabIndex = 7;
            // 
            // popupContainerQueryModel
            // 
            this.popupContainerQueryModel.AutoSize = true;
            this.popupContainerQueryModel.Controls.Add(this.layoutControl2);
            this.popupContainerQueryModel.Location = new System.Drawing.Point(447, 496);
            this.popupContainerQueryModel.Name = "popupContainerQueryModel";
            this.popupContainerQueryModel.Size = new System.Drawing.Size(297, 161);
            this.popupContainerQueryModel.TabIndex = 8;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.buttonClosePopup);
            this.layoutControl2.Controls.Add(this.checkBoxOnlyPassport);
            this.layoutControl2.Controls.Add(this.comboBoxForm);
            this.layoutControl2.Controls.Add(this.comboBoxYear);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1074, 388, 468, 350);
            this.layoutControl2.Root = this.layoutControlGroup4;
            this.layoutControl2.Size = new System.Drawing.Size(297, 161);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // buttonClosePopup
            // 
            this.buttonClosePopup.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClosePopup.Appearance.Options.UseFont = true;
            this.buttonClosePopup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.buttonClosePopup.Location = new System.Drawing.Point(150, 119);
            this.buttonClosePopup.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonClosePopup.Name = "buttonClosePopup";
            this.buttonClosePopup.Size = new System.Drawing.Size(135, 30);
            this.buttonClosePopup.TabIndex = 6;
            this.buttonClosePopup.Text = "Принять";
            // 
            // checkBoxOnlyPassport
            // 
            this.checkBoxOnlyPassport.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxOnlyPassport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxOnlyPassport.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnlyPassport.Location = new System.Drawing.Point(12, 95);
            this.checkBoxOnlyPassport.Name = "checkBoxOnlyPassport";
            this.checkBoxOnlyPassport.Size = new System.Drawing.Size(273, 20);
            this.checkBoxOnlyPassport.TabIndex = 5;
            this.checkBoxOnlyPassport.Text = "Только паспорт";
            this.checkBoxOnlyPassport.UseVisualStyleBackColor = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(297, 161);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.comboBoxForm;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(277, 25);
            this.layoutControlItem4.Text = "Форма";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(47, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.comboBoxYear;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(277, 25);
            this.layoutControlItem5.Text = "Год";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(47, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 25);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(277, 16);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(277, 17);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 107);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(138, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.checkBoxOnlyPassport;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 83);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(277, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonClosePopup;
            this.layoutControlItem6.Location = new System.Drawing.Point(138, 107);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(139, 34);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.tabbedControlGroup1,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.splitterItem1,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1152, 787);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.gridControlEdu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(577, 701);
            this.layoutControlItem1.Text = "Образовательные организации";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(222, 21);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.AppearanceTabPage.Header.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbedControlGroup1.AppearanceTabPage.Header.Options.UseFont = true;
            this.tabbedControlGroup1.AppearanceTabPage.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabbedControlGroup1.AppearanceTabPage.HeaderActive.Options.UseFont = true;
            this.tabbedControlGroup1.AppearanceTabPage.HeaderHotTracked.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tabbedControlGroup1.AppearanceTabPage.HeaderHotTracked.Options.UseFont = true;
            this.tabbedControlGroup1.Location = new System.Drawing.Point(589, 34);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(543, 733);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(519, 678);
            this.layoutControlGroup3.Text = "Сводка по выбранным позициям";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControlQuerySummary;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(519, 678);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(519, 678);
            this.layoutControlGroup2.Text = "Запросы";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.queryControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(519, 678);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.popupQuerySummaryModel;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(577, 32);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.buttonMenuFlyout;
            this.layoutControlItem9.Location = new System.Drawing.Point(1012, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(120, 34);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(577, 34);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 733);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(1012, 34);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // flyoutPanelMenu
            // 
            this.flyoutPanelMenu.Controls.Add(this.flyoutPanelControlMenu);
            this.flyoutPanelMenu.Location = new System.Drawing.Point(221, 51);
            this.flyoutPanelMenu.Name = "flyoutPanelMenu";
            this.flyoutPanelMenu.Options.CloseOnOuterClick = true;
            this.flyoutPanelMenu.OwnerControl = this;
            this.flyoutPanelMenu.Size = new System.Drawing.Size(388, 100);
            this.flyoutPanelMenu.TabIndex = 10;
            // 
            // flyoutPanelControlMenu
            // 
            this.flyoutPanelControlMenu.Controls.Add(this.windowsUIButtonPanelActions);
            this.flyoutPanelControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControlMenu.FlyoutPanel = this.flyoutPanelMenu;
            this.flyoutPanelControlMenu.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControlMenu.Name = "flyoutPanelControlMenu";
            this.flyoutPanelControlMenu.Size = new System.Drawing.Size(388, 100);
            this.flyoutPanelControlMenu.TabIndex = 0;
            // 
            // windowsUIButtonPanelActions
            // 
            this.windowsUIButtonPanelActions.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanelActions.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsUIButtonPanelActions.Location = new System.Drawing.Point(2, 2);
            this.windowsUIButtonPanelActions.Name = "windowsUIButtonPanelActions";
            this.windowsUIButtonPanelActions.Size = new System.Drawing.Size(384, 95);
            this.windowsUIButtonPanelActions.TabIndex = 0;
            // 
            // XtraQueryEduControl
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanelMenu);
            this.Controls.Add(this.popupContainerQueryModel);
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraQueryEduControl";
            this.Size = new System.Drawing.Size(1152, 787);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummaryEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuerySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querySummaryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummaryQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupQuerySummaryModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerQueryModel)).EndInit();
            this.popupContainerQueryModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelMenu)).EndInit();
            this.flyoutPanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControlMenu)).EndInit();
            this.flyoutPanelControlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControlEdu;
        private GridView gridViewEdu;
        private GridColumn colMunicipality;
        private GridColumn colShortName;
        private ComboBox comboBoxForm;
        private ComboBox comboBoxYear;
        private QueryCheckListControl queryControl;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private GridControl gridControlQuerySummary;
        private GridView gridViewSummary;
        private BindingSource querySummaryModelBindingSource;
        private GridView gridViewSummaryQuery;
        private GridView gridViewSummaryEdu;
        private GridColumn colShortName1;
        private GridColumn colTitle;
        private GridColumn colForm;
        private GridColumn colYear;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private TabbedControlGroup tabbedControlGroup1;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlGroup layoutControlGroup3;
        private LayoutControlItem layoutControlItem3;
        private PopupContainerEdit popupQuerySummaryModel;
        private PopupContainerControl popupContainerQueryModel;
        private LayoutControl layoutControl2;
        private LayoutControlGroup layoutControlGroup4;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem5;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem2;
        private EmptySpaceItem emptySpaceItem3;
        private CheckBox checkBoxOnlyPassport;
        private LayoutControlItem layoutControlItem8;
        private SimpleButton buttonClosePopup;
        private LayoutControlItem layoutControlItem6;
        private SimpleButton buttonMenuFlyout;
        private LayoutControlItem layoutControlItem9;
        private SplitterItem splitterItem1;
        private EmptySpaceItem emptySpaceItem4;
        private DevExpress.Utils.FlyoutPanel flyoutPanelMenu;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControlMenu;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelActions;


    }
}
