//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduFormManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class answer
    {
        public int answer_id { get; set; }
        public string answer_title { get; set; }
        public Nullable<int> question_id { get; set; }
        public Nullable<int> answer_type { get; set; }
    
        public virtual question question { get; set; }
    }
}
