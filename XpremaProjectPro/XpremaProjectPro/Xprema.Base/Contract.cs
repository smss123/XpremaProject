//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xprema.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int ID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public double SelaryAmount { get; set; }
        public bool Status { get; set; }
        public Nullable<int> EmplyeeAccount_ID { get; set; }
        public int Employee_ID { get; set; }
        public int ProjectProfile_ID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual UserSystem UserSystem { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ProjectProfile ProjectProfile { get; set; }
    }
}
