using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace EduFormManager.Forms.Reports
{
    public partial class QueryReport : XtraReport
    {
        private IList<QueryReportDataGroupEdu> reportData;
        public QueryReport()
        {
            InitializeComponent();
        }

        public IList<QueryReportDataGroupEdu> ReportData
        {
            set
            {
                this.reportData = value;
                XRTable headerTable = new XRTable();
                headerTable.BeginInit();
                XRTableRow headerRow = new XRTableRow();
                headerRow.HeightF = 64;
                XRTableCell fstCell = new XRTableCell();
                fstCell.Text = "Образовательная орг.";
                fstCell.TextAlignment = TextAlignment.MiddleCenter;
                headerRow.Cells.Add(fstCell);
                foreach (var pair in value[0].Values)
                {
                    XRTableCell cell = new XRTableCell();
                    cell.Text = pair.Key.title;
                    cell.TextAlignment = TextAlignment.MiddleCenter;
                    headerRow.Cells.Add(cell);
                }
                headerTable.Rows.Add(headerRow);
                headerTable.AdjustSize();
                headerTable.Borders = BorderSide.Left | BorderSide.Right;
                headerTable.BorderColor = Color.FromArgb(245,245,245);
                Font font = new Font("Segoe UI", 11);
                headerTable.Font = font;
                headerTable.BackColor = Color.SteelBlue;
                headerTable.ForeColor = Color.FromArgb(245, 245, 245);
                
                headerTable.EndInit();
                headerTable.LocationF = new PointFloat(0F, 0F);
                headerTable.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                this.PageHeader.Controls.Add(headerTable);

                XRTable table = new XRTable();
                table.BeginInit();

                XRTableRow summaryRow = new XRTableRow();
                XRTableCell sumFstCell = new XRTableCell();
                sumFstCell.Text = "Итого";
                sumFstCell.TextAlignment = TextAlignment.MiddleLeft;
                summaryRow.BackColor = Color.SteelBlue;
                summaryRow.ForeColor = Color.FromArgb(245, 245, 245);
                summaryRow.Font = new Font("Segoe UI", 11);
                summaryRow.Cells.Add(sumFstCell);

                for (int i = 0; i < value[0].Values.Count; i++){
                    int sum = 0;
                    
                    for (int j = 0; j < value.Count; j++)
                    {
                        object[] arr = new object[value[j].Values.Values.Count];
                        value[j].Values.Values.CopyTo(arr, 0);
                        String strVal = (string)arr[i];
                        int intVal = -1;
                        sum += Int32.TryParse(strVal, out intVal) ? intVal : 0;
                    }
                    XRTableCell cell = new XRTableCell();
                    cell.Text = sum.ToString();
                    cell.TextAlignment = TextAlignment.MiddleCenter;
                    summaryRow.Cells.Add(cell);
                }

                foreach (QueryReportDataGroupEdu data in value)
                {
                    XRTableRow row = new XRTableRow();
                    row.HeightF = 32;
                    XRTableCell cell1 = new XRTableCell();
                    cell1.Text = data.Head.name;
                    cell1.TextAlignment = TextAlignment.MiddleLeft;
                    row.Cells.Add(cell1);

                    foreach (var pair in data.Values)
                    {
                        XRTableCell cell3 = new XRTableCell();
                        cell3.Text = (String)pair.Value;
                        cell3.TextAlignment = TextAlignment.MiddleCenter;
                        row.Cells.Add(cell3);
                    }
                    table.Rows.Add(row);
                }

                table.Rows.Add(summaryRow);

                table.AdjustSize();
                table.Borders = BorderSide.All;
                table.ForeColor = Color.FromArgb(59, 59, 59);
                table.BorderColor = Color.SteelBlue;
                table.EndInit();
                this.Detail.Controls.Add(table);
                table.LocationF = new PointFloat(0F, 0F);
                table.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
                
            }
            get
            {
                return this.reportData;
            }
        }

    }
}
