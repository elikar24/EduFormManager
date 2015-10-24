using Models;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportData
    {
        public QueryReportData(edu edu, query query, object data)
        {
            this.Edu = edu;
            this.Query = query;
            this.Data = data;
        }
        public edu Edu { get; private set; }
        public query Query { get; private set; }
        public object Data { get; private set; }
    }
}
