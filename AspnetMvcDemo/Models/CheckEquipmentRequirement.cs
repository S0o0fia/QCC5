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
    
    public partial class CheckEquipmentRequirement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckEquipmentRequirement()
        {
            this.CheckEquipmentRequirementsOfFactories = new HashSet<CheckEquipmentRequirementsOfFactory>();
        }
    
        public int ID { get; set; }
        public string SubType_Arabic { get; set; }
        public string SubType_English { get; set; }
        public string InputFieldType { get; set; }
        public string Description { get; set; }
        public int EquipmentRequirementsTypeId { get; set; }
    
        public virtual EquipmentRequirementsType EquipmentRequirementsType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckEquipmentRequirementsOfFactory> CheckEquipmentRequirementsOfFactories { get; set; }
    }
}
