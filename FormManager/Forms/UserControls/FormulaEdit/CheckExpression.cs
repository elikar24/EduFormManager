using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using DevExpress.Spreadsheet;
using EduFormManager.Utilities;
using NLog;

namespace EduFormManager
{
    public class CheckExpression
    {
        public CheckExpression()
        {
            this.LeftPart = new ExpressionPart(this);
            this.RightPart = new ExpressionPart(this);
            this.Cells = new List<Cell>();
            this.ErrorMessages = new List<string>();
        }
        public CheckExpression(IWorkbook workbook)
        {
            this.Workbook = workbook;
            this.LeftPart = new ExpressionPart(this);
            this.RightPart = new ExpressionPart(this);
            this.Cells = new List<Cell>();
            this.ErrorMessages = new List<string>();
        }
        public IWorkbook Workbook { get; set; }

        public enum PartType
        {
            Cell,
            RowSum,
            ColumnSum
        }

        public enum OperatorType
        {
            eq,
            g ,
            l,
            ge,
            le
        }

        public class ExpressionPart
        {
            private static Regex worksheetRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_WORKSHEET_REGEXP);
            private static Regex cellRegex = new Regex(CheckExpressionRegexpConsts.EXP_PART_CELL_REGEXP);

            private static Logger logger = LogManager.GetCurrentClassLogger();

            public ExpressionPart(CheckExpression expression)
            {
                this.Expression = expression;
                this.A1References = new List<string>();
                this.Signs = new List<string>();
                this.PartString = string.Empty;
            }
            public CheckExpression Expression { get; set; }
            public List<string> A1References { get; set; }
            public List<string> Signs { get; set; }
            public String PartString { get; set; }
            public double Result 
            {
                get
                {
                    double result = GetCellValue(A1References[0]);
                    for (int i = 1; i < A1References.Count; i++)
                    {
                        double value = GetCellValue(A1References[i]);
                        string sign = Signs[i - 1];
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
                    this.PreviouslyComputedResult = result;
                    return result;
                } 
            }

            public double PreviouslyComputedResult { get; private set; }

            private double GetCellValue(string a1Reference)
            {
                string errorMessage = string.Empty;
                double errorValue = -100500;
                if (!worksheetRegex.IsMatch(a1Reference))
                {
                    errorMessage = "Неверная ссылка на книгу. " + a1Reference;
                    Expression.ErrorMessages.Add(errorMessage);
                    logger.Error(errorMessage);
                    return errorValue;
                }
                Match worksheetMatch = worksheetRegex.Match(a1Reference);
                string worksheetAddr = worksheetMatch.Groups["Workbook"].Value;

                if (!cellRegex.IsMatch(a1Reference))
                {
                    errorMessage = "Неверная ссылка на ячейку. " + a1Reference;
                    Expression.ErrorMessages.Add(errorMessage);
                    logger.Error(errorMessage);
                    return errorValue;
                }
                Match cellMatch = cellRegex.Match(a1Reference);
                string cellAddr = cellMatch.Groups["Cell"].Value;
                if (Expression.Workbook.Worksheets.Contains(worksheetAddr))
                {
                    Cell cell = Expression.Workbook.Worksheets[worksheetAddr].Cells[cellAddr];
                    if (cell != null)
                    {
                        this.Expression.Cells.Add(cell);
                        if (cell.Value.IsNumeric)
                            return cell.Value.NumericValue;
                        string value = cell.Value.ToString();
                        
                        CultureInfo[] cultureInfos = { CultureInfo.InvariantCulture, CultureInfo.CurrentCulture, new CultureInfo("en-US"), new CultureInfo("ru-RU") };
                        double dValue = -1.1;
                        foreach (CultureInfo cultureInfo in cultureInfos)
                        {
                            bool parsed = double.TryParse(value, NumberStyles.Float, cultureInfo, out dValue);
                            if (parsed) return dValue;
                        }
                        return dValue;
                    }
                    errorMessage = "Не найдена ячейка. " + a1Reference;
                    Expression.ErrorMessages.Add(errorMessage);
                    logger.Error(errorMessage);
                }
                else
                {
                    errorMessage = "Не найден лист. " + a1Reference;
                    Expression.ErrorMessages.Add(errorMessage);
                    logger.Error(errorMessage);
                }
                
                return errorValue;
            }
        }
        
        public OperatorType Operator { get; set; }
        public ExpressionPart LeftPart { get; set; }
        public ExpressionPart RightPart { get; set; }
        public string InitialExpressionString { get; set; }

        public CheckExpressionResult Result
        {
            get
            {
                bool ok = this.GetIsOk();
                CheckExpressionResult result = new CheckExpressionResult
                {
                    Ok = ok,
                    Message = this.ErrorMessages.Count != 0 ? string.Join("\n", this.ErrorMessages)
                        : !ok
                            ? string.Format("{0:0.###} не {1} {2:0.###}", this.LeftPart.PreviouslyComputedResult,
                                this.OperatorToString(), this.RightPart.PreviouslyComputedResult)
                            : string.Empty,
                    Color = ok ? Color.White : ColorUtility.RandomizedColor,
                    Expression = this.InitialExpressionString
                };

                result.Cells.AddRange(Cells);
                return result;
            }
        }

        public bool GetIsOk()
        {
            double left = Math.Round(this.LeftPart.Result, 2, MidpointRounding.ToEven);
            double right = Math.Round(this.RightPart.Result, 2, MidpointRounding.ToEven);

            if (this.ErrorMessages.Count == 0)
            {
                switch (this.Operator)
                {
                    case OperatorType.eq:
                        return (left == right);
                    case OperatorType.g:
                        return (left > right);
                    case OperatorType.ge:
                        return (left >= right);
                    case OperatorType.l:
                        return (left < right);
                    case OperatorType.le:
                        return (left <= right);
                    default:
                        throw new NotSupportedException("Недопустимый тип оператора в выражении.");
                }
            }
            else
            {
                return false;
            }
        }

        public List<string> ErrorMessages { get; set; }
        public List<Cell> Cells 
        { 
            get; 
            private set; 
        }

        public string OperatorToString()
        {
            switch (this.Operator)
            {
                case OperatorType.eq:
                    return "=";
                case OperatorType.g:
                    return ">";
                case OperatorType.ge:
                    return ">=";
                case OperatorType.l:
                    return "<";
                case OperatorType.le:
                    return "<=";
                default:
                    throw new NotSupportedException("Недопустимый тип оператора в выражении.");
            }
        }
    }
}
