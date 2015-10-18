using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraDictionaryEduPassportControl
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.comboBoxEduStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateEditEndAccreditation = new DevExpress.XtraEditors.DateEdit();
            this.dateEditAccreditation = new DevExpress.XtraEditors.DateEdit();
            this.textBoxAccreditationFrom = new System.Windows.Forms.TextBox();
            this.dateEditLicense = new DevExpress.XtraEditors.DateEdit();
            this.textBoxAccreditationNum = new System.Windows.Forms.TextBox();
            this.textBoxLicenseFrom = new System.Windows.Forms.TextBox();
            this.textBoxLicenseNum = new System.Windows.Forms.TextBox();
            this.textBoxOperator = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxIsUngraded = new System.Windows.Forms.CheckBox();
            this.checkedComboBoxActivityType = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.activityTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOwnershipType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.numericUpDownBranchCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxDirectorName = new System.Windows.Forms.TextBox();
            this.checkedComboBoxManagementAgencyActivity = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.managementAgencyActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkedComboBoxManagementAgency = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.managementAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxOKPOCode = new System.Windows.Forms.TextBox();
            this.comboBoxEduKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.comboBoxEduType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxMunit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textBoxEduShortname = new System.Windows.Forms.TextBox();
            this.textBoxEduName = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup3 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.eduOrgStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownershipTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup2 = new DevExpress.XtraLayout.TabbedControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndAccreditation.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndAccreditation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccreditation.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccreditation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLicense.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLicense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxActivityType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOwnershipType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranchCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxManagementAgencyActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementAgencyActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxManagementAgency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementAgencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMunit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduOrgStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxCode.Location = new System.Drawing.Point(795, 26);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(208, 20);
            this.textBoxCode.TabIndex = 4;
            // 
            // comboBoxEduStatus
            // 
            this.comboBoxEduStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEduStatus.EditValue = "<Null>";
            this.comboBoxEduStatus.Location = new System.Drawing.Point(795, 0);
            this.comboBoxEduStatus.Name = "comboBoxEduStatus";
            this.comboBoxEduStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEduStatus.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEduStatus.Properties.AutoComplete = false;
            this.comboBoxEduStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEduStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEduStatus.Size = new System.Drawing.Size(208, 22);
            this.comboBoxEduStatus.StyleController = this.layoutControl1;
            this.comboBoxEduStatus.TabIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.dateEditEndAccreditation);
            this.layoutControl1.Controls.Add(this.dateEditAccreditation);
            this.layoutControl1.Controls.Add(this.textBoxAccreditationFrom);
            this.layoutControl1.Controls.Add(this.dateEditLicense);
            this.layoutControl1.Controls.Add(this.textBoxAccreditationNum);
            this.layoutControl1.Controls.Add(this.textBoxLicenseFrom);
            this.layoutControl1.Controls.Add(this.textBoxLicenseNum);
            this.layoutControl1.Controls.Add(this.textBoxOperator);
            this.layoutControl1.Controls.Add(this.checkBox1);
            this.layoutControl1.Controls.Add(this.textBoxPhone);
            this.layoutControl1.Controls.Add(this.textBoxCode);
            this.layoutControl1.Controls.Add(this.checkBoxIsUngraded);
            this.layoutControl1.Controls.Add(this.checkedComboBoxActivityType);
            this.layoutControl1.Controls.Add(this.comboBoxOwnershipType);
            this.layoutControl1.Controls.Add(this.numericUpDownBranchCount);
            this.layoutControl1.Controls.Add(this.textBoxDirectorName);
            this.layoutControl1.Controls.Add(this.checkedComboBoxManagementAgencyActivity);
            this.layoutControl1.Controls.Add(this.textBoxEmail);
            this.layoutControl1.Controls.Add(this.checkedComboBoxManagementAgency);
            this.layoutControl1.Controls.Add(this.textBoxOKPOCode);
            this.layoutControl1.Controls.Add(this.comboBoxEduKind);
            this.layoutControl1.Controls.Add(this.textBoxLink);
            this.layoutControl1.Controls.Add(this.textBoxPost);
            this.layoutControl1.Controls.Add(this.comboBoxEduType);
            this.layoutControl1.Controls.Add(this.comboBoxEduStatus);
            this.layoutControl1.Controls.Add(this.comboBoxMunit);
            this.layoutControl1.Controls.Add(this.textBoxEduShortname);
            this.layoutControl1.Controls.Add(this.textBoxEduName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(644, 663, 1003, 434);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1032, 603);
            this.layoutControl1.TabIndex = 47;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateEditEndAccreditation
            // 
            this.dateEditEndAccreditation.EditValue = null;
            this.dateEditEndAccreditation.Location = new System.Drawing.Point(807, 557);
            this.dateEditEndAccreditation.Name = "dateEditEndAccreditation";
            this.dateEditEndAccreditation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndAccreditation.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndAccreditation.Size = new System.Drawing.Size(184, 22);
            this.dateEditEndAccreditation.StyleController = this.layoutControl1;
            this.dateEditEndAccreditation.TabIndex = 57;
            // 
            // dateEditAccreditation
            // 
            this.dateEditAccreditation.EditValue = null;
            this.dateEditAccreditation.Location = new System.Drawing.Point(807, 531);
            this.dateEditAccreditation.Name = "dateEditAccreditation";
            this.dateEditAccreditation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAccreditation.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAccreditation.Size = new System.Drawing.Size(184, 22);
            this.dateEditAccreditation.StyleController = this.layoutControl1;
            this.dateEditAccreditation.TabIndex = 50;
            // 
            // textBoxAccreditationFrom
            // 
            this.textBoxAccreditationFrom.Location = new System.Drawing.Point(807, 507);
            this.textBoxAccreditationFrom.Name = "textBoxAccreditationFrom";
            this.textBoxAccreditationFrom.Size = new System.Drawing.Size(184, 20);
            this.textBoxAccreditationFrom.TabIndex = 49;
            // 
            // dateEditLicense
            // 
            this.dateEditLicense.EditValue = null;
            this.dateEditLicense.Location = new System.Drawing.Point(807, 531);
            this.dateEditLicense.Name = "dateEditLicense";
            this.dateEditLicense.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditLicense.Properties.Appearance.Options.UseFont = true;
            this.dateEditLicense.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditLicense.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditLicense.Size = new System.Drawing.Size(184, 22);
            this.dateEditLicense.StyleController = this.layoutControl1;
            this.dateEditLicense.TabIndex = 53;
            // 
            // textBoxAccreditationNum
            // 
            this.textBoxAccreditationNum.Location = new System.Drawing.Point(807, 483);
            this.textBoxAccreditationNum.Name = "textBoxAccreditationNum";
            this.textBoxAccreditationNum.Size = new System.Drawing.Size(184, 20);
            this.textBoxAccreditationNum.TabIndex = 48;
            // 
            // textBoxLicenseFrom
            // 
            this.textBoxLicenseFrom.Location = new System.Drawing.Point(807, 507);
            this.textBoxLicenseFrom.Name = "textBoxLicenseFrom";
            this.textBoxLicenseFrom.Size = new System.Drawing.Size(184, 20);
            this.textBoxLicenseFrom.TabIndex = 52;
            // 
            // textBoxLicenseNum
            // 
            this.textBoxLicenseNum.Location = new System.Drawing.Point(807, 483);
            this.textBoxLicenseNum.Name = "textBoxLicenseNum";
            this.textBoxLicenseNum.Size = new System.Drawing.Size(184, 20);
            this.textBoxLicenseNum.TabIndex = 51;
            // 
            // textBoxOperator
            // 
            this.textBoxOperator.Location = new System.Drawing.Point(795, 422);
            this.textBoxOperator.Name = "textBoxOperator";
            this.textBoxOperator.Size = new System.Drawing.Size(208, 20);
            this.textBoxOperator.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(795, 322);
            this.checkBox1.MaximumSize = new System.Drawing.Size(24, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(24, 20);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxPhone.Location = new System.Drawing.Point(795, 174);
            this.textBoxPhone.Mask = "(9999) 000-000";
            this.textBoxPhone.MaximumSize = new System.Drawing.Size(0, 20);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(208, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // checkBoxIsUngraded
            // 
            this.checkBoxIsUngraded.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxIsUngraded.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsUngraded.Checked = true;
            this.checkBoxIsUngraded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsUngraded.Location = new System.Drawing.Point(795, 398);
            this.checkBoxIsUngraded.MaximumSize = new System.Drawing.Size(24, 0);
            this.checkBoxIsUngraded.Name = "checkBoxIsUngraded";
            this.checkBoxIsUngraded.Size = new System.Drawing.Size(24, 20);
            this.checkBoxIsUngraded.TabIndex = 38;
            this.checkBoxIsUngraded.UseVisualStyleBackColor = true;
            // 
            // checkedComboBoxActivityType
            // 
            this.checkedComboBoxActivityType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedComboBoxActivityType.Location = new System.Drawing.Point(795, 372);
            this.checkedComboBoxActivityType.Name = "checkedComboBoxActivityType";
            this.checkedComboBoxActivityType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxActivityType.Properties.DataSource = this.activityTypeBindingSource;
            this.checkedComboBoxActivityType.Properties.DisplayMember = "name";
            this.checkedComboBoxActivityType.Properties.SelectAllItemVisible = false;
            this.checkedComboBoxActivityType.Properties.ShowButtons = false;
            this.checkedComboBoxActivityType.Properties.ShowPopupCloseButton = false;
            this.checkedComboBoxActivityType.Properties.ValueMember = "activity_type_id";
            this.checkedComboBoxActivityType.Size = new System.Drawing.Size(208, 22);
            this.checkedComboBoxActivityType.StyleController = this.layoutControl1;
            this.checkedComboBoxActivityType.TabIndex = 17;
            this.checkedComboBoxActivityType.Popup += new System.EventHandler(this.checkedComboBoxActivityType_Popup);
            // 
            // activityTypeBindingSource
            // 
            this.activityTypeBindingSource.DataSource = typeof(EduFormManager.Models.activity_type);
            // 
            // comboBoxOwnershipType
            // 
            this.comboBoxOwnershipType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxOwnershipType.EditValue = "<Null>";
            this.comboBoxOwnershipType.Location = new System.Drawing.Point(795, 346);
            this.comboBoxOwnershipType.Name = "comboBoxOwnershipType";
            this.comboBoxOwnershipType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOwnershipType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxOwnershipType.Properties.AutoComplete = false;
            this.comboBoxOwnershipType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOwnershipType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxOwnershipType.Size = new System.Drawing.Size(208, 22);
            this.comboBoxOwnershipType.StyleController = this.layoutControl1;
            this.comboBoxOwnershipType.TabIndex = 16;
            // 
            // numericUpDownBranchCount
            // 
            this.numericUpDownBranchCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownBranchCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.numericUpDownBranchCount.Location = new System.Drawing.Point(795, 246);
            this.numericUpDownBranchCount.Name = "numericUpDownBranchCount";
            this.numericUpDownBranchCount.Size = new System.Drawing.Size(208, 23);
            this.numericUpDownBranchCount.TabIndex = 13;
            // 
            // textBoxDirectorName
            // 
            this.textBoxDirectorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDirectorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxDirectorName.Location = new System.Drawing.Point(795, 126);
            this.textBoxDirectorName.Name = "textBoxDirectorName";
            this.textBoxDirectorName.Size = new System.Drawing.Size(208, 20);
            this.textBoxDirectorName.TabIndex = 8;
            // 
            // checkedComboBoxManagementAgencyActivity
            // 
            this.checkedComboBoxManagementAgencyActivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedComboBoxManagementAgencyActivity.Location = new System.Drawing.Point(795, 296);
            this.checkedComboBoxManagementAgencyActivity.Name = "checkedComboBoxManagementAgencyActivity";
            this.checkedComboBoxManagementAgencyActivity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxManagementAgencyActivity.Properties.DataSource = this.managementAgencyActivityBindingSource;
            this.checkedComboBoxManagementAgencyActivity.Properties.DisplayMember = "name";
            this.checkedComboBoxManagementAgencyActivity.Properties.SelectAllItemVisible = false;
            this.checkedComboBoxManagementAgencyActivity.Properties.ShowButtons = false;
            this.checkedComboBoxManagementAgencyActivity.Properties.ShowPopupCloseButton = false;
            this.checkedComboBoxManagementAgencyActivity.Properties.ValueMember = "management_agency_activity_id";
            this.checkedComboBoxManagementAgencyActivity.Size = new System.Drawing.Size(208, 22);
            this.checkedComboBoxManagementAgencyActivity.StyleController = this.layoutControl1;
            this.checkedComboBoxManagementAgencyActivity.TabIndex = 15;
            this.checkedComboBoxManagementAgencyActivity.Popup += new System.EventHandler(this.checkedComboBoxManagementAgencyActivity_Popup);
            // 
            // managementAgencyActivityBindingSource
            // 
            this.managementAgencyActivityBindingSource.DataSource = typeof(EduFormManager.Models.management_agency_activity);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEmail.Location = new System.Drawing.Point(795, 198);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // checkedComboBoxManagementAgency
            // 
            this.checkedComboBoxManagementAgency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedComboBoxManagementAgency.Location = new System.Drawing.Point(795, 270);
            this.checkedComboBoxManagementAgency.Name = "checkedComboBoxManagementAgency";
            this.checkedComboBoxManagementAgency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxManagementAgency.Properties.DataSource = this.managementAgencyBindingSource;
            this.checkedComboBoxManagementAgency.Properties.DisplayMember = "name";
            this.checkedComboBoxManagementAgency.Properties.SelectAllItemVisible = false;
            this.checkedComboBoxManagementAgency.Properties.ShowButtons = false;
            this.checkedComboBoxManagementAgency.Properties.ShowPopupCloseButton = false;
            this.checkedComboBoxManagementAgency.Properties.ValueMember = "management_agency_id";
            this.checkedComboBoxManagementAgency.Size = new System.Drawing.Size(208, 22);
            this.checkedComboBoxManagementAgency.StyleController = this.layoutControl1;
            this.checkedComboBoxManagementAgency.TabIndex = 14;
            this.checkedComboBoxManagementAgency.Popup += new System.EventHandler(this.checkedComboBoxManagementAgency_Popup);
            // 
            // managementAgencyBindingSource
            // 
            this.managementAgencyBindingSource.DataSource = typeof(EduFormManager.Models.management_agency);
            // 
            // textBoxOKPOCode
            // 
            this.textBoxOKPOCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOKPOCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOKPOCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxOKPOCode.Location = new System.Drawing.Point(795, 50);
            this.textBoxOKPOCode.Name = "textBoxOKPOCode";
            this.textBoxOKPOCode.Size = new System.Drawing.Size(208, 20);
            this.textBoxOKPOCode.TabIndex = 5;
            // 
            // comboBoxEduKind
            // 
            this.comboBoxEduKind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEduKind.EditValue = "<Null>";
            this.comboBoxEduKind.Location = new System.Drawing.Point(795, 74);
            this.comboBoxEduKind.Name = "comboBoxEduKind";
            this.comboBoxEduKind.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEduKind.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEduKind.Properties.AutoComplete = false;
            this.comboBoxEduKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEduKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEduKind.Size = new System.Drawing.Size(208, 22);
            this.comboBoxEduKind.StyleController = this.layoutControl1;
            this.comboBoxEduKind.TabIndex = 6;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(795, 222);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(208, 20);
            this.textBoxLink.TabIndex = 12;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxPost.Location = new System.Drawing.Point(795, 150);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(208, 20);
            this.textBoxPost.TabIndex = 9;
            // 
            // comboBoxEduType
            // 
            this.comboBoxEduType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEduType.EditValue = "<Null>";
            this.comboBoxEduType.Location = new System.Drawing.Point(795, 100);
            this.comboBoxEduType.Name = "comboBoxEduType";
            this.comboBoxEduType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEduType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEduType.Properties.AutoComplete = false;
            this.comboBoxEduType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEduType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEduType.Size = new System.Drawing.Size(208, 22);
            this.comboBoxEduType.StyleController = this.layoutControl1;
            this.comboBoxEduType.TabIndex = 7;
            // 
            // comboBoxMunit
            // 
            this.comboBoxMunit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxMunit.EditValue = "<Null>";
            this.comboBoxMunit.Location = new System.Drawing.Point(795, -74);
            this.comboBoxMunit.Name = "comboBoxMunit";
            this.comboBoxMunit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMunit.Properties.Appearance.Options.UseFont = true;
            this.comboBoxMunit.Properties.AutoComplete = false;
            this.comboBoxMunit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMunit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxMunit.Size = new System.Drawing.Size(208, 22);
            this.comboBoxMunit.StyleController = this.layoutControl1;
            this.comboBoxMunit.TabIndex = 0;
            this.comboBoxMunit.TabStop = false;
            // 
            // textBoxEduShortname
            // 
            this.textBoxEduShortname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEduShortname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEduShortname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEduShortname.Location = new System.Drawing.Point(795, -24);
            this.textBoxEduShortname.Name = "textBoxEduShortname";
            this.textBoxEduShortname.Size = new System.Drawing.Size(208, 20);
            this.textBoxEduShortname.TabIndex = 2;
            // 
            // textBoxEduName
            // 
            this.textBoxEduName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEduName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEduName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBoxEduName.Location = new System.Drawing.Point(795, -48);
            this.textBoxEduName.Name = "textBoxEduName";
            this.textBoxEduName.Size = new System.Drawing.Size(208, 20);
            this.textBoxEduName.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceTabPage.Header.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceTabPage.Header.Options.UseFont = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem6,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem23,
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27,
            this.tabbedControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, -86);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1015, 689);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.comboBoxMunit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem1.Text = "Муниципалитет";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.textBoxEduName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem2.Text = "Наименование образовательной организации";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.textBoxEduShortname;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem3.Text = "Наименование в АИС РОС";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.comboBoxEduStatus;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem4.Text = "Статус образовательной организации";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.textBoxCode;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem5.Text = "Код образовательной организации";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.comboBoxEduKind;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem7.Text = "Вид образовательной организации";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.comboBoxEduType;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem8.Text = "Тип государственного (муниципального) учреждения";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem15.Control = this.textBoxDirectorName;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem15.Text = "ФИО директора образовательного учреждения (полностью)";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem16.Control = this.textBoxPost;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 224);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem16.Text = "Почтовый адрес образовательного учреждения";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.textBoxOKPOCode;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem6.Text = "Код ОКПО";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.Control = this.textBoxPhone;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 248);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem17.Text = "Телефон образовательного учреждения (код города, номер телефона)";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.Control = this.textBoxEmail;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 272);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem18.Text = "Адрес электронной почты образовательного учреждения";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem19.Control = this.textBoxLink;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 296);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem19.Text = "Адрес сайта образовательного учреждения";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem20.Control = this.numericUpDownBranchCount;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 320);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem20.Text = "Количество филиалов";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem21.Control = this.checkedComboBoxManagementAgency;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 344);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem21.Text = "В учреждении создан орган государственно-общественного управления";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem22.Control = this.checkedComboBoxManagementAgencyActivity;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 370);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem22.Text = "Орган государственно-общественного управления принимает участие в разработке и ут" +
    "верждении";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem23.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem23.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.layoutControlItem23.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.layoutControlItem23.Control = this.checkBox1;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 396);
            this.layoutControlItem23.MinSize = new System.Drawing.Size(742, 24);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem23.Text = "Орган государственно-общественного управления (совет) обладает полномочиями по ра" +
    "спределению средств стимулирующей части ФОТ";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem24.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem24.Control = this.comboBoxOwnershipType;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 420);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem24.Text = "Форма собственности (в зависимости от учредителя)";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem25.Control = this.checkedComboBoxActivityType;
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 446);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(995, 26);
            this.layoutControlItem25.Text = "Виды деятельности в соответствии с ОКВЭД";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem26.Control = this.checkBoxIsUngraded;
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 472);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem26.Text = "Учреждение является малокомплектным";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem27.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem27.Control = this.textBoxOperator;
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 496);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(995, 24);
            this.layoutControlItem27.Text = "Оператор";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(780, 15);
            // 
            // tabbedControlGroup3
            // 
            this.tabbedControlGroup3.Location = new System.Drawing.Point(0, 520);
            this.tabbedControlGroup3.Name = "tabbedControlGroup3";
            this.tabbedControlGroup3.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup3.SelectedTabPageIndex = 0;
            this.tabbedControlGroup3.Size = new System.Drawing.Size(995, 149);
            this.tabbedControlGroup3.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup4});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(971, 100);
            this.layoutControlGroup2.Text = "Лицензия";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textBoxLicenseNum;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(971, 24);
            this.layoutControlItem9.Text = "Номер лицензии";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.textBoxLicenseFrom;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(971, 24);
            this.layoutControlItem10.Text = "Кем выдана";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dateEditLicense;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(971, 52);
            this.layoutControlItem11.Text = "Дата выдачи";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem29});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(971, 100);
            this.layoutControlGroup4.Text = "Аккредитация";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.textBoxAccreditationNum;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(971, 24);
            this.layoutControlItem12.Text = "Номер аккредитации";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textBoxAccreditationFrom;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(971, 24);
            this.layoutControlItem13.Text = "Кем выдана";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.dateEditAccreditation;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(971, 26);
            this.layoutControlItem14.Text = "Дата выдачи";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(780, 15);
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.dateEditEndAccreditation;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(971, 26);
            this.layoutControlItem29.Text = "Действительно до";
            this.layoutControlItem29.TextSize = new System.Drawing.Size(780, 15);
            // 
            // eduOrgStatusBindingSource
            // 
            this.eduOrgStatusBindingSource.DataSource = typeof(EduFormManager.Models.edu_status);
            // 
            // ownershipTypeBindingSource
            // 
            this.ownershipTypeBindingSource.DataSource = typeof(EduFormManager.Models.ownership_type);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 319);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(612, 141);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(588, 94);
            // 
            // tabbedControlGroup2
            // 
            this.tabbedControlGroup2.Location = new System.Drawing.Point(0, 200);
            this.tabbedControlGroup2.Name = "tabbedControlGroup2";
            this.tabbedControlGroup2.SelectedTabPage = null;
            this.tabbedControlGroup2.SelectedTabPageIndex = -1;
            this.tabbedControlGroup2.Size = new System.Drawing.Size(612, 119);
            // 
            // XtraDictionaryEduPassportControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraDictionaryEduPassportControl";
            this.Size = new System.Drawing.Size(1032, 603);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndAccreditation.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndAccreditation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccreditation.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccreditation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLicense.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditLicense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxActivityType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOwnershipType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranchCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxManagementAgencyActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementAgencyActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxManagementAgency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementAgencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEduType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMunit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduOrgStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public TextBox textBoxEduName;
        public TextBox textBoxEduShortname;
        private BindingSource eduOrgStatusBindingSource;
        private ComboBoxEdit comboBoxEduStatus;
        private ComboBoxEdit comboBoxMunit;
        public TextBox textBoxCode;
        public TextBox textBoxOKPOCode;
        private ComboBoxEdit comboBoxEduKind;
        private ComboBoxEdit comboBoxEduType;
        private ComboBoxEdit comboBoxOwnershipType;
        private CheckBox checkBoxIsUngraded;
        public TextBox textBoxDirectorName;
        public TextBox textBoxPost;
        private CheckBox checkBox1;
        public TextBox textBoxEmail;
        private NumericUpDown numericUpDownBranchCount;
        private BindingSource ownershipTypeBindingSource;
        private BindingSource activityTypeBindingSource;
        private BindingSource managementAgencyBindingSource;
        private BindingSource managementAgencyActivityBindingSource;
        private MaskedTextBox textBoxPhone;
        private CheckedComboBoxEdit checkedComboBoxActivityType;
        private CheckedComboBoxEdit checkedComboBoxManagementAgencyActivity;
        private CheckedComboBoxEdit checkedComboBoxManagementAgency;
        private TextBox textBoxLink;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem5;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem15;
        private LayoutControlItem layoutControlItem16;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem17;
        private LayoutControlItem layoutControlItem18;
        private LayoutControlItem layoutControlItem19;
        private TabbedControlGroup tabbedControlGroup1;
        private LayoutControlGroup layoutControlGroup3;
        private TabbedControlGroup tabbedControlGroup2;
        private TextBox textBoxOperator;
        private LayoutControlItem layoutControlItem20;
        private LayoutControlItem layoutControlItem21;
        private LayoutControlItem layoutControlItem22;
        private LayoutControlItem layoutControlItem23;
        private LayoutControlItem layoutControlItem24;
        private LayoutControlItem layoutControlItem25;
        private LayoutControlItem layoutControlItem26;
        private LayoutControlItem layoutControlItem27;
        private DateEdit dateEditAccreditation;
        private TextBox textBoxAccreditationFrom;
        private DateEdit dateEditLicense;
        private TextBox textBoxAccreditationNum;
        private TextBox textBoxLicenseFrom;
        private TextBox textBoxLicenseNum;
        private TabbedControlGroup tabbedControlGroup3;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlGroup layoutControlGroup4;
        private LayoutControlItem layoutControlItem12;
        private LayoutControlItem layoutControlItem13;
        private LayoutControlItem layoutControlItem14;
        private DateEdit dateEditEndAccreditation;
        private LayoutControlItem layoutControlItem29;
    }
}
