using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using NLog;

namespace EduFormManager.Utilities
{
    public static class FormulaUtility
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static async Task<CheckExpressionResultCollection> GetCheckResultsAsync(byte[] checkfileData, Encoding encoding, IWorkbook document)
        {
            CheckExpressionResultCollection resultList = new CheckExpressionResultCollection();
            try
            {
                using (Stream ms = new MemoryStream(checkfileData))
                {
                    IList<CheckExpression> expList = await Task.Run(() => CheckExpressionParser.ParseStream(ms, encoding, document));
                    document.BeginUpdate();
                    foreach (CheckExpression exp in expList)
                    {
                        try
                        {
                            CheckExpressionResult result = exp.Result;
                            if (!result.Ok)
                            {
                                resultList.Add(result);
                            }

                            foreach (var cell in result.Cells)
                            {
                                cell.Fill.BackgroundColor = result.Color;
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex.Message);
                            continue;
                        }
                        string diagnosticMessageString = String.Format("{0} {3} {1} ; left part: {0} ; right part: {1} ; Expression: {2}",
                            exp.LeftPart.Result, exp.RightPart.Result, exp.InitialExpressionString, Enum.Format(typeof(CheckExpression.OperatorType), exp.Operator, "g"));
                        Debug.Print(diagnosticMessageString);
                        //logger.Info(diagnosticMessageString);
                    }
                    foreach (var result in resultList)
                    {
                        foreach (var cell in result.Cells)
                        {
                            cell.Fill.BackgroundColor = result.Color;
                        }
                    }
                    document.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                logger.Fatal<Exception>(ex);
            }
            return resultList;
        }

        //public static async Task<IDictionary<string, object>> GetMunicipalityFormulaResultsAsync(byte[] formulaData, )
    }
}
