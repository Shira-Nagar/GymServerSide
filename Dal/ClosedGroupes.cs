//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClosedGroupes
    {
        public int team_id { get; set; }
        public string name { get; set; }
        public string descripition { get; set; }
        public int trainig_id { get; set; }
    
        public virtual Training Training { get; set; }
    }
}