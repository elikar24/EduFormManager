using System;
using Models;

namespace EduFormManager.Utils
{
    public static class ModelExtensions
    {
        public static bool IsOpenXml(this document_format df)
        {
            return df.name.Equals("xlsx") || df.name.Equals("OpenXml");
        }

        public static int DaysRemain(this form f)
        {
            var submissionDate = f.submission_date;
            var dateExpired = new DateTime(DateTime.Now.Year, submissionDate.Month, submissionDate.Day);
            var dateNow = DateTime.Now;
            var daysRemaining = -1;
            if (dateExpired > dateNow)
                daysRemaining = (dateExpired - dateNow).Duration().Days;
            return daysRemaining;
        }
    }
}
