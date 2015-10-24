using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraDetailedFormStatisticReport : XtraReport
    {
        public XtraDetailedFormStatisticReport()
        {
            InitializeComponent();
        }

        public IList<t_detailed_form_statistics> FormStatisticDataSource
        {
            set { this.bindingSource1.DataSource = value; }
        }
    }
}
