using System.Collections.Generic;
using Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public class QueryEduSummaryModel : QuerySummaryModel
    {
        public List<edu> EduList { get; private set; }
        
        public QueryEduSummaryModel()
            : base()
        {
            EduList = new List<edu>();
        }

        public QueryEduSummaryModel(form form, int year)
            : base (form, year)
        {
            EduList = new List<edu>();
        }
    }
}
