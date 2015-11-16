using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraNavPane : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraNavPane()
        {
            InitializeComponent();
            officeNavigationBar1.ItemClick += officeNavigationBar1_ItemClick;
            officeNavigationBar1.MaxItemCount = 16;

            this.simpleButton1.Click += (sender, args) =>
            {
                if (this.Home == null)
                    return;
                var view = (WindowsUIView)this.Home.Manager.View;
                view.ActivateContainer(this.Home);
            };
        }

        public IContentContainer Home { get; set; }


        void officeNavigationBar1_ItemClick(object sender, NavigationBarItemEventArgs e)
        {
            var container = (IContentContainer)e.Item.Tag;
            var view = (WindowsUIView) container.Manager.View;
            view.ActivateContainer(container);
        }

        public void PushItem(IContentContainer container)
        {
            var item = new NavigationBarItem();
            var view = container.Manager.View as WindowsUIView;
            if (view == null)
            {
                return;
            }
            item.Text = String.IsNullOrEmpty(container.Subtitle) ? container.Caption + " >" : container.Subtitle + " >";
            item.Tag = container;
            officeNavigationBar1.Items.Insert(0,item);
        }

        public void ClearItems()
        {
            officeNavigationBar1.Items.Clear();
        }
    }
}
