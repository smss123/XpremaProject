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
    
    public partial class ProjectOrder
    {
        public ProjectOrder()
        {
            this.Attachments = new List<Attachment>();
        }
    
        public int ID { get; set; }
        public string OrderTitle { get; set; }
        public string OrderBody { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int ProjectProfile_ID { get; set; }

        public virtual List<Attachment> Attachments { get; set; }
        public virtual ProjectProfile ProjectProfile { get; set; }
    }
}
