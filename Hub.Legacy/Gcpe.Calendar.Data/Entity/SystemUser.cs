//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CorporateCalendar.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemUser()
        {
            this.Activities = new HashSet<Activity>();
            this.Activities1 = new HashSet<Activity>();
            this.ActivityCategories = new HashSet<ActivityCategory>();
            this.ActivityCategories1 = new HashSet<ActivityCategory>();
            this.ActivityCommunicationMaterials = new HashSet<ActivityCommunicationMaterial>();
            this.ActivityCommunicationMaterials1 = new HashSet<ActivityCommunicationMaterial>();
            this.ActivityFilters = new HashSet<ActivityFilter>();
            this.ActivityFilters1 = new HashSet<ActivityFilter>();
            this.ActivityNROrigins = new HashSet<ActivityNROrigin>();
            this.ActivityNROrigins1 = new HashSet<ActivityNROrigin>();
            this.ActivitySectors = new HashSet<ActivitySector>();
            this.ActivitySectors1 = new HashSet<ActivitySector>();
            this.ActivitySharedWiths = new HashSet<ActivitySharedWith>();
            this.ActivitySharedWiths1 = new HashSet<ActivitySharedWith>();
            this.CommunicationContacts = new HashSet<CommunicationContact>();
            this.Logs = new HashSet<Log>();
            this.Logs1 = new HashSet<Log>();
            this.NewsFeeds = new HashSet<NewsFeed>();
            this.NewsFeeds1 = new HashSet<NewsFeed>();
            this.SystemUser1 = new HashSet<SystemUser>();
            this.SystemUser11 = new HashSet<SystemUser>();
            this.SystemUserMinistries = new HashSet<SystemUserMinistry>();
            this.SystemUserMinistries1 = new HashSet<SystemUserMinistry>();
            this.SystemUserMinistries2 = new HashSet<SystemUserMinistry>();
            this.ActivityInitiatives = new HashSet<ActivityInitiative>();
            this.FavoriteActivities = new HashSet<Activity>();
            this.ContactUser = new HashSet<Ministry>();
            this.EodLastRunUser = new HashSet<Ministry>();
            this.SecondContactUser = new HashSet<Ministry>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
        public System.Guid RowGuid { get; set; }
        public Nullable<int> FilterDisplayValue { get; set; }
        public string HiddenColumns { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCategory> ActivityCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCategory> ActivityCategories1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCommunicationMaterial> ActivityCommunicationMaterials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCommunicationMaterial> ActivityCommunicationMaterials1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityFilter> ActivityFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityFilter> ActivityFilters1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityNROrigin> ActivityNROrigins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityNROrigin> ActivityNROrigins1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySector> ActivitySectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySector> ActivitySectors1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySharedWith> ActivitySharedWiths { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySharedWith> ActivitySharedWiths1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommunicationContact> CommunicationContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Logs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Logs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsFeed> NewsFeeds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsFeed> NewsFeeds1 { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUser> SystemUser1 { get; set; }
        public virtual SystemUser SystemUser2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUser> SystemUser11 { get; set; }
        public virtual SystemUser SystemUser3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserMinistry> SystemUserMinistries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserMinistry> SystemUserMinistries1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserMinistry> SystemUserMinistries2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityInitiative> ActivityInitiatives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> FavoriteActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ministry> ContactUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ministry> EodLastRunUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ministry> SecondContactUser { get; set; }
    }
}