using System.Collections.Generic;

namespace EduFormManager
{
    public static class Notifications
    {
        public class ExpireWarn
        {
            public int DaysRemain { get; set; }
            public string MessageText { get; set; }
            public string FormName { get; set; }
            public override string ToString()
            {
                if (!string.IsNullOrEmpty(this.MessageText))
                {
                    return this.MessageText;
                }
                else
                {
                    string msg = "";
                    if (DaysRemain == 0)
                    {
                        msg = string.Format("Форму {0} необходимо сдать сегодня", FormName);
                    }
                    else
                    {
                        msg = string.Format("До сдачи формы {0} осталось {1} ", FormName, DaysRemain);
                        if ((DaysRemain > 4 && DaysRemain < 21) || (DaysRemain % 10 > 4 && DaysRemain % 10 <= 9) || (DaysRemain % 10 == 0))
                            msg += "дней";
                        else if ((DaysRemain > 1 && DaysRemain < 5) || (DaysRemain % 10 > 1 && DaysRemain % 10 < 5))
                            msg += "дня";
                        else
                            msg += "дней";
                    }
                    return msg;
                }
            }
        }

        private static List<object> m_list = new List<object>();

        public static void Add(object msg)
        {
            if (m_list.Contains(msg))
                return;
            m_list.Add(msg);
        }
        public static void Remove(object msg)
        {
            if (!m_list.Contains(msg))
                return;
            m_list.Remove(msg);
        }
        public static void Clear()
        {
            m_list.Clear();

        }

        public static List<object> List
        {
            get
            {
                return m_list;
            }
        }
    }
}
