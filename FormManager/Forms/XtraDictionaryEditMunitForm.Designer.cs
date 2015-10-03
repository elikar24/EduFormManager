using System.ComponentModel;
using EduFormManager.Forms.UserControls;

namespace EduFormManager.Forms
{
    partial class XtraDictionaryEditMunitForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraDictionaryEditMunitControl1 = new XtraDictionaryEditMunitControl();
            this.SuspendLayout();
            // 
            // xtraDictionaryEditMunitControl1
            // 
            this.xtraDictionaryEditMunitControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xtraDictionaryEditMunitControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.xtraDictionaryEditMunitControl1.Appearance.Options.UseForeColor = true;
            this.xtraDictionaryEditMunitControl1.FormDataSource = null;
            this.xtraDictionaryEditMunitControl1.FormTypeDataSource = null;
            this.xtraDictionaryEditMunitControl1.Municipality = null;
            this.xtraDictionaryEditMunitControl1.Location = new System.Drawing.Point(10, 12);
            this.xtraDictionaryEditMunitControl1.LookAndFeel.SkinName = "Office 2013";
            this.xtraDictionaryEditMunitControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraDictionaryEditMunitControl1.Name = "xtraDictionaryEditMunitControl1";
            this.xtraDictionaryEditMunitControl1.ParentMunitControl = null;
            this.xtraDictionaryEditMunitControl1.Size = new System.Drawing.Size(815, 390);
            this.xtraDictionaryEditMunitControl1.TabIndex = 0;
            this.xtraDictionaryEditMunitControl1.View = null;
            // 
            // XtraDictionaryEditEduForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 416);
            this.Controls.Add(this.xtraDictionaryEditMunitControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "XtraDictionaryEditMunitForm";
            this.ResumeLayout(false);

        }

        #endregion

        private XtraDictionaryEditMunitControl xtraDictionaryEditMunitControl1;
    }
}