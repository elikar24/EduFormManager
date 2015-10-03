using System.ComponentModel;
using DevExpress.XtraRichEdit;

namespace EduFormManager.Forms.UserControls.FormulaEdit
{
    partial class FormulaEditControl
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
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl.Appearance.Text.Font = new System.Drawing.Font("Courier New", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richEditControl.Appearance.Text.Options.UseFont = true;
            this.richEditControl.Appearance.Text.Options.UseTextOptions = true;
            this.richEditControl.Appearance.Text.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.EnableToolTips = true;
            this.richEditControl.Location = new System.Drawing.Point(0, 0);
            this.richEditControl.LookAndFeel.SkinName = "Office 2013";
            this.richEditControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.richEditControl.Name = "richEditControl";
            //this.richEditControl.Options.Comments.Author = "";
            this.richEditControl.Size = new System.Drawing.Size(433, 267);
            this.richEditControl.TabIndex = 0;
            this.richEditControl.Views.DraftView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.richEditControl.Views.SimpleView.AllowDisplayLineNumbers = true;
            this.richEditControl.Views.SimpleView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.richEditControl.Views.SimpleView.WordWrap = false;
            // 
            // FormulaEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl);
            this.Name = "FormulaEditControl";
            this.Size = new System.Drawing.Size(433, 267);
            this.ResumeLayout(false);

        }

        #endregion

        private RichEditControl richEditControl;
    }
}
