using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EduFormManager.Models.Repo
{
    public class Repository : IDisposable
    {
        private readonly Entities _db;

        private struct FormCount
        {
            public int id;
            public long ok;
            public long expired;
            public long errors;
            public long expired_errors;
        }

        public Repository()
        {
            _db = new Entities();
            _db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public void Dispose()
        {
            if (_db != null)
                _db.Dispose();
        }

        public Entities Db { get { return _db; } }

        #region auth methods

        public Credentials GetCredentials(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            var cred = _db.credentials.SingleOrDefault(e => e.login == login && e.passwd == password);
            if (cred != null)
            {
                var credentials = new Credentials(cred);
                if (credentials.IsEdu || credentials.IsAdmin)
                {
                    var edu = _db.edus.Single(e => e.edu_id == cred.ref_id);
                    credentials.EduId = edu.edu_id;
                    credentials.Name = edu.name;
                }
                else if (credentials.IsMunicipality)
                {
                    var munit = _db.municipalities.Single(e => e.municipality_id == cred.ref_id);
                    credentials.MunitId = munit.municipality_id;
                    credentials.Name = munit.name;
                }
                return credentials;
            }
            return null;
        }

        public Task<credential> GetCredential(int refId, Credentials.Type type)
        {
            return _db.credentials.FirstOrDefaultAsync(t => t.ref_id == refId && t.login_type == (int)type);
        }

        public credential GetCredentialSync(int refId, Credentials.Type type)
        {
            return _db.credentials.FirstOrDefault(t => t.ref_id == refId && t.login_type == (int)type);
        }

        public Task<credential> GetCredential(int id)
        {
            return _db.credentials.FirstOrDefaultAsync(t => t.credentials_id == id);
        }

        public Task<credential> GetCredential(string login)
        {
            return _db.credentials.FirstOrDefaultAsync(t => t.login == login);
        }

        public credential GetCredentialSync(string login)
        {
            return _db.credentials.FirstOrDefault(t => t.login == login);
        }

        public credential GetCredentialSync(int id)
        {
            return _db.credentials.FirstOrDefault(t => t.credentials_id == id);
        }

        #endregion

        #region colorize form data methods

        public static long[] GetStatusCount(DbContext db, string query)
        {
            var res = new long[5];
            try
            {
                db.Database.Connection.Open();
                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = query;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            res[0] = (long)reader["all"];
                            res[1] = (long)reader["errors"];
                            res[2] = (long)reader["expired"];
                            res[3] = (long)reader["expired_errors"];
                            res[4] = (long)reader["ok"];
                        }
                    }
                }
            }
            finally
            {
                if (db.Database.Connection.State == ConnectionState.Open)
                    db.Database.Connection.Close();
            }
            return res;
        }

        public static long[] GetStatusCountForEdu(DbContext db, int eduId, FormType type, bool isArchive)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                                        count(1) as all,
                                        count(case when fd.status = 0 then 1 end) as ok,
                                        count(case when fd.status = 1 then 1 end) as expired,
                                        count(case when fd.status = 2 then 1 end) as errors,
                                        count(case when fd.status = 3 then 1 end) as expired_errors
                                        from edu_form_data fd
                                        join edu eo on eo.edu_id = fd.edu_id
                                        join form f on f.form_id = fd.form_id
                                        where
                                        eo.edu_id = {0} and 
                                        f.form_type_id = {1} and 
                                        date_part('year'::text, fd.send_date) {2}
                                        group by eo.edu_id", eduId, (int)type, isArchive ? "<" + year : "=" + year);
            return GetStatusCount(db, query);
        }

        public static long[] GetStatusCountForMunicipality(DbContext db, int munitId, bool isArchive)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                                        count(1) as all,
                                        count(case when fd.status = 0 then 1 end) as ok,
                                        count(case when fd.status = 1 then 1 end) as expired,
                                        count(case when fd.status = 2 then 1 end) as errors,
                                        count(case when fd.status = 3 then 1 end) as expired_errors
                                        from municipality_form_data fd
                                        join municipality m on m.municipality_id = fd.municipality_id
                                        where
                                        m.municipality_id = {0} and
                                        date_part('year'::text, fd.send_date) {1}
                                        group by m.municipality_id", munitId, isArchive ? "<" + year : "=" + year);
            return GetStatusCount(db, query);
        }

        private static Dictionary<int, Status> GetDict(DbContext db, string query)
        {
            var dict = new Dictionary<int, Status>();
            try
            {
                db.Database.Connection.Open();
                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = query;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["id"];
                            var ok = (long)reader["ok"];
                            var expired = (long)reader["expired"];
                            var errors = (long)reader["errors"];
                            var expired_errors = (long)reader["expired_errors"];

                            var status = Status.Default;

                            if (ok > 0 && expired == 0 && errors == 0 && expired_errors == 0)
                                status = Status.OK;
                            else if (errors > expired && errors > expired_errors)
                                status = Status.WithErrors;
                            else if (expired > errors && expired > expired_errors)
                                status = Status.Expired;
                            else if (expired_errors > expired && expired_errors > errors)
                                status = Status.WithErrors | Status.Expired;
                            else if (ok != 0 && (expired !=0 || errors != 0 || expired_errors != 0))
                                status = Status.Unknown;
                            dict.Add(id, status);
                        }
                    }
                }
            }
            finally
            {
                if (db.Database.Connection.State == ConnectionState.Open)
                    db.Database.Connection.Close();
            }

            return dict;
        }

        public static Dictionary<int, Status> GetStatusForMunicipalities(DbContext db, bool isArchive = false)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                            eo.municipality_id as id,
                            count(case when fd.status = 0 then 1 end) as ok,
                            count(case when fd.status = 1 then 1 end) as expired,
                            count(case when fd.status = 2 then 1 end) as errors,
                            count(case when fd.status = 3 then 1 end) as expired_errors
                            from edu_form_data fd
                            join edu eo on eo.edu_id = fd.edu_id
                            where
                            date_part('year'::text, fd.send_date) {0} 
                            group by eo.municipality_id", isArchive ? "<" + year : "=" + year);
            return GetDict(db, query);
        }

        public static Dictionary<int, Status> GetStatusForEduKinds(DbContext db, int munitId, bool isArchive = false)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                                        eo.edu_kind_id as id,
                                        count(case when fd.status = 0 then 1 end) as ok,
                                        count(case when fd.status = 1 then 1 end) as expired,
                                        count(case when fd.status = 2 then 1 end) as errors,
                                        count(case when fd.status = 3 then 1 end) as expired_errors
                                        from edu_form_data fd
                                        join edu eo on eo.edu_id = fd.edu_id
                                        where
                                        eo.municipality_id = {0} and
                                        date_part('year'::text, fd.send_date) {1}
                                        group by eo.edu_kind_id", munitId, isArchive ? "<" + year : "=" + year);
            return GetDict(db, query);
        }

        public static Dictionary<int, Status> GetStatusForEdus(DbContext db, int munitId, int kindId, bool isArchive = false)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                                        eo.edu_id as id,
                                        count(case when fd.status = 0 then 1 end) as ok,
                                        count(case when fd.status = 1 then 1 end) as expired,
                                        count(case when fd.status = 2 then 1 end) as errors,
                                        count(case when fd.status = 3 then 1 end) as expired_errors
                                        from edu_form_data fd
                                        join edu eo on eo.edu_id = fd.edu_id
                                        where
                                        eo.municipality_id = {0} and 
                                        eo.edu_kind_id = {1} AND
                                        date_part('year'::text, fd.send_date) {2}
                                        group by eo.edu_id", munitId, kindId, isArchive ? "<" + year : "=" + year);
            return GetDict(db, query);
        }

        public static Dictionary<int, Status> GetStatusFormunicipalities(DbContext db, bool isArchive = false)
        {
            var year = DateTime.Now.Year;
            var query = string.Format(@"select
                                        m.municipality_id as id,
                                        count(1) as all,
                                        count(case when fd.status = 0 then 1 end) as ok,
                                        count(case when fd.status = 1 then 1 end) as expired,
                                        count(case when fd.status = 2 then 1 end) as errors,
                                        count(case when fd.status = 3 then 1 end) as expired_errors
                                        from municipality_form_data fd
                                        join municipality m on m.municipality_id = fd.municipality_id
                                        where
                                        date_part('year'::text, fd.send_date) {0}
                                        group by m.municipality_id", isArchive ? "<" + year : "=" + year);
            return GetDict(db, query);
        }

        #endregion

        #region formdata methods

        public Task<edu_form_data> GetEduFormDataById(int id)
        {
            return _db.edu_form_data.SingleOrDefaultAsync(t => t.id == id);
        }

        public Task<municipality_form_data> GetMunitFormDataById(int id)
        {
            return _db.municipality_form_data.SingleOrDefaultAsync(t => t.id == id);
        }

        public Task<edu_form_data> FindEduFormData(int formId, int eduId, int year)
        {
            return _db.edu_form_data.FirstOrDefaultAsync(t =>
                t.edu_id == eduId
                && t.form_id == formId
                && t.send_date.Year == year);
        }

        public Task<municipality_form_data> FindMunicipalityFormData(int formId, int munitId, int year)
        {
            return _db.municipality_form_data.FirstOrDefaultAsync(t =>
                t.municipality_id == munitId
                && t.form_id == formId
                && t.send_date.Year == year);
        }

        public Task<List<edu>> GetEdusHaveFormData(int formId, int year)
        {
            return
                _db.edu_form_data.Where(t => t.form_id == formId && t.send_date.Year == year)
                    .Select(t => t.edu)
                    .Distinct()
                    .ToListAsync();
        }

        public Task<List<edu>> GetEdusHaveFormData(int formId, int year, int munitId)
        {
            return
                _db.edu_form_data.Where(
                t => t.form_id == formId && t.send_date.Year == year && t.edu.municipality_id == munitId)
                    .Select(t => t.edu)
                    .Distinct()
                    .ToListAsync();
        }

        public Task<edu> GetEduHaveFormData(int formId, int year, int eduId)
        {
            return
                _db.edu_form_data.Where(
                t => t.form_id == formId && t.send_date.Year == year && t.edu_id == eduId)
                    .Select(t => t.edu)
                    .Distinct().FirstOrDefaultAsync();
        }

        #endregion

        #region query methods

        public Task<List<query>> GetQueries(int credId, int formId)
        {
            return _db.queries.Where(t => t.credentials_id == credId && t.form_id == formId)
                .OrderBy(t => t.title)
                .ToListAsync();
        }
        #endregion

        #region stats methods

        public Task<List<t_form_statistics>> GetFormStatistics()
        {
            return Task.Run(() =>
            {
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_stats_view();");
                return Db.t_form_statistics.AsNoTracking()
                .OrderBy(t => t.munit_name)
                .ThenBy(t => t.org_shortname)
                    .ToList();
            });
        }

        public Task<List<t_form_statistics>> GetFormStatistics(int munitId)
        {
            return Task.Run(() =>
            {
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_stats_view();");
                return Db.t_form_statistics.AsNoTracking()
                    .Where(t => t.munit_id == munitId)
                    .OrderBy(t => t.munit_name)
                    .ThenBy(t => t.org_shortname)
                    .ToList();
            });
        }

        public Task<List<t_summary_form_statistics>> GetSummaryFormStatistics()
        {
            return Task.Run(() =>
            {
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_summary_stats_view();");
                return Db.t_summary_form_statistics.AsNoTracking()
                        .OrderBy(t => t.municipality_title)
                        .ToList();
            });
        }

        public Task<List<t_summary_form_statistics>> GetSummaryFormStatistics(int munitId)
        {
            return Task.Run(() =>
            {
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_summary_stats_view();");
                return Db.t_summary_form_statistics.AsNoTracking()
                    .Where(t => t.municipality_id == munitId)
                    .OrderBy(t => t.municipality_title)
                    .ToList();
            });
        }

        public Task<List<t_detailed_form_statistics>> GetDetailedFormStatistics(int year = 0)
        {
            return Task.Run(() =>
            {
                var currYear = year == 0 ? DateTime.Now.Year : year;
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_detailed_stats_view(@p0);", currYear);
                return Db.t_detailed_form_statistics.AsNoTracking()
                    .OrderBy(t => t.municipality)
                    .ThenBy(t => t.edu_name)
                    .ThenBy(t => t.form)
                    .ToList();
            });
        }

        public Task<List<t_detailed_form_statistics>> GetDetailedFormStatistics(int munitId, int year)
        {
            return Task.Run(() =>
            {
                var currYear = year == 0 ? DateTime.Now.Year : year;
                Db.Database.ExecuteSqlCommand("SELECT * FROM update_detailed_stats_view(@p0);", currYear);
                return Db.t_detailed_form_statistics.AsNoTracking()
                    .Where(t => t.municipality_id == munitId)
                    .OrderBy(t => t.municipality)
                    .ThenBy(t => t.edu_name)
                    .ThenBy(t => t.form)
                    .ToList();
            });
        }

        #endregion

        #region templates methods

        public Task<List<form>> GetFormsWithoutTemplates()
        {
            return _db.forms.Where(t => t.templated_form_data == null)
                .OrderBy(t => t.name)
                .ToListAsync();
        }

        public Task<List<templated_form_data>> GetTemplates()
        {
            return _db.templated_form_data.OrderBy(t => t.form.name).ToListAsync();
        }

        public Task<List<templated_form_data>> GetTemplatesForMunicipality(int munitId)
        {
            var kinds = from e in _db.edus
                        join m in _db.municipalities on e.municipality_id equals m.municipality_id
                        where m.municipality_id == munitId
                        select e.edu_kind;

            var templates = from t in _db.templated_form_data
                            where kinds.Any(k => k.forms.Contains(t.form))
                            orderby t.form.name
                            select t;

            return templates.ToListAsync();
        }

        public Task<List<templated_form_data>> GetTemplatesForEdu(int eduId)
        {
            return Task.Run(() =>
            {
                var templates = _db.edus.Single(t => t.edu_id == eduId)
                    .edu_kind.forms.Select(t => t.templated_form_data);
                return templates
                    .OrderBy(t => t.form.name)
                    .ToList();
            });
        }

        #endregion

        #region municipality formula

        public Task<mm_regular__summary_form> GetMunicipalityFormulaByMunicipalityForm(int formId)
        {
            return _db.mm_regular__summary_form.SingleOrDefaultAsync(t => t.summary_form_id == formId);
        }

        #endregion

        #region form methods

        public Task<List<form>> GetForms()
        {
            return _db.forms.OrderBy(t => t.name).ToListAsync();
        }

        public Task<List<form>> GetFormsByType(FormType type, bool withTemplatesOnly = false)
        {
            var query = _db.forms.Where(t => t.form_type_id == (int) type);
            if (withTemplatesOnly)
                query = query.Where(t => t.templated_form_data != null);
            return query.OrderBy(t => t.name).ToListAsync();
        }

        public Task<List<form>> GetFormsByEduKind(int kindId)
        {
            var query = from f in _db.forms
                        where f.edu_kind.Select(t => t.edu_kind_id).Contains(kindId)
                        select f;
            return query.ToListAsync();
        }

        public Task<List<form_type>> GetFormTypes()
        {
            return _db.form_type.OrderBy(t => t.form_type_id).ToListAsync();
        }

        #endregion

        #region edu methods 

        public Task<List<edu_kind>> GetEduKinds()
        {
            return _db.edu_kind.OrderBy(t => t.name).ToListAsync();
        }

        public Task<List<edu>> GetEdus()
        {
            return _db.edus.OrderBy(t => t.name).ToListAsync();
        }

        public Task<List<edu>> GetEdus(int munitId)
        {
            return _db.edus.Where(t => t.municipality_id == munitId)
                .OrderBy(t => t.name)
                .ToListAsync();
        }

        public Task<edu> GetEduByName(string name)
        {
            return _db.edus.SingleOrDefaultAsync(t => t.name == name);
        }

        public Task<edu> GetEduByFullname(string name)
        {
            return _db.edus.SingleOrDefaultAsync(t => t.fullname == name);
        }

        public Task<edu> GetEdu(int id)
        {
            return _db.edus.FirstOrDefaultAsync(t => t.edu_id == id);
        }

        public Task<municipality> GetMunicipalityByName(string name)
        {
            return _db.municipalities.SingleOrDefaultAsync(t => t.name == name);
        }

        public Task<municipality> GetMunicipality(int id)
        {
            return _db.municipalities.SingleOrDefaultAsync(t => t.municipality_id == id);
        }

        public Task<List<municipality>> GetMunicipalities()
        {
            return _db.municipalities.OrderBy(t => t.name).ToListAsync();
        }

        #endregion

        #region common

        public Task<int> GetUnreadMessagesCount()
        {
            return _db.messages.CountAsync(t => t.is_viewed == false);
        }

        public Task<document_format> GetDocumentFormat_(string name)
        {
            return Db.document_format.FirstOrDefaultAsync(t => t.name == name);
        }

        public Task<List<message>> GetMessages()
        {
            return Db.messages.OrderByDescending(t => t.send_date)
                .ToListAsync();
        }

        public Task<List<int>> GetAvailableYears()
        {
            return Db.edu_form_data.Select(t => t.send_date.Year)
                .Distinct()
                .OrderBy(t => t)
                .ToListAsync();
        }

        public Task<List<edu_log>> GetSignInOutLogs()
        {
            return Db.edu_log.AsNoTracking()
                .Where(t => 
                    t.action_id == (int) LogActionType.Login || t.action_id == (int) LogActionType.Logout)
                .ToListAsync();
        }

        #endregion


        //@@-------------------------------    
    }
}
