using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace EduFormManager.Forms
{
    public partial class CheckResultSummaryForm : XtraForm
    {
        public CheckResultSummaryForm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"/*"Visual Studio 2013 Dark"*/);
        }

        public void SetData(object data)
        {
            this.checkExpressionResultBindingSource.DataSource = data;
            this.gridView1.OptionsView.RowAutoHeight = true;
            
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            if (e.Column.FieldName == "Color")
            {
                e.Appearance.BackColor = (Color)e.CellValue;
            }
        }
    }
}