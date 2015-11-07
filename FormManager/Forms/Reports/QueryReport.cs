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
            var headerTable = new XRTable();
            headerTable.BeginInit();
            var headerRow = new XRTableRow();
            headerRow.HeightF = 64;
            var fstCell = new XRTableCell();
            fstCell.Text = "Образовательная орг.";
            fstCell.TextAlignment = TextAlignment.MiddleCenter;
            headerRow.Cells.Add(fstCell);
            
            foreach (var pair in _reportData[0].Values)
            {
                var cell = new XRTableCell();
                cell.Text = pair.Key.title;
                cell.TextAlignment = TextAlignment.MiddleCenter;
                headerRow.Cells.Add(cell);
            }
            headerTable.Rows.Add(headerRow);
            headerTable.AdjustSize();
            headerTable.Borders = BorderSide.Left | BorderSide.Right;
            headerTable.BorderColor = Color.FromArgb(245, 245, 245);
            var font = new Font("Segoe UI", 11);
            headerTable.Font = font;
            headerTable.BackColor = Color.SteelBlue;
            headerTable.ForeColor = Color.FromArgb(245, 245, 245);

            headerTable.EndInit();
            headerTable.LocationF = new PointFloat(0F, 0F);
            headerTable.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
            this.PageHeader.Controls.Add(headerTable);

            var table = new XRTable();
            table.BeginInit();

            var summaryRow = new XRTableRow();
            var sumFstCell = new XRTableCell();
            sumFstCell.Text = "Итого";
            sumFstCell.TextAlignment = TextAlignment.MiddleLeft;
            summaryRow.BackColor = Color.SteelBlue;
            summaryRow.ForeColor = Color.FromArgb(245, 245, 245);
            summaryRow.Font = new Font("Segoe UI", 11);
            summaryRow.Cells.Add(sumFstCell);

            for (var i = 0; i < _reportData[0].Values.Count; i++)
            {
                var sum = 0;
                for (var j = 0; j < _reportData.Count; j++)
                {
                    var arr = new object[_reportData[j].Values.Values.Count];
                    _reportData[j].Values.Values.CopyTo(arr, 0);
                    var strVal = (string)arr[i];
                    var intVal = -1;
                    sum += Int32.TryParse(strVal, out intVal) ? intVal : 0;
                }
                var cell = new XRTableCell();
                cell.Text = sum.ToString();
                cell.TextAlignment = TextAlignment.MiddleCenter;
                summaryRow.Cells.Add(cell);
            }

            foreach (var data in _reportData)
            {
                var row = new XRTableRow();
                row.HeightF = 32;
                var cell1 = new XRTableCell();
                cell1.Text = data.Head;
                cell1.TextAlignment = TextAlignment.MiddleLeft;
                row.Cells.Add(cell1);

                foreach (var pair in data.Values)
                {
                    var cell3 = new XRTableCell();
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
    }
}
