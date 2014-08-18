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
    
    public partial class ProjectProfile
    {
        public ProjectProfile()
        {
            this.Attachments = new List<Attachment>();
            this.Contracts = new List<Contract>();
            this.ProjectActivities = new List<ProjectActivity>();
            this.ProjectOrders = new List<ProjectOrder>();
            this.SubTheFinancerAndProjects = new List<SubTheFinancerAndProject>();
        }
    
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int progress { get; set; }
        public double TotalCost { get; set; }
        public Nullable<int> AccountID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual List<Attachment> Attachments { get; set; }
        public virtual List<Contract> Contracts { get; set; }
        public virtual List<ProjectActivity> ProjectActivities { get; set; }
        public virtual List<ProjectOrder> ProjectOrders { get; set; }
        public virtual List<SubTheFinancerAndProject> SubTheFinancerAndProjects { get; set; }
    }
}
