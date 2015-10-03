using System.Collections.Generic;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public class QueryGroupItem
    {
        public string Head { get; set; }

        /// <summary>
        /// Stores dictionary represents part of query's name and query which it references 
        /// </summary>
        public IDictionary<string, query> QueryDictionary { get; set; } 
    }
}
