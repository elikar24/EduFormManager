using System;
using System.Globalization;

namespace EduFormManager.Utils
{
    public static class MathUtility
    {
        public static double ParseStringDouble(string sValue)
        {
            CultureInfo[] cultureInfos = { CultureInfo.InvariantCulture, CultureInfo.CurrentCulture, new CultureInfo("en-US"), new CultureInfo("ru-RU") };
            double dValue = double.MinValue;
            foreach (CultureInfo cultureInfo in cultureInfos)
            {
                bool parsed = double.TryParse(sValue, NumberStyles.Float, cultureInfo, out dValue);
                if (parsed) break;
            }
            return dValue;
        }

        public static bool IsErrorDouble(double val)
        {
            return (int)Math.Round(val - double.MinValue, 0) == 0;
        }
    }
}
