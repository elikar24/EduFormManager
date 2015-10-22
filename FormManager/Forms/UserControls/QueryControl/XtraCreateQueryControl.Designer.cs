using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraLayout;
using DevExpress.XtraSpreadsheet;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    partial class XtraCreateQueryControl
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
            this.textBoxCreateQueryName = new System.Windows.Forms.TextBox();
            this.textBoxCreateQueryCell = new System.Windows.Forms.TextBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.spreadsheetControlQueries = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.xtraDictionaryEditQueryControl1 = new EduFormManager.Forms.UserControls.QueryControl.XtraDictionaryEditQueryControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCreateQueryName
            // 
            this.textBoxCreateQueryName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCreateQueryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryBindingSource, "Title", true));
            this.textBoxCreateQueryName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreateQueryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxCreateQueryName.Location = new System.Drawing.Point(18, 556);
            this.textBoxCreateQueryName.Name = "textBoxCreateQueryName";
            this.textBoxCreateQueryName.Size = new System.Drawing.Size(283, 20);
            this.textBoxCreateQueryName.TabIndex = 17;
            // 
            // textBoxCreateQueryCell
            // 
            this.textBoxCreateQueryCell.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCreateQueryCell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryBindingSource, "Content", true));
            this.textBoxCreateQueryCell.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreateQueryCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxCreateQueryCell.Location = new System.Drawing.Point(18, 604);
            this.textBoxCreateQueryCell.Name = "textBoxCreateQueryCell";
            this.textBoxCreateQueryCell.Size = new System.Drawing.Size(283, 20);
            this.textBoxCreateQueryCell.TabIndex = 20;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxForm.DataSource = this.templatedFormDataBindingSource;
            this.comboBoxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Location = new System.Drawing.Point(12, 36);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(295, 23);
            this.comboBoxForm.TabIndex = 22;
            this.comboBoxForm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreateQueryForm_SelectedIndexChanged);
            this.comboBoxForm.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxForm_Format);
            // 
            // spreadsheetControlQueries
            // 
            this.spreadsheetControlQueries.AcceptsTab = false;
            this.spreadsheetControlQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControlQueries.Location = new System.Drawing.Point(323, 36);
            this.spreadsheetControlQueries.LookAndFeel.SkinName = "Office 2013";
            this.spreadsheetControlQueries.Name = "spreadsheetControlQueries";
            this.spreadsheetControlQueries.ReadOnly = true;
            this.spreadsheetControlQueries.Size = new System.Drawing.Size(817, 594);
            this.spreadsheetControlQueries.TabIndex = 23;
            this.spreadsheetControlQueries.Text = "spreadsheetControlQueries";
            this.spreadsheetControlQueries.PopupMenuShowing += new DevExpress.XtraSpreadsheet.PopupMenuShowingEventHandler(this.spreadsheetControlQueries_PopupMenuShowing);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.queryBindingSource;
            this.listBox1.DisplayMember = "title";
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 377);
            this.listBox1.TabIndex = 26;
            this.listBox1.ValueMember = "query_id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.xtraDictionaryEditQueryControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(400, 129);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(311, 241);
            this.flyoutPanel1.TabIndex = 28;
            // 
            // xtraDictionaryEditQueryControl1
            // 
            this.xtraDictionaryEditQueryControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.xtraDictionaryEditQueryControl1.Appearance.Options.UseForeColor = true;
            this.xtraDictionaryEditQueryControl1.ControlType = EduFormManager.Forms.UserControls.XtraBaseControl.Type.Form;
            this.xtraDictionaryEditQueryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraDictionaryEditQueryControl1.FormDataSource = null;
            this.xtraDictionaryEditQueryControl1.FormTypeDataSource = null;
            this.xtraDictionaryEditQueryControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraDictionaryEditQueryControl1.LookAndFeel.SkinName = "Office 2013";
            this.xtraDictionaryEditQueryControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraDictionaryEditQueryControl1.Name = "xtraDictionaryEditQueryControl1";
            this.xtraDictionaryEditQueryControl1.Repo = null;
            this.xtraDictionaryEditQueryControl1.SelectedForm = null;
            this.xtraDictionaryEditQueryControl1.SelectedQuery = null;
            this.xtraDictionaryEditQueryControl1.Size = new System.Drawing.Size(311, 241);
            this.xtraDictionaryEditQueryControl1.TabIndex = 0;
            this.xtraDictionaryEditQueryControl1.View = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spreadsheetControlQueries);
            this.layoutControl1.Controls.Add(this.comboBoxForm);
            this.layoutControl1.Controls.Add(this.textBoxCreateQueryCell);
            this.layoutControl1.Controls.Add(this.textBoxCreateQueryName);
            this.layoutControl1.Controls.Add(this.listBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(816, 306, 567, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1152, 642);
            this.layoutControl1.TabIndex = 29;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1152, 642);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 406);
            this.layoutControlItem1.Text = "Запросы";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(133, 21);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 488);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(299, 134);
            this.layoutControlGroup2.Text = "Быстрое редактирование";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxCreateQueryName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(287, 48);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(287, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(287, 48);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Заголовок запроса";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(133, 21);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxCreateQueryCell;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(287, 48);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(287, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(287, 48);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Ячейка";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(133, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxForm;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(299, 49);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(299, 49);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(299, 49);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Выбрать форму";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(133, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 49);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(299, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spreadsheetControlQueries;
            this.layoutControlItem5.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(821, 622);
            this.layoutControlItem5.Text = "Шаблон";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(133, 21);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(299, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 622);
            // 
            // XtraCreateQueryControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraCreateQueryControl";
            this.Size = new System.Drawing.Size(1152, 642);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxCreateQueryName;
        private TextBox textBoxCreateQueryCell;
        private SpreadsheetControl spreadsheetControlQueries;
        private ListBox listBox1;
        private ComboBox comboBoxForm;
        private FlyoutPanel flyoutPanel1;
        public XtraDictionaryEditQueryControl xtraDictionaryEditQueryControl1;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private EmptySpaceItem emptySpaceItem1;
        private LayoutControlItem layoutControlItem5;
        private SplitterItem splitterItem1;
    }
}
