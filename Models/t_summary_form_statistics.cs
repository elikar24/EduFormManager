//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_summary_form_statistics{
        public long row_id { get; set; }
        public int municipality_id { get; set; }
        public string municipality_title { get; set; }
        public long overall_count { get; set; }
        public long loaded_count { get; set; }
        public long ok_count { get; set; }
        public long expired_count { get; set; }
        public long error_count { get; set; }
        public long bad_count { get; set; }
    }
}