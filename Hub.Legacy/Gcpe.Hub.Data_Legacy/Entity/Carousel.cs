//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gcpe.Hub.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carousel
    {
        public Carousel()
        {
            this.CarouselSlides = new HashSet<CarouselSlide>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.DateTimeOffset> PublishDateTime { get; set; }
        public System.DateTimeOffset Timestamp { get; set; }
    
        public virtual ICollection<CarouselSlide> CarouselSlides { get; set; }
    }
}
