﻿using System.Collections.Generic;

namespace EduFormManager.Forms.Reports
{
    public class QueryReportDataCollection : List<QueryReportData>
    {
        public IList<QueryReportDataGroup> Group()
        {
            var list = new List<QueryReportDataGroup>();

            foreach (var queryReportData in this)
            {
                var group = new QueryReportDataGroup();
                group.Head = queryReportData.Name;

                if (list.Contains(group))
                {
                    continue;
                }
                list.Add(group);
                foreach (var secReportData in this)
                {
                    if (group.Head.Equals(secReportData.Name))
                    {
                        try
                        {
                            group.Values.Add(secReportData.Query, secReportData.Data);
                        }
                        catch { }
                    }
                }
            }
            return list;
        }
    }
}
                              