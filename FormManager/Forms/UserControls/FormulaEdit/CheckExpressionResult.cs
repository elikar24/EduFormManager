using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace EduFormManager
{
    public class CheckExpressionResult
    {
        public CheckExpressionResult()
        {
            this.Cells = new List<Cell>();
            this.Message = String.Empty;
            this.Expression = String.Empty;
        }
        public Boolean Ok { get; set; }
        public String Message { get; set; }
        public String Expression { get; set; }
        public Color Color { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
