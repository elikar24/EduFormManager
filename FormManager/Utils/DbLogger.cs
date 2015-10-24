using System;
using System.Threading.Tasks;using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    static class DbLogger
    {
        public static async Task LogAsync(Credentials user, LogActionType action)
        {
            using (var repo = new Repository())
            {
                var log = repo.Create<edu_log>();
                log.action_id = (int) action;
                log.created = DateTime.Now;
                log.message = user.Name;
                await repo.SaveChangesAsync();
            }
        }

        public static Task LogLoginAsync(Credentials user)
        {
            return LogAsync(user, LogActionType.Login);
        }

        public static Task LogLogoutAsync(Credentials user)
        {
            return LogAsync(user, LogActionType.Logout);
        }
    }
}
