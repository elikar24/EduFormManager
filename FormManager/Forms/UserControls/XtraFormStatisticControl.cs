using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraFormStatisticControl : XtraUserControl
    {
        public XtraFormStatisticControl()
        {
            InitializeComponent();
        }

        public IList<t_form_statistics> FormStatisticDataSource
        {
            get
            {
                return this.formStatisticBindingSource.List.Cast<t_form_statistics>().ToList();
            }
            set
            {
                this.formStatisticBindingSource.DataSource = value;
            }
        }
    }
}
