﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet;
using EduFormManager.Forms.UserControls.QueryControl;
using EduFormManager.Models;
using EduFormManager.Utils;

namespace EduFormManager.Forms.Reports
{
    public static class ReportFactory
    {
        public static XtraReport LastReport { get; set; }

        public static Task<XtraReport> CreateQueryReportAsync(QuerySummaryModel model)
        {
            return Task.Run(() => CreateQueryReport(model));
        }

        public static XtraReport CreateQueryReport(QuerySummaryModel model)
        {
            var edus = model.EduList;
            var queries = model.QueryList;
            int year = model.Year;
            var form = model.Form;
            var reportDataList = new QueryReportDataCollection();
            using (var spreadsheetControl = new SpreadsheetControl() { AllowDrop = false })
            {
                foreach (var edu in edus)
                {
                    var formData = edu.edu_form_data.FirstOrDefault(t => t.form == form && t.send_date.Year == year);
                    if (formData != null)
                    {
                        var excelData = formData.file.contents;
                        var format = formData.document_format.IsOpenXml()
                            ? DocumentFormat.OpenXml
                            : DocumentFormat.Xls;
                        spreadsheetControl.LoadDocument(excelData, format);
                    }
                    foreach (var query in queries)
                    {
                        string stringValue = "";
                        try
                        {
                            string content = query.content;
                            if (content.StartsWith("@"))
                            {
                                string propName = content.Substring(1);
                                var propInfo = typeof (edu).GetProperty(propName);
                                stringValue = propInfo.GetValue(edu).ToString();
                            }
                            else
                            {
                                var value = spreadsheetControl.Document.Range[content].Value;
                                stringValue = GetStringValueFromCell(value);
                            }
                        }
                        catch (Exception ex)
                        {
                            stringValue = "Не удалось";
                        }
                        reportDataList.Add(new QueryReportData(edu, query, stringValue));
                    }
                }
            }
            List<QueryReportDataGroupEdu> groupedList = (List<QueryReportDataGroupEdu>)reportDataList.GroupByEdu();
            //List<QueryReportDataGroupQuery> groupedList = (List<QueryReportDataGroupQuery>)reportDataList.GroupByQuery();
            QueryReport report = new QueryReport {ReportData = groupedList};
            LastReport = report;
            return report;
        }

        private static string GetStringValueFromCell(CellValue value)
        {
            return value != null ? value.ToString() : "NAN";
        }
    }
}
