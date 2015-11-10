using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace EduFormManager.Forms
{
    public partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            InitializeComponent();
        }

        public void PushItem(IContentContainer container)
        {
            var item = CreateBarItem(container);
            if (item != null)
            {
                this.tileBarGroupNav.Items.Insert(0, item);
                this.simpleButton1.Visible = true;
            }
        }

        public void ClearItems()
        {
            this.tileBarGroupNav.Items.Clear();
            this.simpleButton1.Visible = false;
        }

        private IContentContainer m_homeContainer;
        
        public IContentContainer Home
        {
            get 
            {
                return m_homeContainer;
            }
            set
            {
                m_homeContainer = value;
                var view = value.Manager.View as WindowsUIView;
                this.simpleButton1.Click += (s, e) => view.ActivateContainer(m_homeContainer);
                this.tileBarGroupHome.Items.Clear();
            } 
        }

        private TileBarItem CreateBarItem(IContentContainer container)
        {
            var view = container.Manager.View as WindowsUIView;
            var tileContainer = container as TileContainer;
            var detailContainer = container as IDetailContainerInfo;
            if (view == null)
            {
                return null;
            }
            string text = null;
            if (tileContainer != null)
            {
                text = String.IsNullOrEmpty(container.Subtitle) ? container.Caption : container.Subtitle;
            }
            else if (detailContainer != null)
            {
                text = detailContainer.DocumentInfo.Document.Caption;
            }
            var tileBarItem = new TileBarItem()
            {
                Text = String.IsNullOrEmpty(container.Caption) ? container.Subtitle : container.Caption,
                TextAlignment = TileItemContentAlignment.MiddleLeft,
                ItemSize = TileBarItemSize.Wide
            };
            tileBarItem.ItemClick += (s, e) => view.ActivateContainer(container);
            tileBarItem.DropDownOptions.AutoHeight = DefaultBoolean.True;

            if (tileContainer != null && tileContainer.Items.Count > 0)
            {
                var ddContainer = new TileBarDropDownContainer();
                ddContainer.Height = (int) (view.Manager.ContainerControl.Height*0.33f);
                ddContainer.Appearance.BorderColor = Color.FromArgb(37, 116, 169);
                ddContainer.BorderStyle = BorderStyles.Flat;
                var ddTileBar = new TileBar() { ItemSize = 25, Dock = DockStyle.Fill };
                ddTileBar.Orientation = Orientation.Vertical;
                
                ddTileBar.BackColor = this.tileBarNavigation.BackColor;
                ddTileBar.AppearanceItem.Normal.BackColor = Color.FromArgb(37, 116, 169);
                ddTileBar.AppearanceItem.Normal.TextOptions.HAlignment = HorzAlignment.Near;
                ddTileBar.AppearanceItem.Normal.TextOptions.VAlignment = VertAlignment.Center;
                ddTileBar.AppearanceItem.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
                ddTileBar.AppearanceItem.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
                ddTileBar.ScrollMode = TileControlScrollMode.ScrollBar;

                var ddTileGroup = new TileBarGroup();
                ddTileBar.Groups.Add(ddTileGroup);
                foreach (Tile tileItem in tileContainer.Items)
                {
                    if (tileItem == null)
                    {
                        continue;
                    }
                    var childContainer = tileItem.ActivationTarget;
                    var childDocument = tileItem.Document;
                    var menuItem = new TileBarItem() { ItemSize = TileBarItemSize.Wide };

                    if (childContainer != null)
                    {
                        menuItem.Text = String.IsNullOrEmpty(childContainer.Subtitle) ? childContainer.Caption : childContainer.Subtitle;
                        menuItem.ItemClick += (s, e) => view.ActivateContainer(childContainer);
                    }
                    else if (childDocument != null)
                    {
                        menuItem.Text = childDocument.Caption;
                        menuItem.ItemClick += (s, e) => view.ActivateDocument(childDocument);
                    }
                    else
                    {
                        continue;
                    }
                    ddTileGroup.Items.Add(menuItem);
                }
                ddContainer.Controls.Add(ddTileBar);
                tileBarItem.DropDownControl = ddContainer;
            }
            return tileBarItem;
        }
    }
}
