using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using ComboBox = System.Windows.Forms.ComboBox;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraDictionaryFormsControl
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxIsBlocked = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAllformType = new System.Windows.Forms.ComboBox();
            this.dateEditExpire = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxEduKinds = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.treeViewForms = new System.Windows.Forms.TreeView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxEduKinds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.comboBoxIsBlocked);
            this.layoutControl1.Controls.Add(this.textBoxName);
            this.layoutControl1.Controls.Add(this.comboBoxAllformType);
            this.layoutControl1.Controls.Add(this.dateEditExpire);
            this.layoutControl1.Controls.Add(this.checkedListBoxEduKinds);
            this.layoutControl1.Controls.Add(this.treeViewForms);
            this.layoutControl1.Location = new System.Drawing.Point(-2, 1);
            this.layoutControl1.LookAndFeel.SkinName = "Office 2013";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(883, 299, 381, 421);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1103, 559);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxIsBlocked
            // 
            this.comboBoxIsBlocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxIsBlocked.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIsBlocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxIsBlocked.FormattingEnabled = true;
            this.comboBoxIsBlocked.Location = new System.Drawing.Point(855, 179);
            this.comboBoxIsBlocked.Name = "comboBoxIsBlocked";
            this.comboBoxIsBlocked.Size = new System.Drawing.Size(224, 25);
            this.comboBoxIsBlocked.TabIndex = 8;
            this.comboBoxIsBlocked.SelectedIndexChanged += new System.EventHandler(this.comboBoxIsBlocked_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "name", true));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxName.Location = new System.Drawing.Point(617, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(462, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // comboBoxAllformType
            // 
            this.comboBoxAllformType.DataSource = this.formTypeBindingSource;
            this.comboBoxAllformType.DisplayMember = "name";
            this.comboBoxAllformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAllformType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAllformType.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAllformType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxAllformType.FormattingEnabled = true;
            this.comboBoxAllformType.Location = new System.Drawing.Point(855, 139);
            this.comboBoxAllformType.Name = "comboBoxAllformType";
            this.comboBoxAllformType.Size = new System.Drawing.Size(224, 25);
            this.comboBoxAllformType.TabIndex = 6;
            this.comboBoxAllformType.ValueMember = "Id";
            this.comboBoxAllformType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllformType_SelectedIndexChanged);
            // 
            // dateEditExpire
            // 
            this.dateEditExpire.CalendarFont = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditExpire.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dateEditExpire.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dateEditExpire.CustomFormat = "dd MMMM";
            this.dateEditExpire.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formBindingSource, "submission_date", true));
            this.dateEditExpire.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEditExpire.Location = new System.Drawing.Point(855, 103);
            this.dateEditExpire.Name = "dateEditExpire";
            this.dateEditExpire.Size = new System.Drawing.Size(224, 25);
            this.dateEditExpire.TabIndex = 7;
            // 
            // checkedListBoxEduKinds
            // 
            this.checkedListBoxEduKinds.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxEduKinds.Appearance.Options.UseFont = true;
            this.checkedListBoxEduKinds.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkedListBoxEduKinds.CheckOnClick = true;
            this.checkedListBoxEduKinds.DataSource = this.eduKindBindingSource;
            this.checkedListBoxEduKinds.DisplayMember = "name";
            this.checkedListBoxEduKinds.Location = new System.Drawing.Point(617, 223);
            this.checkedListBoxEduKinds.Name = "checkedListBoxEduKinds";
            this.checkedListBoxEduKinds.Size = new System.Drawing.Size(462, 312);
            this.checkedListBoxEduKinds.TabIndex = 2;
            this.checkedListBoxEduKinds.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxEduKinds_ItemCheck);
            // 
            // treeViewForms
            // 
            this.treeViewForms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewForms.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewForms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.treeViewForms.LineColor = System.Drawing.Color.DimGray;
            this.treeViewForms.Location = new System.Drawing.Point(24, 55);
            this.treeViewForms.Name = "treeViewForms";
            this.treeViewForms.Size = new System.Drawing.Size(565, 480);
            this.treeViewForms.TabIndex = 5;
            this.treeViewForms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewForms_AfterSelect);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1103, 559);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.CustomizationFormText = "Выбранная форма";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(593, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(490, 539);
            this.layoutControlGroup2.Text = "Выбранная форма";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkedListBoxEduKinds;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(466, 316);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxName;
            this.layoutControlItem2.CustomizationFormText = "Название формы";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(466, 48);
            this.layoutControlItem2.Text = "Название формы";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(235, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEditExpire;
            this.layoutControlItem4.CustomizationFormText = "Срок сдачи до";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(466, 25);
            this.layoutControlItem4.Text = "Срок сдачи до";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(235, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.comboBoxAllformType;
            this.layoutControlItem5.CustomizationFormText = "Тип формы";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(466, 25);
            this.layoutControlItem5.Text = "Тип формы";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(235, 21);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.comboBoxIsBlocked;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(466, 25);
            this.layoutControlItem6.Text = "По истечении срока сдачи форма";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(235, 21);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 109);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(466, 15);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 149);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(466, 19);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.CustomizationFormText = "Формы";
            this.layoutControlGroup3.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(593, 539);
            this.layoutControlGroup3.Text = "Формы";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.treeViewForms;
            this.layoutControlItem3.CustomizationFormText = "Формы";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(569, 484);
            this.layoutControlItem3.Text = "Формы";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 73);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(466, 11);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // XtraDictionaryFormsControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDictionaryFormsControl";
            this.Size = new System.Drawing.Size(1098, 638);
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
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxEduKinds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBoxControl checkedListBoxEduKinds;
        private TextBox textBoxName;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private TreeView treeViewForms;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlGroup layoutControlGroup3;
        private LayoutControlItem layoutControlItem1;
        private ComboBox comboBoxAllformType;
        private DateTimePicker dateEditExpire;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem5;
        private ComboBox comboBoxIsBlocked;
        private LayoutControlItem layoutControlItem6;
        private EmptySpaceItem emptySpaceItem2;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem3;
    }
}
