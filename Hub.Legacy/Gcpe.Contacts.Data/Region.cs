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
    
    public partial class Region
    {
        public Region()
        {
            this.Companies = new HashSet<Company>();
            this.Contacts = new HashSet<Contact>();
        }
    
        public System.Guid Id { get; set; }
        public string RegionName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}