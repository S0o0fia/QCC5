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
    
    public partial class FactoryEquipment
    {
        public int ID { get; set; }
        public Nullable<int> FactoryId { get; set; }
        public Nullable<int> Serial { get; set; }
        public string EquipmentName { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public Nullable<int> EquipWorking { get; set; }
        public Nullable<int> EquipNoWorking { get; set; }
        public Nullable<int> EquipSpare { get; set; }
        public string Notes { get; set; }
    }
}
