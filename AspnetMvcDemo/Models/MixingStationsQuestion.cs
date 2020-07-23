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
    
    public partial class MixingStationsQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MixingStationsQuestion()
        {
            this.MixingStationsAnswersOfFactories = new HashSet<MixingStationsAnswersOfFactory>();
        }
    
        public int ID { get; set; }
        public string SubType_Arabic { get; set; }
        public string SubType_English { get; set; }
        public string Description { get; set; }
        public int MixingStationsTypesId { get; set; }
        public string InputFieldType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MixingStationsAnswersOfFactory> MixingStationsAnswersOfFactories { get; set; }
        public virtual MixingStationsType MixingStationsType { get; set; }
    }
}
