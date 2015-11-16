using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

        public static string CamelCaseFirstLetter(this string value)
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }
            if (value.Length > 1)
                return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            return value.ToUpper();
        }

        public static string Join(this IEnumerable<object> value, string separator)
        {
            var result = "";
            var count = value.Count();
            if (count > 0)
                result = value.ElementAt(0).ToString();
            for (int i = 1; i < count; i++)
            {
                result += separator + value.ElementAt(i).ToString();
            }
            return result;
        }
    }
}
