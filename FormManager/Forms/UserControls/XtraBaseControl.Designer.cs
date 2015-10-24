using System.ComponentModel;
using System.Windows.Forms;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraBaseControl
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
            this.components = new System.ComponentModel.Container();
            this.eduTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templatedFormDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eduKindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eduTypeBindingSource
            // 
            this.eduTypeBindingSource.DataSource = typeof(Models.edu_type);
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataSource = typeof(Models.query);
            // 
            // eduBindingSource
            // 
            this.eduBindingSource.DataSource = typeof(Models.edu);
            // 
            // municipalityBindingSource
            // 
            this.municipalityBindingSource.DataSource = typeof(Models.municipality);
            // 
            // templatedFormDataBindingSource
            // 
            this.templatedFormDataBindingSource.DataSource = typeof(Models.templated_form_data);
            // 
            // eduKindBindingSource
            // 
            this.eduKindBindingSource.DataSource = typeof(Models.edu_kind);
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(Models.message);
            // 
            // formTypeBindingSource
            // 
            this.formTypeBindingSource.DataSource = typeof(Models.form_type);
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataSource = typeof(Models.form);
            // 
            // XtraBaseControl
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraBaseControl";
            this.Size = new System.Drawing.Size(996, 440);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected BindingSource eduTypeBindingSource;
        protected BindingSource queryBindingSource;
        protected BindingSource eduBindingSource;
        protected BindingSource municipalityBindingSource;
        protected BindingSource templatedFormDataBindingSource;
        protected BindingSource eduKindBindingSource;
        protected BindingSource messageBindingSource;
        protected BindingSource formTypeBindingSource;
        protected BindingSource formBindingSource;

    }
}
