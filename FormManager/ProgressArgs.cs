using System;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace EduFormManager.Utilities
{
    public class ProgressArgs
    {
        private int current = 0;
        private int max = 100;
        private Tuple<int, int> currMax;

        public ProgressArgs() 
        {
            currMax = new Tuple<int, int>(current, max);
        }

        public WindowsUIView View { get; set; }
        public Tuple<int, int> CurrentMaxPair 
        {
            get
            {
                return currMax;
            }
            set
            {
                currMax = value;
                current = value.Item1;
                max = value.Item2;
            }
        }

        public int Current 
        {
            get
            {
                return current;
            }
            set 
            {
                current = value;
                CurrentMaxPair = new Tuple<int, int>(current, max);
            } 
        }
        public int Max {
            get 
            { 
                return max; 
            }
            set
            {
                max = value;
                CurrentMaxPair = new Tuple<int, int>(current, max);
            }
        }
    }
}
