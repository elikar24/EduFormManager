using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using EduFormManager.Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraMunicipalityFormStatisticReport : XtraReport
    {
        public XtraMunicipalityFormStatisticReport()
        {
            InitializeComponent();
        }

        public IList<t_municipality_form_statistics> FormStatisticDataSource
        {
            set
            {
                this.formStatisticBindingSource.DataSource = value;
            }
        }

    }
}
