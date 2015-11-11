using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.Utils;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace EduFormManager.Forms.Reports
{
    public partial class QueryReport : XtraReport
    {
        private IList<QueryReportDataGroup> _reportData;
        public QueryReport()
        {
            InitializeComponent();
        }

        public IList<QueryReportDataGroup> ReportData
        {
            set
            {
                _reportData = value;
                Build();
            }
            get
            {
                return this._reportData;
            }
        }

        private void Build()
        {
            var headerTable = new XRTable
            {
                Borders = BorderSide.Left | BorderSide.Right,
                BorderColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 11),
                BackColor = Color.SteelBlue,
                ForeColor = Color.FromArgb(245, 245, 245),
                LocationF = new PointFloat(0F, 0F),
                WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right
            };
            var headerRow = new XRTableRow
            {
                HeightF = 64
            };
            var fstCell = new XRTableCell
            {
                Text = "Образовательная орг.",
                TextAlignment = TextAlignment.MiddleCenter
            };
            headerRow.Cells.Add(fstCell);
            
            foreach (var pair in _reportData[0].Values) //шапка таблицы с заголовками запросов
            {
                var cell = new XRTableCell();
                cell.Text = pair.Key.title;
                cell.TextAlignment = TextAlignment.MiddleCenter;
                headerRow.Cells.Add(cell);
            }
            headerTable.Rows.Add(headerRow);
            
            this.PageHeader.Controls.Add(headerTable);

            var table = new XRTable
            {
                Borders = BorderSide.All,
                ForeColor = Color.FromArgb(59, 59, 59),
                BorderColor = Color.SteelBlue,
                LocationF = new PointFloat(0F, 0F),
                WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right
            };
            table.BeginInit();

            var summaryRow = new XRTableRow
            {
                BackColor = Color.SteelBlue,
                ForeColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 11)
            };
            var sumFstCell = new XRTableCell
            {
                Text = "Итого",
                TextAlignment = TextAlignment.MiddleLeft
            };
            summaryRow.Cells.Add(sumFstCell);

            for (var i = 0; i < _reportData[0].Values.Count; i++) //считается итого
            {
                var sum = 0;
                for (var j = 0; j < _reportData.Count; j++)
                {
                    var arr = new object[_reportData[j].Values.Values.Count];
                    _reportData[j].Values.Values.CopyTo(arr, 0);
                    var strVal = (string)arr[i];
                    int intVal;
                    sum += Int32.TryParse(strVal, out intVal) ? intVal : 0;
                }
                var cell = new XRTableCell
                {
                    Text = sum.ToString(),
                    TextAlignment = TextAlignment.MiddleCenter
                };
                summaryRow.Cells.Add(cell);
            }

            var sortedData = _reportData.OrderBy(t => t.Head);

            foreach (var data in sortedData)
            {
                var row = new XRTableRow {HeightF = 32};
                var cell1 = new XRTableCell
                {
                    Text = data.Head,
                    TextAlignment = TextAlignment.MiddleLeft
                };
                row.Cells.Add(cell1);

                foreach (var pair in data.Values)
                {
                    var cell3 = new XRTableCell
                    {
                        Text = (string) pair.Value,
                        TextAlignment = TextAlignment.MiddleCenter
                    };
                    row.Cells.Add(cell3);
                }
                table.Rows.Add(row);
            }

            table.Rows.Add(summaryRow);
            table.EndInit();
            this.Detail.Controls.Add(table);
        }
    }
}
