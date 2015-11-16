namespace EduFormManager.Forms.UserControls
{
    partial class XtraNavPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.officeNavigationBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeNavigationBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.officeNavigationBar1.AutoSize = false;
            this.officeNavigationBar1.BackColor = System.Drawing.Color.Transparent;
            this.officeNavigationBar1.ItemSkinning = true;
            this.officeNavigationBar1.Location = new System.Drawing.Point(36, 0);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(644, 26);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Image = global::EduFormManager.Properties.Resources.Home_26;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 23);
            this.simpleButton1.TabIndex = 0;
            // 
            // XtraNavPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.officeNavigationBar1);
            this.MaximumSize = new System.Drawing.Size(0, 26);
            this.Name = "XtraNavPane";
            this.Size = new System.Drawing.Size(683, 25);
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}
