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
    
    public partial class PhoneType
    {
        public PhoneType()
        {
            this.CompanyPhoneNumbers = new HashSet<CompanyPhoneNumber>();
            this.ContactPhoneNumbers = new HashSet<ContactPhoneNumber>();
        }
    
        public System.Guid Id { get; set; }
        public string PhoneTypeName { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<CompanyPhoneNumber> CompanyPhoneNumbers { get; set; }
        public virtual ICollection<ContactPhoneNumber> ContactPhoneNumbers { get; set; }
    }
}
