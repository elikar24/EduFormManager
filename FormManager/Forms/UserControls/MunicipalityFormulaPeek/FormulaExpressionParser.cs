using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NLog;

namespace EduFormManager.Forms.UserControls.MunicipalityFormulaPeek
{
    public class FormulaExpressionParser
    {
        private static readonly Regex ExpressionRegex = new Regex(CheckExpressionRegexpConsts.EXP_PARSER_EXPRESSION_REGEXP);

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static bool IsLastCheckFileHadErrors { get; private set; }

        public static IList<FormulaExpression> ParseStream(Stream s)
        {
            Logger.Info("Читаем из потока");
            IsLastCheckFileHadErrors = false;
            IList<FormulaExpression> expList = new List<FormulaExpression>();
            using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
            {
                for (int i = 0; !sr.EndOfStream; i++)
                {
                    string expLine = sr.ReadLine();
                    if (String.IsNullOrEmpty(expLine))
                    {
                        Logger.Info("Пустая строка - пропускаем. Номер строки " + i);
                        continue;
                    }
                    Logger.Info("Начинаю парсинг формулы '{0}'. Номер строки {1}", expLine, i);
                    FormulaExpression exp = Parse(expLine);
                    if (exp != null)
                    {
                        expList.Add(exp);
                        Logger.Info("Запарсил формулу '{0}'. Номер строки {1}", expLine, i);
                    }
                    else
                    {
                        Logger.Info("Пропускаем формулу '{0}'. Номер строки {1}", expLine, i);
                        IsLastCheckFileHadErrors = true;
                    }
                }    
            }
            return expList;
        }

        public static FormulaExpression Parse(string exp)
        {
            FormulaExpression resultExp = new FormulaExpression();
            if (!ExpressionRegex.IsMatch(exp))
            {
                Logger.Error("Выражение записано неверно.", exp);
                return null;
            }
            Match expressionMatch = ExpressionRegex.Match(exp);
            GetPart(resultExp, expressionMatch, "Left");
            GetPart(resultExp, expressionMatch, "Right");
            //string operatorChar = expressionMatch.Groups["SignEq"].Value.Trim();
            resultExp.ExpressionString = exp;
            return resultExp;
        }

        private static void GetPart(FormulaExpression expression, Match match, string partToken)
        {
            int signEqIndex = match.Groups["SignEq"].Index;
            int firstCellIndex = match.Groups["FirstCell" + partToken].Index;
            string firstCellA1 = match.Groups["FirstCell" + partToken].Value.Trim();

            FormulaExpression.FormulaExpressionPart part = partToken == "Left"
                ? expression.TargetPart
                : expression.SourcePart;
            part.A1References.Add(firstCellA1);

            switch (partToken)
            {
                case "Left":
                    {
                        CaptureCollection captures = match.Groups["Cell"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index < signEqIndex)
                                part.A1References.Add(captures[i].Value.Trim());
                        }

                        captures = match.Groups["Sign"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index < signEqIndex)
                                part.Signs.Add(captures[i].Value.Trim());
                        }
                    }
                    break;
                case "Right":
                    {
                        CaptureCollection captures = match.Groups["Cell"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index > signEqIndex)
                                part.A1References.Add(captures[i].Value.Trim());
                        }
                        captures = match.Groups["Sign"].Captures;
                        for (int i = 0; i < captures.Count; i++)
                        {
                            if (captures[i].Index > firstCellIndex && captures[i].Index > signEqIndex)
                                part.Signs.Add(captures[i].Value.Trim());
                        }
                    }
                    break;
            }
        }
    }
}
