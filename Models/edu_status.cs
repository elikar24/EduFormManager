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
    
    public partial class edu_status{
        public edu_status()
        {
            this.edus = new HashSet<edu>();
        }
    
        public int edu_status_id { get; set; }
        public string name { get; set; }
    
    	public override string ToString() { return this.name; }
    
        public virtual ICollection<edu> edus { get; set; }
    }
}
