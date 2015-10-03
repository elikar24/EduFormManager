using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
using Match = System.Text.RegularExpressions.Match;

namespace EduFormManager.Forms.UserControls.FormulaEdit
{
    public class SyntaxHighlight : ISyntaxHighlightService
    {
        private readonly Document _document;
        private readonly FormulaEditControl _editControl;

        readonly SyntaxHighlightProperties _operatorProperties = new SyntaxHighlightProperties()
        {
            ForeColor = CheckExpressionRegexpConsts.OperatorTextColor
        };

        readonly SyntaxHighlightProperties _operandProperties = new SyntaxHighlightProperties()
        {
            ForeColor = CheckExpressionRegexpConsts.OperandTextColor
        };

        readonly SyntaxHighlightProperties _badLineProperties = new SyntaxHighlightProperties()
        {
            Underline = UnderlineType.Wave,
            UnderlineColor = CheckExpressionRegexpConsts.BadLineBackColor
        };

        readonly SyntaxHighlightProperties _okLineProperties = new SyntaxHighlightProperties()
        {
            Underline =  UnderlineType.None
        };

        private SynchronizationContext _context;

        public SyntaxHighlight(FormulaEditControl control, SynchronizationContext context)
        {
            _editControl = control;
            _document = control.Document;
            _context = context;
        }

        private List<SyntaxHighlightToken> GetLineTokens()
        {
            List<SyntaxHighlightToken> tokenList = new List<SyntaxHighlightToken>();
          
            Regex formulaRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_EXPRESSION_REGEXP);
            foreach (Paragraph paragraph in _document.Paragraphs)
            {
                DocumentRange range = paragraph.Range;
                string line = _document.GetText(range);
                SyntaxHighlightToken token = formulaRegex.IsMatch(line) ? 
                    new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _okLineProperties) : 
                    new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _badLineProperties);
                
                if (!IsTokenOverlapped(tokenList, token))
                    tokenList.Add(token);
                else
                    Debug.WriteLine("line {0} token {1};{2}", line, token.Start, token.End);
            }

            return tokenList.OrderBy(t => t.Start).ToList();
        }

        private List<SyntaxHighlightToken> GetLineTokenForLine(string line)
        {
            List<SyntaxHighlightToken> tokenList = new List<SyntaxHighlightToken>();
            if (string.IsNullOrEmpty(line)) return tokenList;
            Regex formulaRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_EXPRESSION_REGEXP);
            DocumentRange range = _document.FindAll(line, SearchOptions.None).First();
            if (range == null) return tokenList;
            SyntaxHighlightToken lineToken = formulaRegex.IsMatch(line)
                ? new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _okLineProperties)
                : new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _badLineProperties);
            tokenList.Add(lineToken);

            return tokenList.OrderBy(t => t.Start).ToList();
        }

        private List<SyntaxHighlightToken> GetTokensForLine(string line)
        {
            List<SyntaxHighlightToken> tokenList = new List<SyntaxHighlightToken>();
            if (string.IsNullOrEmpty(line)) return tokenList;
            DocumentRange lineRange = _document.FindAll(line, SearchOptions.None).First();
            if (lineRange == null) return tokenList;

            IEnumerable<SyntaxHighlightToken> operatorTokens = CheckExpressionRegexpConsts.OperatorRegex.Matches(line)
                .Cast<Match>()
                .Select(match => _document.CreateRange(lineRange.Start.ToInt() + match.Index, match.Length))
                .Select(range => new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _operatorProperties))
                .Where(token => !IsTokenOverlapped(tokenList, token));
            tokenList.AddRange(operatorTokens);

            IEnumerable<SyntaxHighlightToken> operandTokens = CheckExpressionRegexpConsts.OperandRegex.Matches(line).Cast<Match>()
                .Select(match => _document.CreateRange(lineRange.Start.ToInt() + match.Index, match.Length))
                .Select(range => new SyntaxHighlightToken(range.Start.ToInt(), range.Length, _operandProperties))
                .Where(token => !IsTokenOverlapped(tokenList, token));
            tokenList.AddRange(operandTokens);

            return tokenList.OrderBy(t => t.Start).ToList();
        } 

        private List<SyntaxHighlightToken> GetTokens()
        {
            List<SyntaxHighlightToken> tokenList = new List<SyntaxHighlightToken>();

            foreach (DocumentRange documentRange in _document.FindAll(CheckExpressionRegexpConsts.OperatorRegex))
            {
                SyntaxHighlightToken token = new SyntaxHighlightToken(documentRange.Start.ToInt(), documentRange.Length, _operatorProperties);
                if (!IsTokenOverlapped(tokenList, token))
                    tokenList.Add(token);
            }
            foreach (DocumentRange documentRange in _document.FindAll(CheckExpressionRegexpConsts.OperandRegex))
            {
                SyntaxHighlightToken token = new SyntaxHighlightToken(documentRange.Start.ToInt(), documentRange.Length, _operandProperties);
                if (!IsTokenOverlapped(tokenList, token))
                    tokenList.Add(token);
            }
            return tokenList.OrderBy(t => t.Start).ToList();
        } 

        private bool IsTokenOverlapped(List<SyntaxHighlightToken> tokenList, SyntaxHighlightToken token)
        {
            return tokenList.Any(syntaxHighlightToken => token.Start >= syntaxHighlightToken.Start && token.End <= syntaxHighlightToken.End);
        }

        public void ForceExecute()
        {
            Execute();
        }

        public void Execute()
        {
            if (_editControl.IsLoading)
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                List<SyntaxHighlightToken> lineTokens = GetLineTokens();
                sw.Stop();
                Debug.WriteLine("Got line tokens in {0} ms", sw.ElapsedMilliseconds);

                sw.Start();
                _document.ApplySyntaxHighlight(lineTokens);
                sw.Stop();
                Debug.WriteLine("Syntax highight was apllied in {0} ms", sw.ElapsedMilliseconds);

                //sw.Start();
                //List<SyntaxHighlightToken> tokens = GetTokens();
                //sw.Stop();
                //Debug.WriteLine("Got tokens in {0} ms", sw.ElapsedMilliseconds);

                //sw.Start();
                //_document.ApplySyntaxHighlight(tokens);
                //sw.Stop();
                //Debug.WriteLine("Syntax highlight was apllied in {0} ms", sw.ElapsedMilliseconds);
            }
            else
            {
                ExecuteForCurrentLine();
            }
        }

        public void ExecuteForCurrentLine()
        {
            string currentLine = _editControl.CurrentLineText;
            List<SyntaxHighlightToken> lineTokens = GetLineTokenForLine(currentLine);
            _document.ApplySyntaxHighlight(lineTokens);

            List<SyntaxHighlightToken> tokens = GetTokensForLine(currentLine);
            _document.ApplySyntaxHighlight(tokens);
        }
    }

    public class SyntaxHighlightTokenComparer : IComparer<SyntaxHighlightToken>
    {
        public int Compare(SyntaxHighlightToken x, SyntaxHighlightToken y)
        {
            return x.Start - y.Start;
        }
    }
}
