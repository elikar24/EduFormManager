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

        private IContentContainer _homeContainer;
        
        public IContentContainer Home
        {
            get 
            {
                return _homeContainer;
            }
            set
            {
                _homeContainer = value;
                var view = value.Manager.View as WindowsUIView;
                this.simpleButton1.Click += (s, e) => view.ActivateContainer(_homeContainer);
            } 
        }

        private TileBarItem CreateBarItem(IContentContainer container)
        {
            var view = container.Manager.View as WindowsUIView;
            if (view == null)
            {
                return null;
            }
            var tileBarItem = new TileBarItem()
            {
                Text = String.IsNullOrEmpty(container.Caption) ? container.Subtitle : container.Caption,
                TextAlignment = TileItemContentAlignment.MiddleLeft,
                ItemSize = TileBarItemSize.Wide,
                SuperTip = new SuperToolTip()
            };
            tileBarItem.SuperTip.Items.Add(tileBarItem.Text);
            tileBarItem.ItemClick += (s, e) => view.ActivateContainer(container);
            tileBarItem.DropDownOptions.AutoHeight = DefaultBoolean.True;

            var tileContainer = container as TileContainer;

            if (tileContainer != null && tileContainer.Items.Count > 0)
            {
                var ddContainer = new TileBarDropDownContainer
                {
                    Height = (int) (view.Manager.ContainerControl.Height*0.33f),
                    BorderStyle = BorderStyles.Flat
                };
                ddContainer.Appearance.BorderColor = Color.FromArgb(160,160,160);
                
                var ddTileBar = new TileBar
                {
                    ItemSize = 25,
                    Dock = DockStyle.Fill,
                    Orientation = Orientation.Horizontal,
                    BackColor = this.tileBarNavigation.BackColor
                };
                //ddTileBar.AppearanceItem.Normal.BackColor = Color.FromArgb(37, 116, 169);
                ddTileBar.AppearanceItem.Normal.BackColor = Color.Transparent;
                ddTileBar.AppearanceItem.Normal.ForeColor = Color.FromArgb(59, 59, 59);
                ddTileBar.AppearanceItem.Normal.TextOptions.HAlignment = HorzAlignment.Near;
                ddTileBar.AppearanceItem.Normal.TextOptions.VAlignment = VertAlignment.Center;
                ddTileBar.AppearanceItem.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
                ddTileBar.AppearanceItem.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
                ddTileBar.ScrollMode = TileControlScrollMode.ScrollButtons;

                var ddTileGroup = new TileBarGroup();
                ddTileBar.Groups.Add(ddTileGroup);
                foreach (var item in tileContainer.Items)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    var tile = (Tile)item;
                    var childContainer = tile.ActivationTarget;
                    var childDocument = tile.Document;
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
