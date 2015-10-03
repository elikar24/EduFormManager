using System;
using System.Security.Authentication;
using System.Threading.Tasks;
using EduFormManager.Models;
using EduFormManager.Models.Repo;

namespace EduFormManager
{
    class Authentication
    {
        public static Credentials Credentials { get; set; }

        public class AuthenticatedArgs : EventArgs
        {
            public AuthenticatedArgs() { }
            public AuthenticatedArgs(Credentials cred)
            {
                this.Credentials = cred;
            }

            public Credentials Credentials { get; set; }
        }

        public event EventHandler<AuthenticatedArgs> Authenticated;

        public Credentials GetAuthenticated(string login, string password)
        {
            using (var repo = new Repository())
            {
                var cred = repo.GetCredentials(login, password);

                if (cred == null)
                {
                    throw new InvalidCredentialException("Неверный логин или пароль");
                }

                var args = new AuthenticatedArgs {Credentials = cred};
                Credentials = cred;
                OnAuthenticated(args);

                return cred;
            }
        }

        protected virtual void OnAuthenticated(AuthenticatedArgs e)
        {
            var handler = Authenticated;
            if (handler != null) handler.Invoke(this, e);
        }
    }
}
