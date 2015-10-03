using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using DevExpress.Spreadsheet;
using NLog;

namespace EduFormManager
{
    public static class CheckExpressionParser
    {
        private static Regex expressionRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_EXPRESSION_REGEXP);

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static bool IsLastCheckFileHadErrors { get; private set; }

        public static IList<CheckExpression> ParseStream(Stream s, Encoding encoding, IWorkbook workbook)
        {
            logger.Info("Читаем из потока");
            IsLastCheckFileHadErrors = false;
            List<CheckExpression> expList = new List<CheckExpression>();
            using (StreamReader sr = new StreamReader(s, encoding))
            {
                for (int i = 0; !sr.EndOfStream; i++ )
                {
                    string line = sr.ReadLine();
                    string expLine = line == null ? string.Empty : line.Trim();
                    if (String.IsNullOrEmpty(expLine))
                    {
                        logger.Info("Пустая строка - пропускаем. Номер строки " + i);
                        continue;
                    }
                    logger.Info("Начинаю парсинг формулы '{0}'. Номер строки {1}", expLine, i);
                    CheckExpression exp = Parse(expLine, workbook);
                    if (exp != null)
                    {
                        expList.Add(exp);
                        logger.Info("Запарсил формулу '{0}'. Номер строки {1}", expLine, i);
                    }
                    else
                    {
                        logger.Error("Пропускаем формулу '{0}'. Номер строки {1}", expLine, i);
                        IsLastCheckFileHadErrors = true;
                    }
                }
            }
            return expList;
        }

        public static CheckExpression Parse(string exp, IWorkbook workbook)
        {
            CheckExpression resultExp = new CheckExpression(workbook);
            if (!expressionRegex.IsMatch(exp))
            {
                logger.Error("Выражение записано неверно.", exp);
                return null;
            }
            Match expressionMatch = expressionRegex.Match(exp);

            resultExp.LeftPart = GetPart(resultExp, expressionMatch, "Left");
            resultExp.RightPart = GetPart(resultExp, expressionMatch, "Right");

            string operatorChar = expressionMatch.Groups["SignEq"].Value.Trim();
            resultExp.Operator = GetOperator(operatorChar);
            resultExp.InitialExpressionString = exp;
            return (resultExp.RightPart == null || resultExp.LeftPart == null) ? null : resultExp;
        }

        private static CheckExpression.ExpressionPart GetPart(CheckExpression expression, Match match, string partToken)
        {
            CheckExpression.ExpressionPart part = new CheckExpression.ExpressionPart(expression);
            int signEqIndex = match.Groups["SignEq"].Index;
            int firstCellIndex = match.Groups["FirstCell" + partToken].Index;
            string firstCellA1 = match.Groups["FirstCell" + partToken].Value.Trim();
            part.A1References.Add(firstCellA1);
            switch (partToken)
            {
                case "Left":
                    {
                        CaptureCollection captures = match.Groups["Cell"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index < signEqIndex)
                            {
                                part.A1References.Add(captures[i].Value.Trim());
                            }
                        }

                        captures = match.Groups["Sign"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index < signEqIndex)
                            {
                                part.Signs.Add(captures[i].Value.Trim());
                            }
                        }
                    }
                    break;
                case "Right":
                    {
                        CaptureCollection captures = match.Groups["Cell"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index > signEqIndex)
                            {
                                part.A1References.Add(captures[i].Value.Trim());
                            }
                        }
                        captures = match.Groups["Sign"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index > signEqIndex)
                            {
                                part.Signs.Add(captures[i].Value.Trim());
                            }
                        }
                    }
                    break;
            }

            return part;
        }

        private static CheckExpression.OperatorType GetOperator(string operatorChar)
        {
            switch (operatorChar)
            {
                case "=":
                    return CheckExpression.OperatorType.eq;
                case ">":
                    return CheckExpression.OperatorType.g;
                case "<":
                    return CheckExpression.OperatorType.l;
                case ">=":
                    return CheckExpression.OperatorType.ge;
                case "<=":
                    return CheckExpression.OperatorType.le;
                default:
                    logger.Error("Не нашел подходящего оператора, использую по умолчанию '='");
                    return CheckExpression.OperatorType.eq;
            }
        }
    }
}
