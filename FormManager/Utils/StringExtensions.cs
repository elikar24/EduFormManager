using System;
using System.Globalization;

namespace EduFormManager.Utils
{
    public static class StringExtensions
    {
        public static double ParseDouble(this string sValue)
        {
            CultureInfo[] cultureInfos = { CultureInfo.InvariantCulture, CultureInfo.CurrentCulture, new CultureInfo("en-US"), new CultureInfo("ru-RU") };
            var dValue = double.MinValue;
            foreach (var cultureInfo in cultureInfos)
            {
                var parsed = double.TryParse(sValue, NumberStyles.Float, cultureInfo, out dValue);
                if (parsed) break;
            }
            return dValue;
        }

        public static bool IsErrorDouble(this double val)
        {
            return (int)Math.Round(val - double.MinValue, 0) == 0;
        }

        public static string Truncate(this string value, int maxChars)
        {
            return value.Length <= maxChars 
                ? value 
                : value.Substring(0, maxChars) + "..";
        }
    }
}
