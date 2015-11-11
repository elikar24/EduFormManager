using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet;
using EduFormManager.Forms.UserControls.QueryControl;

using EduFormManager.Utils;
using Models;

namespace EduFormManager.Forms.Reports
{
    public static class ReportFactory
    {
        public static IList<XtraReport> Reports { get; set; }

        static ReportFactory()
        {
            Reports = new List<XtraReport>();
        }

        public static Task<XtraReport> CreateQueryReportAsync(QueryEduSummaryModel model)
        {
            return Task.Run(() => CreateQueryReport(model));
        }

        public static XtraReport CreateQueryReport(QueryEduSummaryModel model)
        {
            var edus = model.EduList;
            var queries = model.QueryList;
            var year = model.Year;
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
                        var stringValue = "";
                        try
                        {
                            var content = query.content;
                            if (content.StartsWith("@"))
                            {
                                var propName = content.Substring(1);
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
                        reportDataList.Add(new QueryReportEduData(edu, query, stringValue));
                    }
                }
            }
            var groupedList = (List<QueryReportDataGroup>)reportDataList.Group();
            var report = new QueryReport { ReportData = groupedList };
            Reports.Add(report);
            return report;
        }

        public static Task<XtraReport> CreateQueryReportAsync(QueryMunicipalitySummaryModel model)
        {
            return Task.Run(() => CreateQueryReport(model));
        }

        public static XtraReport CreateQueryReport(QueryMunicipalitySummaryModel model)
        {
            var municipalities = model.MunicipalityList;
            var queries = model.QueryList;
            var year = model.Year;
            var form = model.Form;
            var reportDataList = new QueryReportDataCollection();
            using (var spreadsheetControl = new SpreadsheetControl() { AllowDrop = false })
            {
                foreach (var munit in municipalities)
                {
                    var formData = munit.municipality_form_data.FirstOrDefault(t => t.form == form && t.send_date.Year == year);
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
                        var stringValue = "";
                        try
                        {
                            var content = query.content;
                            var value = spreadsheetControl.Document.Range[content].Value;
                            stringValue = GetStringValueFromCell(value);
                        }
                        catch (Exception ex)
                        {
                            stringValue = "Не удалось";
                        }
                        reportDataList.Add(new QueryReportMuniipalityData(munit, query, stringValue));
                    }
                }
            }
            var groupedList = (List<QueryReportDataGroup>)reportDataList.Group();
            var report = new QueryReport { ReportData = groupedList };
            Reports.Add(report);
            return report;
        }

        private static string GetStringValueFromCell(CellValue value)
        {
            return value != null ? value.ToString() : "NAN";
        }
    }
}
