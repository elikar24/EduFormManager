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
    
    public partial class file{
        public file()
        {
            this.edu_form_data = new HashSet<edu_form_data>();
            this.municipality_form_data = new HashSet<municipality_form_data>();
        }
    
        public int file_id { get; set; }
        public byte[] contents { get; set; }
        public int code_page { get; set; }
    
        public virtual ICollection<edu_form_data> edu_form_data { get; set; }
        public virtual ICollection<municipality_form_data> municipality_form_data { get; set; }
    }
}
