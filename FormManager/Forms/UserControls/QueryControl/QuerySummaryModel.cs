using System.Collections.Generic;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public class QuerySummaryModel
    {
        public form Form { get; set; }
        public int Year { get; set; }
        public List<edu> EduList { get; private set; }
        public List<query> QueryList { get; private set; }

        public QuerySummaryModel()
        {
            EduList = new List<edu>();
            QueryList = new List<query>();
        }
        public QuerySummaryModel(form form, int year)
        {
            Form = form;
            Year = year;
            EduList = new List<edu>();
            QueryList = new List<query>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Form.name, Year);
        }
    }
}
