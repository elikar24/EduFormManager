using System;
using System.Threading.Tasks;
using EduFormManager.Models;

namespace EduFormManager.Utils
{
    static class DbLogHelper
    {
        public static void Log(Credentials user, LogActionType action)
        {
            using (var db = new Entities())
            {
                db.edu_log.Add(new edu_log()
                {
                    action_id = (int)action,
                    created = DateTime.Now,
                    message = user.Name
                });
                db.SaveChanges();
            }
        }

        public static Task LogAsync(Credentials user, LogActionType action)
        {
            return Task.Run(() => Log(user, action));
        }

        public static void LogLogin(Credentials user)
        {
            Log(user, LogActionType.Login);
        }

        public static Task LogLoginAsync(Credentials user)
        {
            return Task.Run(() => LogLogin(user));
        }

        public static void LogLogout(Credentials user)
        {
            Log(user, LogActionType.Logout);
        }

        public static Task LogLogoutAsync(Credentials user)
        {
            return Task.Run(() => LogLogout(user));
        }
    }
}
