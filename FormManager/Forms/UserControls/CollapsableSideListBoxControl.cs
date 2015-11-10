using System.Drawing;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using EduFormManager.Forms.UserControls;
using EduFormManager.Properties;
using Debug = System.Diagnostics.Debug;

namespace EduFormManager.Forms
{
    public partial class CollapsableSideListBoxControl : XtraBaseControl
    {
        private Color _foreColor = Color.White;
        private int _hoveredIndex;
        private int _clickedIndex;
        private readonly Image _image = new Bitmap(Resources.close01_white);
        private Rectangle _lastRectangle = new Rectangle(0,0,16,16);

        private readonly Font _font = new Font("Segoe UI Light", 12);

        public CollapsableSideListBoxControl()
        {
            InitializeComponent();

            this.listBoxControl1.DataSource = Notifications.List;
            this.listBoxControl1.BackColor = this.BackColor;
        }
        
        public void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lst = (ListBoxControl) sender;
            if (e.Index >= 0)
            {
                e.ItemHeight = (int) e.Graphics.MeasureString(lst.GetItemText(e.Index), lst.Font, lst.Width - 24).Height + 24;
                e.ItemWidth += 24;
            }
        }

        private void listBoxControl1_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            var lst = (ListBoxControl) sender;

            e.Cache.FillRectangle(new SolidBrush(Color.Transparent), e.Bounds);
            if (e.Index == _hoveredIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(89, 121, 189, 255)), e.Bounds);

                var imgRect = new Rectangle(0, 0, 16, 16);
                imgRect.Location = new Point(e.Bounds.Right - imgRect.Width, e.Bounds.Top + (e.Bounds.Height - imgRect.Height) / 2);
                e.Graphics.DrawImage(_image, imgRect);
            }
            if (e.Item is Notifications.ExpireWarn)
            {
                var warn = (Notifications.ExpireWarn) e.Item;
                if (warn.DaysRemain < 4)
                    _foreColor = Color.LightCoral;
                else if (warn.DaysRemain >= 4 && warn.DaysRemain < 7)
                    _foreColor = Color.Khaki;
                else
                    _foreColor = Color.PaleGreen;
            }
            else
            {
                _foreColor = Color.White;
            }

            var text = lst.GetItemText(e.Index);
            var itemHeight = (int)e.Graphics.MeasureString(text, _font, lst.Width).Height;
            var topPadding = 12;
            var leftPadding = 12;
            if (e.Index == _clickedIndex)
            {
                topPadding = 10;
                leftPadding = 11;
            }
            e.Graphics.DrawString(text, _font, new SolidBrush(_foreColor),
                    new RectangleF(e.Bounds.X + leftPadding, e.Bounds.Y + topPadding, e.Bounds.Width, itemHeight));

            //TextUtils.DrawString(e.Graphics, lst.GetItemText(e.Index), lst.Appearance.Font, _foreColor, e.Bounds);
            e.Handled = true;
        }

        
        private void listBoxControl1_MouseMove(object sender, MouseEventArgs e)
        {
            var lst = (ListBoxControl) sender;
            int idx = lst.IndexFromPoint(e.Location);
            if (idx != _hoveredIndex)
            {
                _hoveredIndex = idx;
                lst.Invalidate();
            }
            Rectangle itemRect = lst.GetItemRectangle(idx);
            Rectangle imgRect = new Rectangle(0, 0, 16, 16);
            imgRect.Location = new Point(itemRect.Right - imgRect.Width, itemRect.Top + (itemRect.Height - imgRect.Height) / 2);
            if (imgRect.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
                _lastRectangle = imgRect;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void listBoxControl1_MouseClick(object sender, MouseEventArgs e)
        {
            var lst = (ListBoxControl)sender;
            var idx = lst.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                if (_lastRectangle.Contains(e.Location))
                {
                    var val = lst.GetItem(idx);
                    Notifications.Remove(val);
                }
            }
            
        }

        private void listBoxControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lst = (ListBoxControl)sender;
            var idx = lst.IndexFromPoint(e.Location);
            _clickedIndex = idx;
            lst.Invalidate();
        }

        private void listBoxControl1_MouseUp(object sender, MouseEventArgs e)
        {
            _clickedIndex = -1;
            var lst = (ListBoxControl)sender;
            lst.Invalidate();
        }
    }
}
