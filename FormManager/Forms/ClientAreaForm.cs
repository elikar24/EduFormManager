using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms
{
    public partial class ClientAreaForm : XtraForm
    {
        private IWin32Window m_owner;
        public ClientAreaForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
        }

        public new void Show(IWin32Window owner)
        {
            m_owner = owner;
            Control form = owner is Form ? owner as Form : owner as Control;
            form.Move += Parent_Move;
            form.Resize += form_Resize;
            this.Size = form.ClientSize;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = form.PointToScreen(form.ClientRectangle.Location);
            
            base.ShowDialog(owner);
        }

        public new void Close()
        {
            Form form = m_owner as Form;
            form.Move -= Parent_Move;
            form.Resize -= form_Resize;

            base.Close();
        }

        void form_Resize(object sender, EventArgs e)
        {
            Control form = sender as Control;
            this.Size = form.ClientSize;
        }

        void Parent_Move(object sender, EventArgs e)
        {
            Control form = sender as Control;
            this.Location = form.PointToScreen(form.ClientRectangle.Location);
            this.Size = form.ClientSize;
        }
    }
}
