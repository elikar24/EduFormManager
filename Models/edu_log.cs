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
    
    public partial class edu_log{
        public int id { get; set; }
        public System.DateTime created { get; set; }
        public int action_id { get; set; }
        public string message { get; set; }
    
        public virtual action action { get; set; }
    }
}
