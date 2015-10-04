using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;

namespace EduFormManager.Forms.UserControls.FormulaEdit
{
    public partial class FormulaEditControl : UserControl
    {
        private int _lastLineStart = 0;

        public FormulaEditControl()
        {
            InitializeComponent();
            this.richEditControl.ReplaceService<ISyntaxHighlightService>(new SyntaxHighlight(this, SynchronizationContext.Current));
            this.IsLoading = false;
            this.TextModified = false;

            this.richEditControl.SelectionChanged += (sender, args) =>
            {
                Paragraph paragraph = this.Document.Paragraphs.Get(this.Document.CaretPosition);
                int lineStart = paragraph.Range.Start.ToInt();
                if (lineStart != _lastLineStart)
                {
                    this.richEditControl.GetService<ISyntaxHighlightService>().Execute();
                    _lastLineStart = lineStart;
                }
            };
            this.richEditControl.TextChanged += (sender, args) => TextModified = true;
        }

        public bool TextModified { get; private set; }
        public bool IsLoading { get; private set; }
        public Document Document { get { return this.richEditControl.Document; } }

        public String CurrentLineText
        {
            get
            {
                string text = richEditControl.Document.GetText(this.CurrentLineDocumentRange);
                return text;
            }
        }

        private DocumentRange CurrentLineDocumentRange
        {
            get
            {
                Paragraph paragraph = this.Document.Paragraphs.Get(this.Document.CaretPosition);
                DocumentRange range = Document.CreateRange(paragraph.Range.Start, paragraph.Range.Length - 1);
                return range;
            }
        }

        public void AddToLeftPart(IList<Range> cellRangeList)
        {
            ExpressionBuilder expressionBuilder = ExpressionBuilderFactory.CreateExpressionBuilder(cellRangeList, this.CurrentLineText);
            if (expressionBuilder != null)
            {
                this.richEditControl.Document.Replace(this.CurrentLineDocumentRange, expressionBuilder.AddToLeft());
                this.TextModified = true;
            }
        }

        public void ReplaceLeftPart(IList<Range> cellRangeList)
        {
            ExpressionBuilder expressionBuilder = ExpressionBuilderFactory.CreateExpressionBuilder(cellRangeList, this.CurrentLineText);
            if (expressionBuilder != null)
            {
                expressionBuilder.LeftPart = string.Empty;
                this.richEditControl.Document.Replace(this.CurrentLineDocumentRange, expressionBuilder.AddToLeft());
                this.TextModified = true;
            }
        }

        public void AddToRightPart(IList<Range> cellRangeList)
        {
            ExpressionBuilder expressionBuilder = ExpressionBuilderFactory.CreateExpressionBuilder(cellRangeList, this.CurrentLineText);
            if (expressionBuilder != null)
            {
                this.richEditControl.Document.Replace(this.CurrentLineDocumentRange, expressionBuilder.AddToRight());
                this.TextModified = true;
            }
        }

        public void ReplaceRightPart(IList<Range> cellRangeList)
        {
            ExpressionBuilder expressionBuilder = ExpressionBuilderFactory.CreateExpressionBuilder(cellRangeList, this.CurrentLineText);
            if (expressionBuilder != null)
            {
                expressionBuilder.RightPart = string.Empty;
                this.richEditControl.Document.Replace(this.CurrentLineDocumentRange, expressionBuilder.AddToRight());
                this.TextModified = true;
            }
        }

        public new string Text
        {
            get { return this.richEditControl.Text; }
            set
            {
                this.TextModified = false;
                this.IsLoading = true;
                this.richEditControl.Text = value;
                this.IsLoading = false;
            }
        }
    }
}
