using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraDictionaryMunitControl
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMunicipality = new DevExpress.XtraEditors.ListBoxControl();
            this.munitEditControl = new EduFormManager.Forms.UserControls.XtraDictionaryEditMunitControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxMunitEdus = new DevExpress.XtraEditors.ListBoxControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelSavedStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMunicipality)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMunitEdus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 117);
            this.label9.TabIndex = 4;
            this.label9.Text = "Образовательные организации, принадлежащие данному муниципалитету.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 59);
            this.label1.TabIndex = 22;
            this.label1.Text = "Вы не можете удалить запись с данным муниципалитетом, пока этот список не пуст.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxMunicipality
            // 
            this.listBoxMunicipality.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMunicipality.Appearance.Options.UseFont = true;
            this.listBoxMunicipality.DataSource = this.municipalityBindingSource;
            this.listBoxMunicipality.DisplayMember = "name";
            this.listBoxMunicipality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMunicipality.Location = new System.Drawing.Point(0, 0);
            this.listBoxMunicipality.LookAndFeel.SkinName = "Office 2013";
            this.listBoxMunicipality.Name = "listBoxMunicipality";
            this.listBoxMunicipality.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
            this.listBoxMunicipality.Size = new System.Drawing.Size(401, 586);
            this.listBoxMunicipality.TabIndex = 21;
            this.listBoxMunicipality.SelectedIndexChanged += new System.EventHandler(this.listBoxMunicipality_SelectedIndexChanged);
            // 
            // munitEditControl
            // 
            this.munitEditControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.munitEditControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.munitEditControl.Appearance.Options.UseForeColor = true;
            this.tableLayoutPanel1.SetColumnSpan(this.munitEditControl, 2);
            this.munitEditControl.ControlType = EduFormManager.Forms.UserControls.XtraBaseControl.Type.Component;
            this.munitEditControl.FormDataSource = null;
            this.munitEditControl.FormTypeDataSource = null;
            this.munitEditControl.Location = new System.Drawing.Point(3, 3);
            this.munitEditControl.LookAndFeel.SkinName = "Office 2013";
            this.munitEditControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.munitEditControl.Municipality = null;
            this.munitEditControl.Name = "munitEditControl";
            this.munitEditControl.ParentMunitControl = null;
            this.munitEditControl.Repo = null;
            this.munitEditControl.Size = new System.Drawing.Size(591, 404);
            this.munitEditControl.TabIndex = 24;
            this.munitEditControl.View = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.munitEditControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMunitEdus, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 586);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // listBoxMunitEdus
            // 
            this.listBoxMunitEdus.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMunitEdus.Appearance.Options.UseFont = true;
            this.listBoxMunitEdus.DataSource = this.eduBindingSource;
            this.listBoxMunitEdus.DisplayMember = "name";
            this.listBoxMunitEdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMunitEdus.Location = new System.Drawing.Point(301, 413);
            this.listBoxMunitEdus.Name = "listBoxMunitEdus";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxMunitEdus, 2);
            this.listBoxMunitEdus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMunitEdus.Size = new System.Drawing.Size(293, 170);
            this.listBoxMunitEdus.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listBoxMunitEdus.TabIndex = 25;
            this.listBoxMunitEdus.ValueMember = "edu_id";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.listBoxMunicipality);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1010, 586);
            this.splitContainerControl1.SplitterPosition = 401;
            this.splitContainerControl1.TabIndex = 26;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelSavedStatus
            // 
            this.labelSavedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSavedStatus.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSavedStatus.Appearance.Image = global::EduFormManager.Properties.Resources.Attention_26;
            this.labelSavedStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSavedStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelSavedStatus.Location = new System.Drawing.Point(3, 595);
            this.labelSavedStatus.Name = "labelSavedStatus";
            this.labelSavedStatus.Size = new System.Drawing.Size(1007, 26);
            this.labelSavedStatus.TabIndex = 27;
            this.labelSavedStatus.Text = "labelControl1";
            // 
            // XtraDictionaryMunitControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSavedStatus);
            this.Controls.Add(this.splitContainerControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDictionaryMunitControl";
            this.Size = new System.Drawing.Size(1016, 624);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMunicipality)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMunitEdus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label9;
        private ListBoxControl listBoxMunicipality;
        private Label label1;
        private XtraDictionaryEditMunitControl munitEditControl;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBoxControl listBoxMunitEdus;
        private SplitContainerControl splitContainerControl1;
        private LabelControl labelSavedStatus;
    }
}
