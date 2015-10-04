using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryEditEduControl : XtraBaseControl
    {
        private edu _edu;
        private XtraDictionaryEduControl _eduControl;

        public XtraDictionaryEditEduControl()
        {
            InitializeComponent();

            this.labelError.Text = string.Empty;

            Init();
        }

        public XtraDictionaryEditEduControl(XtraDictionaryEduControl parentEduControl = null)
        {
            InitializeComponent();

            this._eduControl = parentEduControl;

            Init();
        }

        private void Init()
        {
            this.labelError.Text = string.Empty;
            this.ControlType = Type.Component;
        }

        public override Type ControlType
        {
            get
            {
                return base._controlType;
            }
            set
            {
                this.buttonOk.Visible = (value == Type.Form);
                this.buttonCancel.Visible = (value == Type.Form);
                base._controlType = value;
            }
        }

        public XtraDictionaryEduControl ParentEduControl
        {
            set
            {
                this._eduControl = value;
                if (value != null)
                    this.Repo = value.Repo;
            }
            get
            {
                return this._eduControl;
            }
        }

        public BindingSource EduOrgKindBinding
        {
            set
            {
                this.eduKindBindingSource = value;
            }
        }

        public BindingSource MunicipalityBinding
        {
            set
            {
                this.municipalityBindingSource = value;
            }
        }

        public List<edu_kind> EduKindDataSource
        {
            set
            {
                this.eduKindBindingSource.DataSource = value;
            }
        }

        public override List<municipality> MunicipalityDataSource
        {
            set
            {
                this.municipalityBindingSource.DataSource = value;
            }
        }

        public edu Edu
        {
            set
            {
                if (value == null)
                    return;
                this._edu = value;
                this.comboBoxMunit.SelectedItem = _edu.municipality;
                this.comboBoxEduKind.SelectedItem = _edu.edu_kind;

                this.textBoxDictEduName.Text = _edu.fullname;
                this.textBoxDictEduOperator.Text= _edu.@operator;
                this.textBoxDictEduShortname.Text = _edu.name;

                credential cred = Repo.GetCredential(_edu.edu_id, Credentials.Type.Edu).Result;
                this.textBoxDictLogin.Text = cred != null ? cred.login : string.Empty;
                this.textBoxDictPassword.Text = cred != null ? cred.passwd : string.Empty;
            }
            get
            {
                return _edu;
            }
        }

        public edu Save()
        {
            _edu.municipality = (municipality)comboBoxMunit.SelectedItem;
            _edu.edu_kind = (edu_kind) comboBoxEduKind.SelectedItem;

            _edu.fullname = this.textBoxDictEduName.Text.Trim();
            _edu.name = this.textBoxDictEduShortname.Text.Trim();
            _edu.@operator = this.textBoxDictEduOperator.Text.Trim();

            if (_edu.edu_id == 0)
            {
                Repo.Db.edus.Add(_edu);
                Repo.Db.SaveChanges();
            }

            var cred = Repo.GetCredential(_edu.edu_id, Credentials.Type.Edu).Result;
            if (cred == null)
            {
                cred = new credential
                {
                    ref_id = _edu.edu_id,
                    login_type = (int)Credentials.Type.Edu
                };
                Repo.Db.credentials.Add(cred);
            }
            cred.login = this.textBoxDictLogin.Text.Trim();
            cred.passwd = this.textBoxDictPassword.Text.Trim();

            Repo.Db.SaveChanges();

            this.labelError.Text = string.Empty;
            return _edu;
        }

        public bool CanSave()
        {
            if (_edu == null) return false;
            string eduName = this.textBoxDictEduName.Text.Trim();
            string eduShortName = this.textBoxDictEduShortname.Text.Trim();
            var val1 = (Repo.GetEduByFullname(eduName).Result);
            var val2 = (Repo.GetEduByName(eduShortName).Result);
            bool isEduExist = 
                (val1 != null && val1.edu_id != _edu.edu_id) || 
                (val2 != null && val2.edu_id != _edu.edu_id);
                
            if (isEduExist)
            {
                this.labelError.Text = "ОУ с таким именем уже существует";
                return false;
            }
            bool isFieldsOk = comboBoxEduKind.SelectedItem != null &&
                comboBoxMunit.SelectedItem != null &&
                !string.IsNullOrEmpty(eduName) &&
                !string.IsNullOrEmpty(eduShortName);
            if (!isFieldsOk)
            {
                this.labelError.Text = "Проверьте все ли поля заполнены";
                return false;
            }
            string login = this.textBoxDictLogin.Text.Trim();
            string password = this.textBoxDictPassword.Text.Trim();
            if (!string.IsNullOrEmpty(login))
            {
                var cred = Repo.GetCredential(_edu.edu_id, Credentials.Type.Edu).Result;
                var credDub = Repo.GetCredential(login).Result;
                bool isCredentialsExist = cred == null ? credDub != null :
                    credDub != null && (cred.ref_id != credDub.ref_id || cred.login_type != credDub.login_type);
                if (isCredentialsExist)
                {
                    this.labelError.Text = "Такой логин уже существует";
                    return false;
                }
                if (string.IsNullOrEmpty(password))
                {
                    this.labelError.Text = "Пароль не может быть пустым";
                    return false;
                }
                if (password != this.textBoxDictPasswordRepeated.Text.Trim())
                {
                    this.labelError.Text = "Пароли не совпадают";
                    return false;
                }
            }
            return true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.CanSave())
            {
                var edu = this.Save();
                if (_eduControl != null)
                {
                    _eduControl.RebuildEduTree();
                    _eduControl.SelectEdu(edu);
                }
                var parentForm = this.ParentForm;
                if (parentForm != null) parentForm.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _eduControl.CancelNew();
            if (this.ParentForm != null)
                this.ParentForm.Close();
        }
    }
}
