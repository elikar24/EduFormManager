using Models;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportMuniipalityData : QueryReportData
    {
        public QueryReportMuniipalityData(municipality munit, query query, object data)
            : base (query, data)
        {
            this.Municipality = munit;
        }
        public municipality Municipality { get; private set; }

        public override string Name
        {
            get { return Municipality.name; }
        }
    }
}
