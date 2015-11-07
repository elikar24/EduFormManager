using Models;

namespace EduFormManager.Forms.Reports
{
    public abstract class QueryReportData
    {
        protected QueryReportData(query query, object data)
        {
            this.Query = query;
            this.Data = data;
        }
        public query Query { get; private set; }
        public object Data { get; private set; }

        public abstract string Name { get; }
    }
}
