using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using EduFormManager.Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraFormStatisticSummaryReport : XtraReport
    {
        public XtraFormStatisticSummaryReport()
        {
            InitializeComponent();
        }

        public IList<t_summary_form_statistics> FormStatisticSummaryDataSource
        {
            set
            {
                this.formStatisticSummaryBindingSource.DataSource = value;
            }
        }

    }
}
