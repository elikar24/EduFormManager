using System.ComponentModel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms
{
    partial class NavigationBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tileBarNavigation = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupNav = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tileBarNavigation
            // 
            this.tileBarNavigation.AllowDrag = false;
            this.tileBarNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tileBarNavigation.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tileBarNavigation.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tileBarNavigation.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tileBarNavigation.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarNavigation.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarNavigation.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileBarNavigation.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileBarNavigation.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileBarNavigation.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tileBarNavigation.AppearanceItem.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tileBarNavigation.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.tileBarNavigation.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBarNavigation.Groups.Add(this.tileBarGroupNav);
            this.tileBarNavigation.ItemSize = 25;
            this.tileBarNavigation.Location = new System.Drawing.Point(44, 0);
            this.tileBarNavigation.MaxId = 7;
            this.tileBarNavigation.Name = "tileBarNavigation";
            this.tileBarNavigation.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar;
            this.tileBarNavigation.ShowGroupText = false;
            this.tileBarNavigation.Size = new System.Drawing.Size(466, 35);
            this.tileBarNavigation.TabIndex = 0;
            this.tileBarNavigation.Text = "tileBar1";
            // 
            // tileBarGroupNav
            // 
            this.tileBarGroupNav.Name = "tileBarGroupNav";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Image = global::EduFormManager.Properties.Resources.Home_26;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2013";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(35, 35);
            this.simpleButton1.TabIndex = 1;
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tileBarNavigation);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(510, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private TileBar tileBarNavigation;
        private SimpleButton simpleButton1;
        private TileBarGroup tileBarGroupNav;
    }
}
