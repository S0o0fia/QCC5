//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspnetMvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.Pledges = new HashSet<Pledge>();
        }
    
        public int Id { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string Location_Arabic { get; set; }
        public string Location_English { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pledge> Pledges { get; set; }
    }
}
