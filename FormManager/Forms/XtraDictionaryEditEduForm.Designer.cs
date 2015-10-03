using System.ComponentModel;
using EduFormManager.Forms.UserControls;

namespace EduFormManager.Forms
{
    partial class XtraDictionaryEditEduForm
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
            this.xtraDictionaryEditEduControl1 = new XtraDictionaryEditEduControl();
            this.SuspendLayout();
            // 
            // xtraDictionaryEditEduControl1
            // 
            this.xtraDictionaryEditEduControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xtraDictionaryEditEduControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.xtraDictionaryEditEduControl1.Appearance.Options.UseForeColor = true;
            this.xtraDictionaryEditEduControl1.FormDataSource = null;
            this.xtraDictionaryEditEduControl1.FormTypeDataSource = null;
            this.xtraDictionaryEditEduControl1.Edu = null;
            this.xtraDictionaryEditEduControl1.Location = new System.Drawing.Point(10, 12);
            this.xtraDictionaryEditEduControl1.LookAndFeel.SkinName = "Office 2013";
            this.xtraDictionaryEditEduControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraDictionaryEditEduControl1.Name = "xtraDictionaryEditEduControl1";
            this.xtraDictionaryEditEduControl1.ParentEduControl = null;
            this.xtraDictionaryEditEduControl1.Size = new System.Drawing.Size(815, 390);
            this.xtraDictionaryEditEduControl1.TabIndex = 0;
            this.xtraDictionaryEditEduControl1.View = null;
            this.xtraDictionaryEditEduControl1.Load += new System.EventHandler(this.xtraDictionaryEditEduControl1_Load);
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
            this.Controls.Add(this.xtraDictionaryEditEduControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "XtraDictionaryEditEduForm";
            this.ResumeLayout(false);

        }

        #endregion

        private XtraDictionaryEditEduControl xtraDictionaryEditEduControl1;
    }
}