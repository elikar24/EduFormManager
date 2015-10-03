using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.Spreadsheet;
using DevExpress.XtraPrinting.Native;

namespace EduFormManager.Forms.UserControls.FormulaEdit
{
    static class ExpressionBuilderFactory
    {
        public static ExpressionBuilder CreateExpressionBuilder(IList<Range> cellRangeList, string currentLineText)
        {
            if (cellRangeList.IsEmpty())
                return null;

            List<string> cellReferenceList = new List<string>();
            const ReferenceElement referenceOptions = ReferenceElement.IncludeSheetName | ReferenceElement.RowAbsolute | ReferenceElement.ColumnAbsolute;
            foreach (Range range in cellRangeList)
            {
                if (range.IsMerged)
                {
                    string reference = range[0].GetReferenceA1(referenceOptions);
                    cellReferenceList.Add(reference);
                }
                else
                {
                    cellReferenceList.AddRange(range.Select(cell => cell.GetReferenceA1(referenceOptions)));
                }
            }

            string expressionPartToAdd = cellReferenceList.Count == 1 ? cellReferenceList.First() : string.Join(" + ", cellReferenceList);

            if (string.IsNullOrEmpty(currentLineText))
            {
                return new ExpressionBuilder()
                {
                    LeftPart = string.Empty,
                    RightPart = string.Empty,
                    PartToAdd = expressionPartToAdd
                };
            }
            string[] expressionParts = currentLineText.Split(CheckExpressionRegexpConsts.OPERATORS, StringSplitOptions.None);
            Match operatorMatch = CheckExpressionRegexpConsts.OperatorRegex.Match(currentLineText);
            if (expressionParts.Length == 0)
            {
                return new ExpressionBuilder()
                {
                    PartToAdd = expressionPartToAdd,
                    Operator = operatorMatch.Success ? operatorMatch.Value : "="
                };
            }
            string currentLeftPart = string.IsNullOrEmpty(expressionParts[0]) ? string.Empty : expressionParts[0].Trim('+', '-', ' ');
            string currentRightPart = string.IsNullOrEmpty(expressionParts[1]) ? string.Empty : expressionParts[1].Trim('+', '-', ' ');

            return new ExpressionBuilder()
            {
                LeftPart = currentLeftPart,
                RightPart = currentRightPart,
                PartToAdd = expressionPartToAdd
            };
        }
    }
}
