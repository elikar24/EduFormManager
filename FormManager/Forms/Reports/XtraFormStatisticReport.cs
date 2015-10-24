using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraFormStatisticReport : XtraReport
    {
        public XtraFormStatisticReport()
        {
            InitializeComponent();
        }

        public IList<t_form_statistics> FormStatisticDataSource
        {
            set
            {
                this.formStatisticBindingSource.DataSource = value;
            }
        }

    }
}
