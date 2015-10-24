namespace Models
{
    public class Credentials
    {
        public enum Type
        {
            Admin = 1,
            Ministry = 2,
            Municipality = 3,
            Edu = 4
        }

        public Credentials(credential cred)
        {
            CredId = cred.credentials_id;
            this.LoginType = (Type) cred.login_type;
        }

        public int CredId { get; set; }
        public int MunitId { get; set; }
        public int EduId { get; set; }

        private string _name;

        public string Name
        {
            get
            {
                switch (this.LoginType)
                {
                    case Type.Edu:
                    case Type.Municipality:
                        return _name;
                    case Type.Admin:
                        return "Администратор";
                    case Type.Ministry:
                        return "Министерство";
                    default:
                        return "";
                }
            }
            set { _name = value; }
        }

        public Type LoginType { get; set; }
        public bool IsAdmin
        {
            get { return LoginType == Type.Admin; }
        }
        public bool IsEdu
        {
            get { return LoginType == Type.Edu; }
        }
        public bool IsMinistry
        {
            get { return LoginType == Type.Ministry; }
        }
        public bool IsMunicipality
        {
            get { return LoginType == Type.Municipality; }
        }
    }
}
