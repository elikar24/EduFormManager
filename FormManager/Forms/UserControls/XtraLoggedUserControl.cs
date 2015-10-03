using System;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraLoggedUserControl : XtraUserControl
    {
        public XtraLoggedUserControl()
        {
            InitializeComponent();
        }

        public override String Text
        {
            get
            {
                return this.linkLabel1.Text;
            }
            set
            {
                this.linkLabel1.Text = value;
            }
        }
    }
}
