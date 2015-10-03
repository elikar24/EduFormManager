using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduFormManager.Utils
{
    public static class AttachedProperty
    {
        private static Dictionary<WeakReference, Dictionary<string, object>> Values = new Dictionary<WeakReference, Dictionary<string, object>>();

        private static WeakReference GetKey(object o)
        {
            List<WeakReference> list = new List<WeakReference>();
            try
            {
                foreach (WeakReference weakReference in Values.Keys)
                {
                    if (!weakReference.IsAlive)
                        list.Add(weakReference);
                    else if (weakReference.Target == o)
                        return weakReference;
                }
                WeakReference key = new WeakReference(o);
                Values.Add(key, new Dictionary<string, object>());
                return key;
            }
            finally
            {
                foreach (WeakReference key in list)
                    Values.Remove(key);
            }
        }

        public static void SetAttachedProperty(this object o, string name, object value)
        {
            WeakReference key = GetKey(o);
            Dictionary<string, object> dictionary = Values[key];
            if (dictionary.ContainsKey(name))
                dictionary[name] = value;
            else
                dictionary.Add(name, value);
        }

        public static object GetAttachedProperty(this object o, string name)
        {
            WeakReference key = GetKey(o);
            object obj;
            if (Values[key].TryGetValue(name, out obj))
                return obj;
            return null;
        }
    }
}
