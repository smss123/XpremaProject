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
    
    public partial class Thefinancier
    {
        public Thefinancier()
        {
            this.SubTheFinancerAndProjects = new List<SubTheFinancerAndProject>();
        }
    
        public int ID { get; set; }
        public string financiername { get; set; }
        public string PhoneNumber { get; set; }
        public string agentName { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Adderss { get; set; }
        public int AccountID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual List<SubTheFinancerAndProject> SubTheFinancerAndProjects { get; set; }
    }
}
