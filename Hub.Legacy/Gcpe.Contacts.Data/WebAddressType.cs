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
    
    public partial class WebAddressType
    {
        public WebAddressType()
        {
            this.CompanyWebAddresses = new HashSet<CompanyWebAddress>();
            this.ContactWebAddresses = new HashSet<ContactWebAddress>();
        }
    
        public System.Guid Id { get; set; }
        public string WebAddressTypeName { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<CompanyWebAddress> CompanyWebAddresses { get; set; }
        public virtual ICollection<ContactWebAddress> ContactWebAddresses { get; set; }
    }
}