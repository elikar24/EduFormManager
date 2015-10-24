using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using Models;

namespace EduFormManager.Forms.Reports
{
    public partial class XtraSignInOutReport : XtraReport
    {
        public XtraSignInOutReport()
        {
            InitializeComponent();
        }

        public IList<edu_log> SignInOutLogDataSource
        {
            set
            {
                this.logBindingSource.DataSource = value;
            }
        }
    }
}
