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
    
    public partial class View_AccountDetails
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public string Coin { get; set; }
        public Nullable<double> Balance { get; set; }
        public Nullable<double> AllDeposes { get; set; }
        public Nullable<double> AllWishdrowls { get; set; }
        public int ProcessID { get; set; }
        public System.DateTime DateOfTransaction { get; set; }
        public double TotalIn { get; set; }
        public double TotalOut { get; set; }
        public string Description { get; set; }
    }
}
