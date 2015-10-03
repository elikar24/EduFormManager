﻿using System.Collections;
using System.Collections.Generic;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportDataCollection : List<QueryReportData>
    {
        public IList GroupByEdu()
        {
            List<QueryReportDataGroupEdu> list = new List<QueryReportDataGroupEdu>();
            foreach (QueryReportData reportData in this)
            {
                var edu = reportData.Edu;
                var group = new QueryReportDataGroupEdu();
                group.Head = edu;

                if (list.Contains(group))
                {
                    continue;
                }
                else
                {
                    list.Add(group);
                }
                foreach (var secReportData in this)
                {
                    if (group.Head.Equals(secReportData.Edu))
                    {
                        group.Values.Add(secReportData.Query, secReportData.Data);
                    }
                }
            }
            return list;
        }

        public IList GroupByQuery()
        {
            var list = new List<QueryReportDataGroupQuery>();
            foreach (var reportData in this)
            {
                var query = reportData.Query;
                var group = new QueryReportDataGroupQuery();
                group.Head = query;

                if (list.Contains(group))
                {
                    continue;
                }
                else
                {
                    list.Add(group);
                }
                foreach (var secReportData in this)
                {
                    if (group.Head.Equals(secReportData.Query))
                    {
                        group.Values.Add(secReportData.Edu, secReportData.Data);
                    }
                }
            }
            return list;
        }
    }
}
                              