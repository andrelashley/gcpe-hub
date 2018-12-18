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
    
    public partial class Sector
    {
        public Sector()
        {
            this.Companies = new HashSet<Company>();
            this.Contacts = new HashSet<Contact>();
        }
    
        public System.Guid Id { get; set; }
        public string Key { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public string DisplayName { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string MiscHtml { get; set; }
        public string MiscRightHtml { get; set; }
        public string TwitterUsername { get; set; }
        public string FlickrUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string AudioUrl { get; set; }
        public string FacebookEmbedHtml { get; set; }
        public string YoutubeEmbedHtml { get; set; }
        public string AudioEmbedHtml { get; set; }
        public Nullable<System.Guid> TopReleaseId { get; set; }
        public Nullable<System.Guid> FeatureReleaseId { get; set; }
    
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}