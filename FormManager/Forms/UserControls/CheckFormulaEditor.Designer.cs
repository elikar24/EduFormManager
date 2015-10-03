using System.ComponentModel;
using System.Windows.Forms;

namespace EduFormManager.Forms
{
    partial class CheckFormulaEditor
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
            this.textBoxLineNumbers = new System.Windows.Forms.TextBox();
            this.textBoxEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxLineNumbers
            // 
            this.textBoxLineNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLineNumbers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLineNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxLineNumbers.Location = new System.Drawing.Point(3, 3);
            this.textBoxLineNumbers.Multiline = true;
            this.textBoxLineNumbers.Name = "textBoxLineNumbers";
            this.textBoxLineNumbers.ReadOnly = true;
            this.textBoxLineNumbers.Size = new System.Drawing.Size(33, 237);
            this.textBoxLineNumbers.TabIndex = 1;
            this.textBoxLineNumbers.TabStop = false;
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditor.DetectUrls = false;
            this.textBoxEditor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEditor.Location = new System.Drawing.Point(42, 3);
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(537, 237);
            this.textBoxEditor.TabIndex = 2;
            this.textBoxEditor.Text = "";
            this.textBoxEditor.WordWrap = false;
            this.textBoxEditor.SelectionChanged += new System.EventHandler(this.textBoxEditor_SelectionChanged);
            this.textBoxEditor.TextChanged += new System.EventHandler(this.textBoxEditor_TextChanged);
            this.textBoxEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEditor_KeyDown);
            // 
            // CheckFormulaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.textBoxLineNumbers);
            this.Name = "CheckFormulaEditor";
            this.Size = new System.Drawing.Size(583, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLineNumbers;
        private RichTextBox textBoxEditor;
    }
}
