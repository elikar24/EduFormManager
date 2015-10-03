using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraProgress : XtraUserControl
    {
        private bool _isRegular;

        public XtraProgress()
        {
            InitializeComponent();

            this.UseRegularProgressBar = true;
        }

        public bool UseRegularProgressBar
        {
            set
            {
                _isRegular = value;
                this.regularProgressBar.Visible = value;
                this.marqueeProgressBar.Visible = !value;
            }
            get 
            { 
                return _isRegular; 
            }
        }

        public bool UseMarqueeProgressBar
        {
            set
            {
                _isRegular = !value;
                this.regularProgressBar.Visible = !value;
                this.marqueeProgressBar.Visible = value;
            }
            get
            {
                return !_isRegular;
            }
        }

        public void SetProgress(int current, int max = 100)
        {
            if (_isRegular)
            {
                this.regularProgressBar.Properties.Maximum = max;
                this.regularProgressBar.Properties.Minimum = 0;
                this.regularProgressBar.Position = current < max ? current : max;
            }
        }
    }
}
