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
    
    public partial class TechnicalReport
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public string laboTechStaff { get; set; }
        public string ProductQuality { get; set; }
        public string FactoryWarnings { get; set; }
        public string ProceduresRequired { get; set; }
        public int FactoryId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string Approval { get; set; }
    
        public virtual Factory11 Factory { get; set; }
    }
}
