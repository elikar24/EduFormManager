using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using EduFormManager.Properties;
using Models;

namespace EduFormManager.Utils
{
    public static class Colors
    {
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
