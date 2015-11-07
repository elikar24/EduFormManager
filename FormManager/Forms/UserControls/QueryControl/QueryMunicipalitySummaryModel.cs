using System.Collections.Generic;
using Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public class QueryMunicipalitySummaryModel : QuerySummaryModel
    {
        public List<municipality> MunicipalityList { get; private set; }
        
        public QueryMunicipalitySummaryModel()
            : base()
        {
            MunicipalityList = new List<municipality>();
        }

        public QueryMunicipalitySummaryModel(form form, int year)
            : base (form, year)
        {
            MunicipalityList = new List<municipality>();
        }
    }
}
