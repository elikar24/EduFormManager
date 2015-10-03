namespace EduFormManager.Forms.UserControls.FormulaEdit
{
    class ExpressionBuilder
    {
        public ExpressionBuilder()
        {
            LeftPart = string.Empty;
            RightPart = string.Empty;
            PartToAdd = string.Empty;
            Operator = "=";
        }
        public string LeftPart { get; set; }
        public string RightPart { get; set; }
        public string PartToAdd { get; set; }
        public string Operator { get; set; }
        public string AddToLeft()
        {
            return !string.IsNullOrEmpty(LeftPart)
                ? string.Format("{0} + {1} {3} {2}", LeftPart, PartToAdd, RightPart, Operator)
                : string.Format("{0} {2} {1}", PartToAdd, RightPart, Operator);
        }

        public string AddToRight()
        {
            return !string.IsNullOrEmpty(RightPart)
                ? string.Format("{0} {3} {2} + {1}", LeftPart, PartToAdd, RightPart, Operator)
                : string.Format("{0} {2} {1}", LeftPart, PartToAdd, Operator);
        }
    }
}
