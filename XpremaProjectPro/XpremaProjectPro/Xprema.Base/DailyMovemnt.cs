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
    
    public partial class DailyMovemnt
    {
        public int ID { get; set; }
        public int FromAccout { get; set; }
        public int ToAccount { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime DateOfProcess { get; set; }
    }
}
