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
    
    public partial class municipality{
        public municipality()
        {
            this.edus = new HashSet<edu>();
            this.municipality_form_data = new HashSet<municipality_form_data>();
        }
    
        public int municipality_id { get; set; }
        public string name { get; set; }
        public string @operator { get; set; }
        public string remark { get; set; }
    
    	public override string ToString() { return this.name; }
    
        public virtual ICollection<edu> edus { get; set; }
        public virtual ICollection<municipality_form_data> municipality_form_data { get; set; }
    }
}