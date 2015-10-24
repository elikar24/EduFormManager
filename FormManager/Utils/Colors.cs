using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using Models;

namespace EduFormManager.Utils
{
    public static class Colors
    {
        public static Dictionary<Status, Color> FormDataColors =
            new Dictionary<Status, Color>()
            {
                {Status.OK, Color.MediumPurple},
                {Status.Expired, Color.PaleVioletRed},
                {Status.WithErrors, Color.BurlyWood},
                {Status.WithErrors | Status.Expired, Color.SlateGray},
                {Status.Default, Color.FromArgb(0, 114, 198)},
                {Status.Unknown, Color.MediumSlateBlue}
            };

        public static Dictionary<Status, string> FormDataGroupText =
            new Dictionary<Status, string>()
            {
                {Status.OK, "ОК"},
                {Status.Expired, "Опоздания"},
                {Status.WithErrors, "Ошибки"},
                {Status.WithErrors | Status.Expired, "Ошибки и опоздания"},
                {Status.Default, "Пусто"},
                {Status.Unknown, "Остальные"}
            };

        public class RandomColor
        {
            private static RandomColor instance;

            private Random rand;
            private Type colorType;
            private PropertyInfo[] colorNames;

            protected RandomColor()
            {
                rand = new Random();
                colorType = typeof(Color);
                colorNames = colorType.GetProperties(BindingFlags.Static | BindingFlags.Public);
            }

            public Color Next()
            {
                Color color = Color.FromName(colorNames[rand.Next(0, colorNames.Length)].Name);
                return color;
            }

            public static RandomColor Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new RandomColor();
                    }
                    return instance;
                }
            }
        }

        public static Color RandomizedColor
        {
            get
            {
                return RandomColor.Instance.Next();
            }
        }
    }
}
