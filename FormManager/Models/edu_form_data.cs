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
    
    public partial class edu_form_data : IForm
    {
        public int id { get; set; }
        public int document_format_id { get; set; }
        public int form_id { get; set; }
        public int edu_id { get; set; }
        public System.DateTime send_date { get; set; }
        public Nullable<int> status { get; set; }
        public int file_id { get; set; }
    
        public virtual document_format document_format { get; set; }
        public virtual edu edu { get; set; }
        public virtual form form { get; set; }
        public virtual file file { get; set; }
    }
}
