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
    
    public partial class templated_form_data{
        public int templated_form_data_id { get; set; }
        public int form_id { get; set; }
        public byte[] file_data { get; set; }
    
        public virtual form form { get; set; }
    }
}
