using System.Collections.Generic;
using Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public abstract class QuerySummaryModel
    {
        public form Form { get; set; }
        public int Year { get; set; }
        public List<query> QueryList { get; private set; }

        protected QuerySummaryModel()
        {
            QueryList = new List<query>();
        }

        protected QuerySummaryModel(form form, int year)
        {
            Form = form;
            Year = year;
            QueryList = new List<query>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Form.name, Year);
        }
    }
}
