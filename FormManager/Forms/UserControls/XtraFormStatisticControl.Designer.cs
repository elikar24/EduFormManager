using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraFormStatisticControl
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
            this.formStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMunicipalityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEduShortname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverallCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOKCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiredCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBadCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoadedCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.formStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // formStatisticBindingSource
            // 
            this.formStatisticBindingSource.DataSource = typeof(Models.t_form_statistics);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMunicipalityName,
            this.colEduShortname,
            this.colOverallCount,
            this.colOKCount,
            this.colExpiredCount,
            this.colErrorCount,
            this.colBadCount,
            this.colLoadedCount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OverallCount", null, "Должно быть загружено {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoadedCount", null, "Загружено {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OKCount", null, "Без ошибок {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ErrorCount", null, "С ошибками {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExpiredCount", null, "С опозданием {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BadCount", null, "С ошибками и опозданием {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMunicipalityName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMunicipalityName
            // 
            this.colMunicipalityName.Caption = "Муниципалитет";
            this.colMunicipalityName.FieldName = "munit_name";
            this.colMunicipalityName.Name = "colMunicipalityName";
            this.colMunicipalityName.Visible = true;
            this.colMunicipalityName.VisibleIndex = 0;
            // 
            // colEduShortname
            // 
            this.colEduShortname.Caption = "Обр. организация  (сокр.)";
            this.colEduShortname.FieldName = "org_shortname";
            this.colEduShortname.Name = "colEduShortname";
            this.colEduShortname.Visible = true;
            this.colEduShortname.VisibleIndex = 0;
            this.colEduShortname.Width = 210;
            // 
            // colOverallCount
            // 
            this.colOverallCount.Caption = "Должно быть загружено";
            this.colOverallCount.FieldName = "overall_count";
            this.colOverallCount.Name = "colOverallCount";
            this.colOverallCount.Visible = true;
            this.colOverallCount.VisibleIndex = 1;
            this.colOverallCount.Width = 146;
            // 
            // colOKCount
            // 
            this.colOKCount.Caption = "Без ошибок";
            this.colOKCount.FieldName = "ok_count";
            this.colOKCount.Name = "colOKCount";
            this.colOKCount.Visible = true;
            this.colOKCount.VisibleIndex = 2;
            this.colOKCount.Width = 82;
            // 
            // colExpiredCount
            // 
            this.colExpiredCount.Caption = "С опозданием";
            this.colExpiredCount.FieldName = "expired_count";
            this.colExpiredCount.Name = "colExpiredCount";
            this.colExpiredCount.Visible = true;
            this.colExpiredCount.VisibleIndex = 3;
            this.colExpiredCount.Width = 79;
            // 
            // colErrorCount
            // 
            this.colErrorCount.Caption = "С ошибками";
            this.colErrorCount.FieldName = "error_count";
            this.colErrorCount.Name = "colErrorCount";
            this.colErrorCount.Visible = true;
            this.colErrorCount.VisibleIndex = 4;
            // 
            // colBadCount
            // 
            this.colBadCount.Caption = "С ошибками и опозданием";
            this.colBadCount.FieldName = "bad_count";
            this.colBadCount.Name = "colBadCount";
            this.colBadCount.Visible = true;
            this.colBadCount.VisibleIndex = 5;
            this.colBadCount.Width = 151;
            // 
            // colLoadedCount
            // 
            this.colLoadedCount.Caption = "Всего загружено";
            this.colLoadedCount.FieldName = "loaded_count";
            this.colLoadedCount.Name = "colLoadedCount";
            this.colLoadedCount.Visible = true;
            this.colLoadedCount.VisibleIndex = 6;
            this.colLoadedCount.Width = 92;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.formStatisticBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(979, 433);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // XtraFormStatisticControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraFormStatisticControl";
            this.Size = new System.Drawing.Size(985, 439);
            ((System.ComponentModel.ISupportInitialize)(this.formStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource formStatisticBindingSource;
        private GridView gridView1;
        private GridControl gridControl1;
        private GridColumn colMunicipalityName;
        private GridColumn colEduShortname;
        private GridColumn colOverallCount;
        private GridColumn colOKCount;
        private GridColumn colExpiredCount;
        private GridColumn colErrorCount;
        private GridColumn colBadCount;
        private GridColumn colLoadedCount;
    }
}
