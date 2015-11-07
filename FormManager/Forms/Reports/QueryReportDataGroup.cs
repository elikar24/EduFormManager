using System.Collections.Generic;
using Models;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportDataGroup
    {
        public QueryReportDataGroup()
        {
            this.Values = new Dictionary<query, object>();
        }

        public string Head { get; set; }

        public Dictionary<query, object> Values { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return ((QueryReportDataGroup)obj).Head.Equals(this.Head);
        }
    }
}
