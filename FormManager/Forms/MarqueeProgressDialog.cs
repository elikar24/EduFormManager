using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms
{
    public partial class MarqueeProgressDialog : XtraForm, IDisposable
    {
        private IWin32Window _owner;
        public MarqueeProgressDialog()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }

        public MarqueeProgressDialog(IWin32Window owner, string caption = "Пожалуйста подождите", string description = "Идет загрузка")
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            this.ShowTop(owner, caption, description);
        }
        public String Caption
        {
            set
            {
                this.progressPanel1.Caption = value;
            }
        }

        public String Description
        {
            set
            {
                this.progressPanel1.Description = value;
            }
        }

        public void ShowTop(IWin32Window owner, string caption = "Пожалуйста подождите", string description = "Идет загрузка")
        {
            _owner = owner;
            Control form = owner is Form ? owner as Form : owner as Control;
            form.Move += Parent_Move;
            form.Resize += form_Resize;
            this.Size = form.ClientSize;
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = form.PointToScreen(form.ClientRectangle.Location);

            CenterProgressPanel();

            this.Caption = caption;
            this.Description = description;
            if (!this.Visible)
                this.Show(owner);
        }

        void form_Resize(object sender, EventArgs e)
        {
            var form = sender as Control;
            if (form != null) this.Size = form.ClientSize;
            CenterProgressPanel();
        }

        void Parent_Move(object sender, EventArgs e)
        {
            var form = sender as Control;
            if (form != null)
            {
                this.Location = form.PointToScreen(form.ClientRectangle.Location);
                this.Size = form.ClientSize;
            }
            CenterProgressPanel();
        }

        public void HideTop()
        {
            this.Hide();
            var form = _owner as Form;
            if (form != null)
            {
                form.Move -= Parent_Move;
                form.Resize -= form_Resize;
            }
        }

        private void CenterProgressPanel()
        {
            Point locationPoint = new Point() 
            { 
                X = (this.Width - this.progressPanel1.Width) / 2, 
                Y = (this.Height - this.progressPanel1.Height) / 2 
            };
            this.progressPanel1.Location = locationPoint;
        }

        void IDisposable.Dispose()
        {
            this.HideTop();
            base.Dispose();
        }
    }
}