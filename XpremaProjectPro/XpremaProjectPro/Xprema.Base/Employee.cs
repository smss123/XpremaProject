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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Contracts = new HashSet<Contract>();
        }
    
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeejobNumber { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeNationalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobilenumber { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
