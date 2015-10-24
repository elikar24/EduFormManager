using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils.Win;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using EduFormManager.Properties;
using Models;
using Models.Repo;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryEduPassportControl : XtraBaseControl, ISupportDocumentActions
    {
        private edu _edu;
        private bool _isManualSelect;

        public XtraDictionaryEduPassportControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();
            InitializeProps();
        }

        private void InitializeProps()
        {
            municipalityBindingSource.DataSourceChanged += municipalityBindingSource_DataSourceChanged;
            eduOrgStatusBindingSource.DataSourceChanged += eduOrgStatusBindingSource_DataSourceChanged;
            eduTypeBindingSource.DataSourceChanged += eduOrgTypeBindingSource_DataSourceChanged;
            eduKindBindingSource.DataSourceChanged += eduOrgKindBindingSource_DataSourceChanged;
            ownershipTypeBindingSource.DataSourceChanged += ownershipTypeBindingSource_DataSourceChanged;

            //this.comboBoxMunit.Click += (sender, args) =>
            //{
            //    this.comboBoxMunit.Enabled = true;
            //};
        }

        void ownershipTypeBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxOwnershipType.Properties.Items.Clear();
            this.comboBoxOwnershipType.Properties.Items.AddRange(ownershipTypeBindingSource.List);
        }

        void eduOrgKindBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxEduKind.Properties.Items.Clear();
            this.comboBoxEduKind.Properties.Items.AddRange(eduKindBindingSource.List);
        }

        void eduOrgTypeBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxEduType.Properties.Items.Clear();
            this.comboBoxEduType.Properties.Items.AddRange(eduTypeBindingSource.List);
        }

        void eduOrgStatusBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxEduStatus.Properties.Items.Clear();
            this.comboBoxEduStatus.Properties.Items.AddRange(eduOrgStatusBindingSource.List);
        }

        void municipalityBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxMunit.Properties.Items.Clear();
            this.comboBoxMunit.Properties.Items.AddRange(municipalityBindingSource.List);
        }

        public List<edu_status> EduStatusDataSource
        {
            set
            {
                eduOrgStatusBindingSource.DataSource = value;
            }
        }

        public List<ownership_type> OwnershipTypeDataSource
        {
            set
            {ownershipTypeBindingSource.DataSource = value;
            }
        }

        public List<activity_type> ActivityTypeDataSource
        {
            set
            {
                activityTypeBindingSource.DataSource = value;
            }
        }

        public List<management_agency> ManagementAgencyDataSource
        {
            set
            {
                managementAgencyBindingSource.DataSource = value;
            }
        }

        public List<management_agency_activity> ManagementAgencyActivityDataSource
        {
            set
            {
                managementAgencyActivityBindingSource.DataSource = value;
            }
        }

        public edu Edu
        {
            get { return _edu; }
            set
            {
                _edu = value;
                this.FillData(_edu);
            }
        }

        private void FillData(edu edu)
        {
            if (edu == null)
            {
                throw new ArgumentNullException("edu", "EduOrg passed to pasport control is null");
            }
            this.comboBoxMunit.SelectedItem = edu.municipality;

            _isManualSelect = false;
            this.checkedComboBoxActivityType.SetEditValue(null);
            foreach (var at in edu.activity_type) 
            {
                this.checkedComboBoxActivityType.Properties.Items[(object)at.activity_type_id].CheckState = CheckState.Checked;
            }
            this.checkedComboBoxManagementAgency.SetEditValue(null);
            foreach (var ma in edu.management_agency)
            {
                this.checkedComboBoxManagementAgency.Properties.Items[(object)ma.management_agency_id].CheckState = CheckState.Checked;
            }
            this.checkedComboBoxManagementAgencyActivity.SetEditValue(null);
            foreach (var maa in edu.management_agency_activity)
            {
                this.checkedComboBoxManagementAgencyActivity.Properties.Items[(object)maa.management_agency_activity_id].CheckState = CheckState.Checked;
            }
            _isManualSelect = true;

            this.comboBoxEduKind.SelectedItem = edu.edu_kind;
            this.comboBoxEduStatus.SelectedItem = edu.edu_status;
            this.comboBoxEduType.SelectedItem = edu.edu_type;
            this.comboBoxOwnershipType.SelectedItem = edu.ownership_type;

            this.dateEditAccreditation.DateTime = edu.accreditation_date;
            this.dateEditEndAccreditation.DateTime = edu.accreditation_end_date;
            this.textBoxAccreditationFrom.Text = edu.accreditation_from;
            this.textBoxAccreditationNum.Text = edu.accreditation_num;
            this.textBoxCode.Text = edu.code;
            this.textBoxDirectorName.Text = edu.director;
            this.textBoxEduName.Text = edu.fullname;
            this.textBoxEduShortname.Text = edu.name;
            this.textBoxEmail.Text = edu.email;

            this.dateEditLicense.DateTime = edu.license_date;
            this.textBoxLicenseFrom.Text = edu.license_from;
            this.textBoxLicenseNum.Text = edu.license_num;
            this.textBoxLink.Text = edu.link;
            this.textBoxOKPOCode.Text = edu.okpo_code;
            this.textBoxPhone.Text = edu.phone;
            this.textBoxPost.Text = edu.post;

            this.checkBoxIsUngraded.Checked = edu.is_ungraded;
            this.checkBox1.Checked = edu.management_agency_has_authority;

            this.numericUpDownBranchCount.Value = edu.branch_num;

            this.textBoxOperator.Text = edu.@operator;
        }

        private void SaveData(edu edu)
        {
            if (edu == null)
            {
                throw new ArgumentNullException("edu", "Edu passed to pasport control is null");
            }
            edu.municipality = (municipality) this.comboBoxMunit.SelectedItem;
            edu.edu_kind = (edu_kind) this.comboBoxEduKind.SelectedItem;
            edu.edu_status = (edu_status) this.comboBoxEduStatus.SelectedItem;
            edu.edu_type = (edu_type) this.comboBoxEduType.SelectedItem;
            edu.ownership_type = (ownership_type) this.comboBoxOwnershipType.SelectedItem;

            edu.accreditation_date = this.dateEditAccreditation.DateTime;
            edu.accreditation_end_date = this.dateEditEndAccreditation.DateTime;
            edu.accreditation_from = this.textBoxAccreditationFrom.Text;
            edu.accreditation_num = textBoxAccreditationNum.Text;
            edu.code = this.textBoxCode.Text;
            edu.director = this.textBoxDirectorName.Text;
            edu.fullname = this.textBoxEduName.Text;
            edu.name = this.textBoxEduShortname.Text;
            edu.email = this.textBoxEmail.Text;

            edu.license_date = this.dateEditLicense.DateTime;
            edu.license_end_date = DateTime.Now;
            edu.license_from = this.textBoxLicenseFrom.Text;
            edu.license_num = textBoxLicenseNum.Text;
            edu.link = this.textBoxLink.Text;
            edu.okpo_code = this.textBoxOKPOCode.Text;
            edu.phone = this.textBoxPhone.Text;
            edu.post = this.textBoxPost.Text;

            edu.is_ungraded = this.checkBoxIsUngraded.Checked;
            edu.management_agency_has_authority = this.checkBox1.Checked;

            edu.branch_num = decimal.ToInt32(this.numericUpDownBranchCount.Value);
            string operatorName = this.textBoxOperator.Text.Trim();
            if (!string.IsNullOrEmpty(operatorName))
                edu.@operator = operatorName;
        }

        public void Save()
        {
            Save(null);
        }
        protected override async void Save(Document doc)
        {
            if (this.CanSave(doc))
            {
                try
                {
                    this.SaveData(_edu);
                    await Repo.SaveChangesAsync();
                    this.ShowFlyoutMessageBox("Информация", "Сохранено.", FlyoutCommand.OK);
                }
                catch (Exception ex)
                {
                    this.ShowFlyoutMessageBox("Ошибка", ex.ToString(), FlyoutCommand.OK);
                }
            }
            else
            {
                this.ShowFlyoutMessageBox("Ошибка", "Проверьте правильно ли все заполнено: поля название, кр. название, тип, статус, вид, муниципалитет", FlyoutCommand.OK);
            }
            
        }
        public bool CanSave()
        {
            return CanSave(null);
        }
        protected override bool CanSave(Document doc)
        {
            return !String.IsNullOrEmpty(this.textBoxEduName.Text) && !String.IsNullOrEmpty(this.textBoxEduShortname.Text)
                && comboBoxEduKind.SelectedItem != null && comboBoxEduStatus.SelectedItem != null && comboBoxEduType.SelectedItem != null
                && comboBoxMunit.SelectedItem != null && comboBoxOwnershipType.SelectedItem != null;
        }

        private void checkedComboBoxManagementAgency_Popup(object sender, EventArgs e)
        {
            PopupContainerForm form = (sender as IPopupControl).PopupWindow as PopupContainerForm;
            CheckedListBoxControl cl = form.Controls[3].Controls[0] as CheckedListBoxControl;
            cl.ItemCheck += checkedComboBoxManagementAgency_ItemCheck;
        }

        private void checkedComboBoxManagementAgency_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isManualSelect && e.State != CheckState.Indeterminate)
            {
                int maId = (int)this.checkedComboBoxManagementAgency.Properties.Items[e.Index].Value;
                var ma = ((List<management_agency>) this.managementAgencyBindingSource.List)
                    .Find(x => x.management_agency_id == maId);
                
                if (e.State == CheckState.Checked)
                {
                    if (!_edu.management_agency.Contains(ma))
                        _edu.management_agency.Add(ma);
                }
                else
                {
                    if (_edu.management_agency.Contains(ma))
                        _edu.management_agency.Remove(ma);
                }
            }
        }

        private void checkedComboBoxManagementAgencyActivity_Popup(object sender, EventArgs e)
        {
            var form = (PopupContainerForm) ((IPopupControl) sender).PopupWindow;
            var cl = (CheckedListBoxControl) form.Controls[3].Controls[0];
            cl.ItemCheck -= checkedComboBoxManagementAgencyActivity_ItemCheck;
            cl.ItemCheck += checkedComboBoxManagementAgencyActivity_ItemCheck;
        }

        private void checkedComboBoxManagementAgencyActivity_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isManualSelect)
            {
                int maaId = (int)this.checkedComboBoxManagementAgencyActivity.Properties.Items[e.Index].Value;
                var maa = ((List<management_agency_activity>) this.managementAgencyActivityBindingSource.List)
                    .Find(x => x.management_agency_activity_id == maaId);
                if (e.State == CheckState.Checked)
                {
                    if (!_edu.management_agency_activity.Contains(maa))
                        _edu.management_agency_activity.Add(maa);
                }
                else
                {
                    if (_edu.management_agency_activity.Contains(maa))
                        _edu.management_agency_activity.Remove(maa);
                }
            }
        }

        private void checkedComboBoxActivityType_Popup(object sender, EventArgs e)
        {
            var form = (PopupContainerForm) ((IPopupControl) sender).PopupWindow;
            var cl = (CheckedListBoxControl) form.Controls[3].Controls[0];
            cl.ItemCheck += checkedComboBoxActivityType_ItemCheck;
        }

        private void checkedComboBoxActivityType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isManualSelect)
            {
                int atId = (int)this.checkedComboBoxActivityType.Properties.Items[e.Index].Value;
                var at = ((List<activity_type>) this.activityTypeBindingSource.List)
                    .Find(x => x.activity_type_id == atId);
                if (e.State == CheckState.Checked)
                {
                    if (!_edu.activity_type.Contains(at))
                        _edu.activity_type.Add(at);
                }
                else
                {
                    if (_edu.activity_type.Contains(at))
                        _edu.activity_type.Remove(at);
                }
            }
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
        }
    }
}
