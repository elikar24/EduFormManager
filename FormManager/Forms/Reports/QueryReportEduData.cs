using Models;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportEduData : QueryReportData
    {
        public QueryReportEduData(edu edu, query query, object data)
            : base(query, data)
        {
            this.Edu = edu;
        }
        public edu Edu { get; private set; }

        public override string Name
        {
            get { return Edu.name; }
        }
    }
}
