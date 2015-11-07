using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraSpreadsheet;
using EduFormManager.Forms.UserControls.FormulaEdit;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraDictionaryTemplateControl
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
            this.spreadsheetTemplate = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.listBoxTemplatedForm = new System.Windows.Forms.ListBox();
            this.comboBoxRemainingTemplatedForm = new System.Windows.Forms.ComboBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.formulaEditControl1 = new EduFormManager.Forms.UserControls.FormulaEdit.FormulaEditControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemForm = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTemplate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetTemplate
            // 
            this.spreadsheetTemplate.Location = new System.Drawing.Point(276, 12);
            this.spreadsheetTemplate.LookAndFeel.SkinName = "Seven Classic";
            this.spreadsheetTemplate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.spreadsheetTemplate.Name = "spreadsheetTemplate";
            this.spreadsheetTemplate.Size = new System.Drawing.Size(895, 260);
            this.spreadsheetTemplate.TabIndex = 18;
            this.spreadsheetTemplate.Text = "spreadsheetControl2";
            this.spreadsheetTemplate.Unit = DevExpress.Office.DocumentUnit.Point;
            this.spreadsheetTemplate.PopupMenuShowing += new DevExpress.XtraSpreadsheet.PopupMenuShowingEventHandler(this.spreadsheetTemplate_PopupMenuShowing);
            this.spreadsheetTemplate.ActiveSheetChanged += new DevExpress.Spreadsheet.ActiveSheetChangedEventHandler(this.spreadsheetTemplate_ActiveSheetChanged);
            this.spreadsheetTemplate.Leave += new System.EventHandler(this.spreadsheetTemplate_Leave);
            // 
            // listBoxTemplatedForm
            // 
            this.listBoxTemplatedForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTemplatedForm.DataSource = this.templatedFormDataBindingSource;
            this.listBoxTemplatedForm.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTemplatedForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.listBoxTemplatedForm.FormattingEnabled = true;
            this.listBoxTemplatedForm.HorizontalScrollbar = true;
            this.listBoxTemplatedForm.ItemHeight = 17;
            this.listBoxTemplatedForm.Location = new System.Drawing.Point(12, 85);
            this.listBoxTemplatedForm.Name = "listBoxTemplatedForm";
            this.listBoxTemplatedForm.Size = new System.Drawing.Size(248, 187);
            this.listBoxTemplatedForm.TabIndex = 17;
            this.listBoxTemplatedForm.SelectedIndexChanged += new System.EventHandler(this.listBoxTemplatedForm_SelectedIndexChanged);
            this.listBoxTemplatedForm.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxTemplatedForm_Format);
            // 
            // comboBoxRemainingTemplatedForm
            // 
            this.comboBoxRemainingTemplatedForm.DataSource = this.formBindingSource;
            this.comboBoxRemainingTemplatedForm.DisplayMember = "name";
            this.comboBoxRemainingTemplatedForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemainingTemplatedForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRemainingTemplatedForm.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRemainingTemplatedForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxRemainingTemplatedForm.Location = new System.Drawing.Point(12, 36);
            this.comboBoxRemainingTemplatedForm.Name = "comboBoxRemainingTemplatedForm";
            this.comboBoxRemainingTemplatedForm.Size = new System.Drawing.Size(248, 25);
            this.comboBoxRemainingTemplatedForm.TabIndex = 16;
            this.comboBoxRemainingTemplatedForm.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemainingTemplatedForm_SelectedIndexChanged);
            this.comboBoxRemainingTemplatedForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRemainingTemplatedForm_KeyPress);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.formulaEditControl1);
            this.layoutControl1.Controls.Add(this.spreadsheetTemplate);
            this.layoutControl1.Controls.Add(this.comboBoxRemainingTemplatedForm);
            this.layoutControl1.Controls.Add(this.listBoxTemplatedForm);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(737, 295, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1183, 512);
            this.layoutControl1.TabIndex = 22;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // formulaEditControl1
            // 
            this.formulaEditControl1.Location = new System.Drawing.Point(12, 288);
            this.formulaEditControl1.Name = "formulaEditControl1";
            this.formulaEditControl1.Size = new System.Drawing.Size(1159, 212);
            this.formulaEditControl1.TabIndex = 19;
            this.formulaEditControl1.Leave += new System.EventHandler(this.formulaEditControl1_Leave);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemForm,
            this.layoutControlItemTemplate,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.splitterItem1,
            this.splitterItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1183, 512);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemForm
            // 
            this.layoutControlItemForm.Control = this.comboBoxRemainingTemplatedForm;
            this.layoutControlItemForm.CustomizationFormText = "Формы без шаблона";
            this.layoutControlItemForm.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemForm.Name = "layoutControlItemForm";
            this.layoutControlItemForm.Size = new System.Drawing.Size(252, 49);
            this.layoutControlItemForm.Text = "Формы без шаблона";
            this.layoutControlItemForm.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemForm.TextSize = new System.Drawing.Size(145, 21);
            // 
            // layoutControlItemTemplate
            // 
            this.layoutControlItemTemplate.Control = this.listBoxTemplatedForm;
            this.layoutControlItemTemplate.CustomizationFormText = "Формы с шаблоном";
            this.layoutControlItemTemplate.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItemTemplate.Name = "layoutControlItemTemplate";
            this.layoutControlItemTemplate.Size = new System.Drawing.Size(252, 215);
            this.layoutControlItemTemplate.Text = "Формы с шаблоном";
            this.layoutControlItemTemplate.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemTemplate.TextSize = new System.Drawing.Size(145, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spreadsheetTemplate;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(264, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(899, 264);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.formulaEditControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 276);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1163, 216);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 264);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(1163, 12);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(252, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(12, 264);
            // 
            // XtraDictionaryTemplateControl
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDictionaryTemplateControl";
            this.Size = new System.Drawing.Size(1183, 512);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetTemplate;
        private ListBox listBoxTemplatedForm;
        private ComboBox comboBoxRemainingTemplatedForm;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItemForm;
        private LayoutControlItem layoutControlItemTemplate;
        private LayoutControlItem layoutControlItem4;
        private FormulaEditControl formulaEditControl1;
        private LayoutControlItem layoutControlItem3;
        private SplitterItem splitterItem1;
        private SplitterItem splitterItem2;
    }
}
