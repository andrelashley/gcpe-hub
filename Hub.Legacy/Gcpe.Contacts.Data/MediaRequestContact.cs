//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaRelationsDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MediaRequestContact
    {
        public System.Guid MediaRequestId { get; set; }
        public System.Guid ContactId { get; set; }
        public System.Guid CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual MediaRequest MediaRequest { get; set; }
    }
}