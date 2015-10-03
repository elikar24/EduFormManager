using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace EduFormManager.Forms
{
    public partial class CheckFormulaEditor : UserControl
    {
        private IList<Range> m_range;
        private static string[] m_operators = new string[] { "=", ">", ">=", "<", "<=", "!=" };

        private static Regex m_checkRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_EXPRESSION_REGEXP);
        private static Regex m_operandRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_OPERAND_REGEXP);
        private static Regex m_operatorRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_OPERATOR_REGEXP);

        private static Color m_badLineBackColor = Color.FromArgb(0xD2, 0x92, 0x92);
        private static Color m_operandTextColor = Color.FromArgb(0x2C, 0x41, 0xE4);
        private static Color m_operatorTextColor = Color.FromArgb(0xAF, 0x00, 0x00);
        private enum Operator
        {
            Equal = 0,
            Greater = 1,
            GreaterOrEqual = 2,
            Less = 3,
            LessOrEqual = 4,
            NotEqual = 5
        }

        public CheckFormulaEditor()
        {
            InitializeComponent();
        }

        bool m_isManualInput = false;

        private void textBoxEditor_TextChanged(object sender, EventArgs e)
        {
            if (m_isManualInput)
            {
                string currentLine = this.CurrentLine;
                CheckAndColorizeLine(currentLine);
                ColorizeOperands(currentLine);
            }
        }

        public void CheckAndColorizeLine(string line)
        {
            if (!IsLineMatch(line))
            {
                ColorizeLine(line, m_badLineBackColor);
            }
            else
            {
                ColorizeLine(line, this.textBoxEditor.BackColor);
            }
        }

        public void ColorizeOperands(string line)
        {
            m_isManualInput = false;
            int prevSelectionStartIdx = this.textBoxEditor.SelectionStart;

            int lineIdx = Array.IndexOf(this.Lines, line);
            if (lineIdx > -1)
            {
                int selectionStartIdx = this.textBoxEditor.GetFirstCharIndexFromLine(lineIdx);
                this.textBoxEditor.SelectionStart = selectionStartIdx;
                this.textBoxEditor.SelectionLength = line.Length;
                this.textBoxEditor.SelectionColor = this.textBoxEditor.ForeColor;
                MatchCollection operandMatches = m_operandRegex.Matches(line);
                foreach (Match match in operandMatches)
                {
                    int startIdx = selectionStartIdx + match.Index;
                    int endIdx = startIdx + match.Length;
                    this.textBoxEditor.SelectionStart = startIdx;
                    this.textBoxEditor.SelectionLength = endIdx - startIdx;
                    this.textBoxEditor.SelectionColor = m_operandTextColor;
                    this.textBoxEditor.SelectionLength = 0;
                }
                MatchCollection operatorMatches = m_operatorRegex.Matches(line);
                foreach (Match match in operatorMatches)
                {
                    int startIdx = selectionStartIdx + match.Index;
                    int endIdx = startIdx + match.Length;
                    this.textBoxEditor.SelectionStart = startIdx;
                    this.textBoxEditor.SelectionLength = endIdx - startIdx;
                    this.textBoxEditor.SelectionColor = m_operatorTextColor;
                    this.textBoxEditor.SelectionLength = 0;
                }
                this.textBoxEditor.SelectionStart = prevSelectionStartIdx;
            }
            m_isManualInput = true;
        }

        public void ColorizeLine(string line, Color backColor)
        {
            m_isManualInput = false;
            int prevSelectionStartIdx = this.textBoxEditor.SelectionStart;

            int lineIdx = Array.IndexOf(this.Lines, line);
            if (lineIdx > -1)
            {
                int selectionStartIdx = this.textBoxEditor.GetFirstCharIndexFromLine(lineIdx);
                int selectionLength = line.Length;

                this.textBoxEditor.SelectionStart = selectionStartIdx;
                this.textBoxEditor.SelectionLength = selectionLength;
                this.textBoxEditor.SelectionBackColor = backColor;
                this.textBoxEditor.SelectionLength = 0;
                this.textBoxEditor.SelectionStart = prevSelectionStartIdx;
            }
            m_isManualInput = true;
        }

        public bool IsLineMatch(string line)
        {
            return m_checkRegex.IsMatch(line);
        }

        public IList<Range> CellRange
        {
            set
            {
                if (value == null)
                {
                    return;
                }

                m_range = value;
                textBoxEditor.Focus();
                string line = this.CurrentLine.Trim();
                string[] lineParts = line.Split(m_operators, StringSplitOptions.RemoveEmptyEntries);
                //string oper = m_regexCompositeOperator.IsMatch(line) ? m_regexCompositeOperator.Match(line).Value : (m_regexOperator.IsMatch(line) ? m_regexOperator.Match(line).Value : string.Empty);
                string oper = m_operatorRegex.IsMatch(line) ? m_operatorRegex.Match(line).Value : string.Empty;
                int operatorIndex = string.IsNullOrEmpty(oper) ? -1 : line.IndexOf(oper);
                
                IList<string> cellReferenceList = this.GetCellRefences(value);
                string stringExpressionPart = cellReferenceList.Count == 1 ? cellReferenceList.First() : string.Join(" + ", cellReferenceList);
                string newLine = string.Empty;
                int newCursorIdx = this.CursorIndex;
                if (lineParts.Length < 2)
                {
                    if (string.IsNullOrEmpty(oper))
                    {
                        newLine = stringExpressionPart;
                        newCursorIdx = this.textBoxEditor.GetFirstCharIndexOfCurrentLine() + newLine.Length;
                    }
                    else
                    {
                        if (lineParts.Length == 0)
                            lineParts = new string[] { string.Empty, string.Empty };
                        else
                        {
                            lineParts = this.CursorIndex > operatorIndex ? new string[] { lineParts[0], string.Empty } : new string[] { string.Empty, lineParts[0] };
                        }
                    }
                }
                if (lineParts.Length == 2) 
                {
                    int partIdx = this.CursorIndex <= operatorIndex ? 0 : 1;
                    lineParts[partIdx] = stringExpressionPart;
                    newLine = string.Format("{0} {1} {2}", lineParts[0].Trim(), oper, lineParts[1].Trim());
                    newCursorIdx = this.textBoxEditor.GetFirstCharIndexOfCurrentLine() + (partIdx == 0 ? lineParts[0].Length : newLine.Length);
                }
                
                int lineIdx = this.CurrentLineIndex;
                if (lineIdx > 0 && lineIdx < this.textBoxEditor.Lines.Length)
                {
                    string[] lines = this.textBoxEditor.Lines;
                    lines[lineIdx] = newLine;
                    this.textBoxEditor.Lines = lines;
                }
                else
                    this.textBoxEditor.Lines = new string[] { newLine };
                this.CursorIndex = newCursorIdx;
            }
            get
            {
                return m_range;
            }
        }

        private IList<string> GetCellRefences(IList<Range> range)
        {
            List<string> cellReferenceList = new List<string>();
            foreach (Range _range in range)
            {
                ReferenceElement referenceOptions = ReferenceElement.IncludeSheetName | ReferenceElement.RowAbsolute | ReferenceElement.ColumnAbsolute;
                if (_range.IsMerged)
                {
                    string reference = _range[0].GetReferenceA1(referenceOptions);
                    cellReferenceList.Add(reference);
                }
                else
                {
                    foreach (Cell cell in _range)
                    {
                        string reference = cell.GetReferenceA1(referenceOptions);
                        cellReferenceList.Add(reference);
                    }
                }
            }
            return cellReferenceList;
        }

        public int CursorIndex
        {
            get
            {
                ArraySegment<string> linesSegment = new ArraySegment<string>(this.Lines, 0, this.CurrentLineIndex);
                return this.textBoxEditor.SelectionStart - linesSegment.Sum(line => (line.Length + 1));
            }
            set
            {
                ArraySegment<string> linesSegment = new ArraySegment<string>(this.Lines, 0, this.CurrentLineIndex);
                this.textBoxEditor.SelectionStart = value + linesSegment.Sum(line => (line.Length + 1));
            }
        }

        public string[] Lines
        {
            get
            {
                return this.textBoxEditor.Lines;
            }
            set
            {
                this.textBoxEditor.Lines = value;
            }
        }

        public string CurrentLine
        {
            get
            {
                int lineIndex = this.textBoxEditor.GetLineFromCharIndex(this.textBoxEditor.SelectionStart);
                if (lineIndex >= 0 && lineIndex < this.textBoxEditor.Lines.Length)
                    return this.textBoxEditor.Lines[lineIndex];
                return string.Empty;
            }
        }

        public int CurrentLineIndex
        {
            get
            {
                int lineIndex = this.textBoxEditor.GetLineFromCharIndex(this.textBoxEditor.SelectionStart);
                return lineIndex;
            }
        }

        private string[] LineNumbers
        {
            get
            {
                string[] numberArray = new string[this.textBoxEditor.Lines.Length];
                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = (i + 1).ToString();
                }
                return numberArray;
            }
        }

        public override string Text
        {
            get
            {
                return this.textBoxEditor.Text;
            }
            set
            {
                m_isManualInput = false;
                this.textBoxEditor.Text = value;
                foreach (string line in this.Lines)
                {
                    CheckAndColorizeLine(line);
                    ColorizeOperands(line);
                }
                m_isManualInput = true;
            }
        }

        private void textBoxEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int startIdx = this.textBoxEditor.GetFirstCharIndexOfCurrentLine();
                int endIdx = startIdx + this.CurrentLine.Length;
                this.textBoxEditor.SelectionStart = endIdx;
            }
            this.textBoxLineNumbers.Lines = this.LineNumbers;
        }

        public class SelectionEventArgs
        {
            public int CaretIndexAtLine { get; set; }
            public int LineIndex { get; set; }
        }

        public event EventHandler<SelectionEventArgs> SelectionChanged;

        private void OnSelectionChanged(SelectionEventArgs e)
        {
            EventHandler<SelectionEventArgs> handler = SelectionChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        private void textBoxEditor_SelectionChanged(object sender, EventArgs e)
        {
            if (this.textBoxEditor.SelectionLength == 0 && m_isManualInput)
            {
                OnSelectionChanged(new SelectionEventArgs() { CaretIndexAtLine = this.CursorIndex, LineIndex = this.CurrentLineIndex });
            }
        }
    }
}
