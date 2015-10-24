using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.Spreadsheet;
using EduFormManager.Utils;
using NLog;

namespace EduFormManager.Forms.UserControls.MunicipalityFormulaPeek
{
    public class FormulaExpression
    {
        public FormulaExpressionPart SourcePart { get; set; }

        public FormulaExpressionPart TargetPart { get; set; }

        public string ExpressionString { get; set; }

        public IList<string> ErrorMessages { get; set; } 

        public FormulaExpression()
        {
            SourcePart = new FormulaExpressionPart(this);
            TargetPart = new FormulaExpressionPart(this);
            ErrorMessages = new List<string>();
        }

        public IWorkbook Source { get; set; }
        public IWorkbook Target { get; set; }


        public void WriteToTarget()
        {
            var value = this.SourcePart.Value;
            var targetRef = this.TargetPart.A1References.First();
            var targetCell = this.TargetPart.GetCell(targetRef, this.Target);
            
            targetCell.SetValue(value);
        }

        public void AppendToTarget()
        {
            var sValue = this.SourcePart.Value.ToString();
            var targetRef = this.TargetPart.A1References.First();
            var targetCell = this.TargetPart.GetCell(targetRef, this.Target);
            var sCurrValue = targetCell.Value.ToString();
            var currValue = sCurrValue.ParseDouble();
            var value = sValue.ParseDouble();
            if (value.IsErrorDouble() || currValue.IsErrorDouble()) return;
            targetCell.SetValue(value + currValue);
        }

        public class FormulaExpressionPart
        {
            private static readonly Regex WorksheetRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_WORKSHEET_REGEXP);
            private static readonly Regex CellRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_CELL_REGEXP);
            private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

            public FormulaExpressionPart(FormulaExpression expression)
            {
                this.Expression = expression;
                this.A1References = new List<string>();
                this.Signs = new List<string>();
            }

            public FormulaExpression Expression { get; private set; }

            /// <summary>
            /// Gives value of expression part.
            /// </summary>
            public object Value 
            {
                get
                {
                    var result = 0.0;
                    if (!A1References.Any()) 
                        return result;
                    result = GetCellValue(A1References[0], Expression.Source);
                    if (result.IsErrorDouble()) 
                        result = 0.0;
                    for (var i = 1; i < A1References.Count; i++)
                    {
                        try
                        {
                            var value = GetCellValue(A1References[i], Expression.Source);
                            if (value.IsErrorDouble()) 
                                continue;
                            var sign = Signs[i - 1];
                            switch (sign)
                            {
                                case "+":
                                    result += value;
                                    break;
                                case "-":
                                    result -= value;
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    return result;
                }
            }

            public IList<string> A1References { get; set; }

            public IList<string> Signs { get; set; }

            internal Cell GetCell(string a1Reference, IWorkbook book)
            {
                if (!WorksheetRegex.IsMatch(a1Reference))
                {
                    var errorMessage = "Неверная ссылка на книгу. " + a1Reference + book.DocumentProperties.Title;
                    Expression.ErrorMessages.Add(errorMessage);
                    Logger.Error(errorMessage);
                    return null;
                }
                var worksheetMatch = WorksheetRegex.Match(a1Reference);
                var worksheetAddr = worksheetMatch.Groups["Workbook"].Value;

                if (!CellRegex.IsMatch(a1Reference))
                {
                    var errorMessage = "Неверная ссылка на ячейку. " + a1Reference + book.DocumentProperties.Title;
                    Expression.ErrorMessages.Add(errorMessage);
                    Logger.Error(errorMessage);
                    return null;
                }
                var cellMatch = CellRegex.Match(a1Reference);
                var cellAddr = cellMatch.Groups["Cell"].Value;
                if (book.Worksheets.Contains(worksheetAddr))
                {
                    var cell = book.Worksheets[worksheetAddr].Cells[cellAddr];
                    if (cell != null)
                        return cell;
                    var errorMessage = "Не найдена ячейка. " + a1Reference + book.DocumentProperties.Title;
                    Expression.ErrorMessages.Add(errorMessage);
                    Logger.Error(errorMessage);
                }
                else
                {
                    var errorMessage = "Не найден лист. " + a1Reference + book.DocumentProperties.Title;
                    Expression.ErrorMessages.Add(errorMessage);
                    Logger.Error(errorMessage);
                }
                
                return null;
            }

            internal double GetCellValue(string a1Reference, IWorkbook book)
            {
                var cell = GetCell(a1Reference, book);
                if (cell == null) return 0.0;
                var sValue = cell.Value.ToString();
                var value = sValue.ParseDouble();
                return value;
            }

            internal string GetRawCellValue(string a1Reference, IWorkbook book)
            {
                var cell = GetCell(a1Reference, book);
                if (cell == null) return string.Empty;
                var sValue = cell.Value.ToString();
                return sValue;
            }
        }
    }
}