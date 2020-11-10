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
    
    public partial class Activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activity()
        {
            this.ActivityCategories = new HashSet<ActivityCategory>();
            this.ActivityCommunicationMaterials = new HashSet<ActivityCommunicationMaterial>();
            this.ActivityNROrigins = new HashSet<ActivityNROrigin>();
            this.ActivitySectors = new HashSet<ActivitySector>();
            this.ActivitySharedWiths = new HashSet<ActivitySharedWith>();
            this.Logs = new HashSet<Log>();
            this.NewsFeeds = new HashSet<NewsFeed>();
            this.ActivityThemes = new HashSet<ActivityTheme>();
            this.ActivityInitiatives = new HashSet<ActivityInitiative>();
            this.FavoriteUsers = new HashSet<SystemUser>();
            this.ActivityKeywords = new HashSet<ActivityKeyword>();
            this.ActivityFiles = new HashSet<ActivityFile>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Comments { get; set; }
        public string HqComments { get; set; }
        public string LeadOrganization { get; set; }
        public string Venue { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> NRDistributionId { get; set; }
        public Nullable<int> PremierRequestedId { get; set; }
        public Nullable<System.Guid> ContactMinistryId { get; set; }
        public Nullable<int> GovernmentRepresentativeId { get; set; }
        public Nullable<int> CommunicationContactId { get; set; }
        public Nullable<int> EventPlannerId { get; set; }
        public Nullable<int> VideographerId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string OtherCity { get; set; }
        public bool IsActive { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsAtLegislature { get; set; }
        public bool IsConfidential { get; set; }
        public bool IsCrossGovernment { get; set; }
        public bool IsTitleNeedsReview { get; set; }
        public bool IsDetailsNeedsReview { get; set; }
        public bool IsRepresentativeNeedsReview { get; set; }
        public bool IsCityNeedsReview { get; set; }
        public bool IsStartDateNeedsReview { get; set; }
        public bool IsEndDateNeedsReview { get; set; }
        public bool IsCategoriesNeedsReview { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
        public Nullable<System.Guid> RowGuid { get; set; }
        public bool IsActiveNeedsReview { get; set; }
        public string Schedule { get; set; }
        public string Significance { get; set; }
        public bool IsIssue { get; set; }
        public Nullable<System.DateTime> NRDateTime { get; set; }
        public string PotentialDates { get; set; }
        public bool IsMilestone { get; set; }
        public string Strategy { get; set; }
        public Nullable<int> HqStatusId { get; set; }
        public int HqSection { get; set; }
        public bool IsCommMaterialsNeedsReview { get; set; }
        public string Translations { get; set; }
        public bool IsSignificanceNeedsReview { get; set; }
        public bool IsStrategyNeedsReview { get; set; }
        public bool IsSchedulingConsiderationsNeedsReview { get; set; }
        public bool IsInternalNotesNeedsReview { get; set; }
        public bool IsLeadOrganizationNeedsReview { get; set; }
        public bool IsInitiativesNeedsReview { get; set; }
        public bool IsTagsNeedsReview { get; set; }
        public bool IsOriginNeedsReview { get; set; }
        public bool IsDistributionNeedsReview { get; set; }
        public bool IsTranslationsRequiredNeedsReview { get; set; }
        public bool IsPremierRequestedNeedsReview { get; set; }
        public bool IsVenueNeedsReview { get; set; }
        public bool IsEventPlannerNeedsReview { get; set; }
        public bool IsDigitalNeedsReview { get; set; }
    
        public virtual City City { get; set; }
        public virtual CommunicationContact CommunicationContact { get; set; }
        public virtual EventPlanner EventPlanner { get; set; }
        public virtual GovernmentRepresentative GovernmentRepresentative { get; set; }
        public virtual NRDistribution NRDistribution { get; set; }
        public virtual PremierRequested PremierRequested { get; set; }
        public virtual Status Status { get; set; }
        public virtual SystemUser SystemUser { get; set; }
        public virtual SystemUser SystemUser1 { get; set; }
        public virtual Videographer Videographer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCategory> ActivityCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCommunicationMaterial> ActivityCommunicationMaterials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityNROrigin> ActivityNROrigins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySector> ActivitySectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySharedWith> ActivitySharedWiths { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Logs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsFeed> NewsFeeds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityTheme> ActivityThemes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityInitiative> ActivityInitiatives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUser> FavoriteUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityKeyword> ActivityKeywords { get; set; }
        public virtual Status Status1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityFile> ActivityFiles { get; set; }
        public virtual Ministry Ministry { get; set; }
    }
}