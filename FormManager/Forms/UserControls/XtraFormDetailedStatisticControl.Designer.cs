using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraFormDetailedStatisticControl
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
            this.colIsUploaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.formStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMunicipalityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEduShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEduKindName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barEditItemYear = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBoxYear = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItemReport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxYear)).BeginInit();
            this.SuspendLayout();
            // 
            // colIsUploaded
            // 
            this.colIsUploaded.Caption = "-";
            this.colIsUploaded.FieldName = "is_uploaded";
            this.colIsUploaded.Name = "colIsUploaded";
            this.colIsUploaded.OptionsEditForm.Caption = "Загрузили:";
            this.colIsUploaded.Visible = true;
            this.colIsUploaded.VisibleIndex = 1;
            this.colIsUploaded.Width = 56;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.formStatisticBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1125, 459);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // formStatisticBindingSource
            // 
            this.formStatisticBindingSource.DataSource = typeof(EduFormManager.Models.t_detailed_form_statistics);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMunicipalityName,
            this.colEduShortName,
            this.colFormName,
            this.colFormId,
            this.colYear,
            this.colFormTypeName,
            this.colFormTypeId,
            this.colEduKindName,
            this.colIsUploaded,
            this.colId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 5;
            this.gridView1.GroupFormat = "{1}";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFormTypeName, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEduKindName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFormName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMunicipalityName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsUploaded, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colMunicipalityName
            // 
            this.colMunicipalityName.Caption = "Муниципалитет";
            this.colMunicipalityName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMunicipalityName.FieldName = "municipality";
            this.colMunicipalityName.Name = "colMunicipalityName";
            this.colMunicipalityName.OptionsEditForm.Caption = "Муниципалитет";
            this.colMunicipalityName.Visible = true;
            this.colMunicipalityName.VisibleIndex = 0;
            this.colMunicipalityName.Width = 83;
            // 
            // colEduShortName
            // 
            this.colEduShortName.Caption = "Обр. организация";
            this.colEduShortName.FieldName = "edu_name";
            this.colEduShortName.Name = "colEduShortName";
            this.colEduShortName.OptionsEditForm.Caption = "Образовательная организация";
            this.colEduShortName.Visible = true;
            this.colEduShortName.VisibleIndex = 0;
            this.colEduShortName.Width = 125;
            // 
            // colFormName
            // 
            this.colFormName.Caption = "Форма";
            this.colFormName.FieldName = "form";
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsEditForm.Caption = "Форма";
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            this.colFormName.Width = 56;
            // 
            // colFormId
            // 
            this.colFormId.FieldName = "form_id";
            this.colFormId.Name = "colFormId";
            this.colFormId.Width = 146;
            // 
            // colYear
            // 
            this.colYear.FieldName = "year";
            this.colYear.Name = "colYear";
            this.colYear.Width = 146;
            // 
            // colFormTypeName
            // 
            this.colFormTypeName.Caption = "Тип формы";
            this.colFormTypeName.FieldName = "form_type";
            this.colFormTypeName.Name = "colFormTypeName";
            this.colFormTypeName.OptionsEditForm.Caption = "Тип формы";
            this.colFormTypeName.Visible = true;
            this.colFormTypeName.VisibleIndex = 1;
            this.colFormTypeName.Width = 56;
            // 
            // colFormTypeId
            // 
            this.colFormTypeId.FieldName = "form_type_id";
            this.colFormTypeId.Name = "colFormTypeId";
            this.colFormTypeId.Width = 146;
            // 
            // colEduKindName
            // 
            this.colEduKindName.Caption = "Тип обр. учреждения";
            this.colEduKindName.FieldName = "edu_kind";
            this.colEduKindName.Name = "colEduKindName";
            this.colEduKindName.OptionsEditForm.Caption = "Тип обр. учреждения";
            this.colEduKindName.Visible = true;
            this.colEduKindName.VisibleIndex = 1;
            this.colEduKindName.Width = 56;
            // 
            // colId
            // 
            this.colId.FieldName = "row_id";
            this.colId.Name = "colId";
            this.colId.Width = 146;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1149, 483);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1149, 483);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1129, 463);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItemYear,
            this.barButtonItemReport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxYear});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItemYear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReport)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barEditItemYear
            // 
            this.barEditItemYear.Caption = "Год";
            this.barEditItemYear.Edit = this.repositoryItemComboBoxYear;
            this.barEditItemYear.Id = 0;
            this.barEditItemYear.Name = "barEditItemYear";
            this.barEditItemYear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // repositoryItemComboBoxYear
            // 
            this.repositoryItemComboBoxYear.AutoHeight = false;
            this.repositoryItemComboBoxYear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxYear.Name = "repositoryItemComboBoxYear";
            this.repositoryItemComboBoxYear.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barButtonItemReport
            // 
            this.barButtonItemReport.Caption = "Отчет";
            this.barButtonItemReport.Id = 1;
            this.barButtonItemReport.Name = "barButtonItemReport";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1149, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 507);
            this.barDockControlBottom.Size = new System.Drawing.Size(1149, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1149, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // XtraFormDetailedStatisticControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraFormDetailedStatisticControl";
            this.Size = new System.Drawing.Size(1149, 507);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private BindingSource formStatisticBindingSource;
        private GridColumn colMunicipalityName;
        private GridColumn colEduShortName;
        private GridColumn colFormName;
        private GridColumn colFormId;
        private GridColumn colYear;
        private GridColumn colFormTypeName;
        private GridColumn colFormTypeId;
        private GridColumn colEduKindName;
        private GridColumn colIsUploaded;
        private GridColumn colId;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private BarManager barManager1;
        private Bar bar2;
        private BarEditItem barEditItemYear;
        private RepositoryItemComboBox repositoryItemComboBoxYear;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItemReport;
    }
}
