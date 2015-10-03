﻿using System.Threading;

namespace EduFormManager.Utils
{
    public static class GuiHelper
    {
        public class FormStatusCount
        {
            public FormStatusCount()
            {
                FormsOkCount = 0;
                FormsWithBothCount = 0;
                FormsWithErrorsCount = 0;
                FormsWithExpiredDateCount = 0;
            }
            public int FormsOkCount;
            public int FormsWithErrorsCount;
            public int FormsWithExpiredDateCount;
            public int FormsWithBothCount;
        }
        
        
        public static SynchronizationContext GuiThreadContext 
        { 
            get;
            set;
        }
    }
}
                                                                                                                                                                                                    