using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using EduFormManager.Models;
using EduFormManager.Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraMessageListControl : XtraBaseControl, ISupportNavigation
    {
        public XtraMessageListControl(WindowsUIView view, Repository repo)
            :base(view, repo)
        {
            InitializeComponent();
        }

        private bool _isUpdateNeeded = false;

        private const int SubjectFontSize = 10;
        private const int FromFontSize = 8;
        private const int DateFontSize = 8;

        private readonly Color SubjectForecolor = Color.FromArgb(59, 59, 59);
        private readonly Color FromForecolor = Color.FromArgb(100, 100, 100);
        private readonly Color DateForecolor = Color.FromArgb(170, 170, 170);

        private readonly Font SubjectFont = new Font(DefaultFont.FontFamily, SubjectFontSize);
        private readonly Font FromFont = new Font(DefaultFont.FontFamily, FromFontSize);
        private readonly Font DateFont = new Font(DefaultFont.FontFamily, DateFontSize);

        private async void listBoxMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var msg = (message) this.messageBindingSource.Current;
            if (!msg.is_viewed)
            {
                msg.is_viewed = true;
                await Repo.Db.SaveChangesAsync();
            }
        }

        private void listBoxMessage_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lst = (ListBoxControl) sender;
            var msg = (message) lst.GetItem(e.Index);
            int itemHeight = 0;
            itemHeight += (int) e.Graphics.MeasureString(msg.subject, SubjectFont, lst.Width).Height;
            itemHeight += (int)e.Graphics.MeasureString(msg.edu.name, FromFont, lst.Width).Height;
            itemHeight += (int)e.Graphics.MeasureString(msg.send_date.ToString("G"), DateFont, lst.Width).Height;
            e.ItemHeight = itemHeight + 32;
            e.ItemWidth += 24;
        }

        private void listBoxMessage_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            var lst = (ListBoxControl) sender;
            var message = (message) lst.GetItem(e.Index);
            if (message == null)
            {
                e.Handled = false;
                return;
            }
            e.Cache.FillRectangle(new SolidBrush(e.Appearance.BackColor), e.Bounds);
            if ((e.State & DrawItemState.Focus) != 0)
            {
                e.Cache.DrawRectangle(new Pen(Color.FromArgb(0x68, 0xB4, 0xFF)), e.Bounds);
                e.Cache.FillRectangle(new SolidBrush(Color.FromArgb(90, 71, 177, 255)), e.Bounds);
            }
            if ((e.State & DrawItemState.HotLight) != 0)
            {
                e.Cache.FillRectangle(new SolidBrush(Color.FromArgb(20, 0, 114, 198)), e.Bounds);
                e.Cache.DrawRectangle(new Pen(Color.FromArgb(164, 208, 251)), e.Bounds);
            }
            if (!message.is_viewed)
            {
                e.Cache.FillRectangle(new SolidBrush(Color.FromArgb(30, 59, 59, 59)), e.Bounds);
            }
            int subjectItemHeight = (int) e.Graphics.MeasureString(message.subject, SubjectFont, lst.Width).Height;
            int fromItemHeight = (int)e.Graphics.MeasureString(message.edu.name, FromFont, lst.Width).Height;
            int dateItemHeight = (int)e.Graphics.MeasureString(message.send_date.ToString("G"), DateFont, lst.Width).Height;

            e.Graphics.DrawString(message.subject, SubjectFont, new SolidBrush(SubjectForecolor),
                new RectangleF(e.Bounds.X + 6, e.Bounds.Y + 8, e.Bounds.Width, subjectItemHeight));
            e.Graphics.DrawString(message.edu.name, FromFont, new SolidBrush(FromForecolor),
                new RectangleF(e.Bounds.X + 12, e.Bounds.Y + subjectItemHeight + 3 + 8, e.Bounds.Width, fromItemHeight));
            e.Graphics.DrawString(message.send_date.ToString("G"), DateFont, new SolidBrush(DateForecolor),
                new RectangleF(e.Bounds.X + 12, e.Bounds.Y + subjectItemHeight + fromItemHeight + 6 + 8, e.Bounds.Width, dateItemHeight));
            if ((e.State & DrawItemState.Focus) == 0)
                e.Graphics.DrawLine(new Pen(Color.FromArgb(30, 59, 59, 59), 1), e.Bounds.LeftBottom(), e.Bounds.RightBottom());
            e.Handled = true;
        }

        public void OnNavigatedFrom(INavigationArgs args)
        {
            _isUpdateNeeded = true;
        }

        async public void OnNavigatedTo(INavigationArgs args)
        {
            if (_isUpdateNeeded)
            {
                this.messageBindingSource.DataSource = await Repo.GetMessages();
            }
        }
    }
}
