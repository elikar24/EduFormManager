using System.Drawing;
using System.Text.RegularExpressions;

namespace EduFormManager
{
    public static class CheckExpressionRegexpConsts
    {
        public const string EXP_PART_WORKSHEET_REGEXP = @"(?<Workbook>((?([\w\s\.,\d]*?(?=!))[\w\s\.,\d]*?(?=!)|(?<=')([\w\s\.,\d]*?)(?='!))))"; //(?(pattern)yes|no)
        public const string EXP_PART_CELL_REGEXP = @"(?<Cell>(?<=!)\$[A-Z]+\$\d+(?=\s*|$))";

        public const string EXP_PARSER_EXPRESSION_REGEXP = @"^(?<FirstCellLeft>('?([\w\s\.,\d]*?)'?!\$[A-Z]+\$\d+))((?<Sign>\s*[\+|-]\s*)(?<Cell>('?([\w\s\.,\d]*?)'?!\$[A-Z]+\$\d+))){0,}\s*(?<SignEq>\<\=|\>\=|\=|\<|\>)\s*(?<FirstCellRight>('?([\w\s\.,\d]*?)'?!\$[A-Z]+\$\d+))((?<Sign>\s*[\+|-]\s*)(?<Cell>('?([\w\s\.,\d]*?)'?!\$[A-Z]+\$\d+))){0,}$";
        public const string EXP_PARSER_OPERAND_REGEXP = @"('?([\w\s\.,\d]*?)'?!\$[A-Z]+\$\d+)";
        public const string EXP_PARSER_OPERATOR_REGEXP = @"([\+|-])|(\<\=|\>\=|\=|\<|\>)";
        public static readonly string[] OPERATORS = { "<=", ">=", "=", ">", "<", "\\+" };

        public static readonly Color BadLineBackColor = Color.FromArgb(205, 52, 52);
        public static readonly Color OperandTextColor = Color.FromArgb(130, 167, 207);
        public static readonly Color OperatorTextColor = Color.FromArgb(175, 97, 0);

        public static Regex OperatorRegex = new Regex(EXP_PARSER_OPERATOR_REGEXP);
        public static Regex OperandRegex = new Regex(EXP_PARSER_OPERAND_REGEXP);
    }
}
