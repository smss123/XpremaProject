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
    
    public partial class GroupPermession
    {
        public int Id { get; set; }
        public bool permessionValue { get; set; }
        public int SystemPermession_Id { get; set; }
        public int UserGroup_Id { get; set; }
    
        public virtual SystemPermession SystemPermession { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
