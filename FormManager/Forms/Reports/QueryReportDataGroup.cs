using System.Collections.Generic;
using EduFormManager.Models;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportDataGroupEdu //: Dictionary<THead, Dictionary<TFirst, TSecond>>
    {
        public QueryReportDataGroupEdu()
        {
            this.Values = new Dictionary<query, object>();
        }

        public edu Head { get; set; }

        public Dictionary<query, object> Values { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is QueryReportDataGroupEdu))
            {
                return base.Equals(obj);
            }
            else
            {
                QueryReportDataGroupEdu casted = (QueryReportDataGroupEdu)obj;
                return this.Head.Equals(casted.Head);
            }
        }
    }

    public class QueryReportDataGroupQuery
    {
        public QueryReportDataGroupQuery()
        {
            this.Values = new Dictionary<edu, object>();
        }

        public query Head { get; set; }

        public Dictionary<edu, object> Values { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is QueryReportDataGroupQuery))
            {
                return base.Equals(obj);
            }
            else
            {
                QueryReportDataGroupQuery casted = (QueryReportDataGroupQuery)obj;
                return this.Head.Equals(casted.Head);
            }
        }
    }
}
