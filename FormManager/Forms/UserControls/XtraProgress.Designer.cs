using System.ComponentModel;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraProgress
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
            this.regularProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.marqueeProgressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.regularProgressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // regularProgressBar
            // 
            this.regularProgressBar.EditValue = 50;
            this.regularProgressBar.Location = new System.Drawing.Point(3, 64);
            this.regularProgressBar.Name = "regularProgressBar";
            this.regularProgressBar.Properties.Appearance.ForeColor2 = System.Drawing.Color.Transparent;
            this.regularProgressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.regularProgressBar.Properties.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.regularProgressBar.Properties.LookAndFeel.SkinName = "Office 2013";
            this.regularProgressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.regularProgressBar.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.regularProgressBar.Properties.StartColor = System.Drawing.SystemColors.ControlLightLight;
            this.regularProgressBar.Size = new System.Drawing.Size(378, 22);
            this.regularProgressBar.TabIndex = 0;
            // 
            // marqueeProgressBar
            // 
            this.marqueeProgressBar.EditValue = 0;
            this.marqueeProgressBar.Location = new System.Drawing.Point(4, 92);
            this.marqueeProgressBar.Name = "marqueeProgressBar";
            this.marqueeProgressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.marqueeProgressBar.Properties.LookAndFeel.SkinName = "Office 2013";
            this.marqueeProgressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.marqueeProgressBar.Size = new System.Drawing.Size(377, 22);
            this.marqueeProgressBar.TabIndex = 1;
            // 
            // XtraProgress
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.marqueeProgressBar);
            this.Controls.Add(this.regularProgressBar);
            this.DoubleBuffered = true;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraProgress";
            this.Size = new System.Drawing.Size(384, 177);
            ((System.ComponentModel.ISupportInitialize)(this.regularProgressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBarControl regularProgressBar;
        private MarqueeProgressBarControl marqueeProgressBar;

    }
}
