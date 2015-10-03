using System;
using DevExpress.LookAndFeel;
using EduFormManager.Forms.UserControls;

namespace EduFormManager
{
    public partial class AuthenticationForm : XtraBaseControl
    {
        public class AuthenticationRequestArgs : EventArgs
        {
            public String UserName { get; set; }
            public String Password { get; set; }
        }

        public event EventHandler<AuthenticationRequestArgs> AuthenticationRequested;
        public AuthenticationForm(String defaultUser = "admin", String defaultPassword = "")
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            textUserName.Text = defaultUser;
            textPassword.Text = defaultPassword;
        }

        public AuthenticationRequestArgs Args
        {
            get
            {
                AuthenticationRequestArgs args = new AuthenticationRequestArgs();

                args.UserName = this.textUserName.Text;
                args.Password = this.textPassword.Text;
                return args;
            }
        }

        public void Submit()
        {
            AuthenticationRequestArgs args = new AuthenticationRequestArgs();
            
            args.UserName = this.textUserName.Text;
            args.Password = this.textPassword.Text;

            onAuthenticationRequested(args);
        }

        protected void onAuthenticationRequested(AuthenticationRequestArgs args)
        {
            EventHandler<AuthenticationRequestArgs> handler = AuthenticationRequested;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            textPassword.Properties.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void checkBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void checkBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            checkBox1.Checked = true;
        }
    }
}
