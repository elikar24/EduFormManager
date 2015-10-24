using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraDetailedMunicipalityFormStatisticReport : XtraReport
    {
        public XtraDetailedMunicipalityFormStatisticReport()
        {
            InitializeComponent();
        }

        public IList<t_detailed_municipality_form_statistics> FormStatisticDataSource
        {
            set { this.bindingSource1.DataSource = value; }
        }
    }
}
