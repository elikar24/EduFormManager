using System;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryEditMunitControl : XtraBaseControl
    {
        private municipality _munit;
        private XtraDictionaryMunitControl _munitControl;

        public XtraDictionaryEditMunitControl()
        {
            InitializeComponent();

            this.labelError.Text = string.Empty;

            Init();
        }

        public XtraDictionaryEditMunitControl(XtraDictionaryMunitControl parentMunitControl = null)
        {
            InitializeComponent();

            this._munitControl = parentMunitControl;
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

        public XtraDictionaryMunitControl ParentMunitControl
        {
            set
            {
                this._munitControl = value;
                if (value != null)
                    this.Repo = value.Repo;
            }
            get
            {
                return this._munitControl;
            }
        }

        public municipality Municipality
        {
            set
            {
                if (value == null)
                    return;
                this._munit = value;

                this.textBoxDictMunitName.Text = _munit.name;
                this.textBoxDictOperator.Text= _munit.@operator;
                this.textBoxDictRemark.Text = _munit.remark;

                var cred = Repo.GetCredentialSync(_munit.municipality_id, Credentials.Type.Municipality);
                this.textBoxDictLogin.Text = cred != null ? cred.login : string.Empty;
                this.textBoxDictPassword.Text = cred != null ? cred.passwd : string.Empty;
            }
            get
            {
                return _munit;
            }
        }

        public municipality Save()
        {
            _munit.name = this.textBoxDictMunitName.Text.Trim();
            _munit.@operator = this.textBoxDictOperator.Text.Trim();
            _munit.remark = this.textBoxDictRemark.Text.Trim();

            if (_munit.municipality_id == 0)
                Repo.Db.municipalities.Add(_munit);
            Repo.Db.SaveChanges();

            var cred = Repo.GetCredentialSync(_munit.municipality_id, Credentials.Type.Municipality);
            if (cred == null)
            {
                cred = new credential
                {
                    ref_id = _munit.municipality_id,
                    login_type = (int) Credentials.Type.Municipality
                };
                Repo.Db.credentials.Add(cred);
            }
            cred.login = this.textBoxDictLogin.Text.Trim();
            cred.passwd = this.textBoxDictPassword.Text.Trim();

            Repo.Db.SaveChanges();

            this.labelError.Text = string.Empty;
            return _munit;
        }

        public bool CanSave()
        {
            string munitName = this.textBoxDictMunitName.Text.Trim();
            var possibleMunit = Repo.GetMunicipalityByName(munitName).Result;
            var isMunitExist = (possibleMunit != null && munitName != _munit.name);
            if (isMunitExist)
            {
                this.labelError.Text = "Муниципалитет с таким именем уже существует";
                return false;
            }
            bool isFieldsOk = !string.IsNullOrEmpty(munitName);
            if (!isFieldsOk)
            {
                this.labelError.Text = "Проверьте все ли поля заполнены";
                return false;
            }
            string login = this.textBoxDictLogin.Text.Trim();
            string password = this.textBoxDictPassword.Text.Trim();
            if (!string.IsNullOrEmpty(login))
            {
                var cred = Repo.GetCredentialSync(_munit.municipality_id, Credentials.Type.Municipality);
                var credDub = Repo.GetCredentialSync(login);
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
                var munit = this.Save();
                if (this.ParentForm != null) this.ParentForm.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _munitControl.CancelNew();
            if (this.ParentForm != null)
                this.ParentForm.Close();
        }
    }
}
