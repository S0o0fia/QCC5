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
    
    public partial class PermitVisionTest
    {
        public int TestID { get; set; }
        public Nullable<int> PermitId { get; set; }
        public Nullable<bool> VisionTest { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsAmanaTest { get; set; }
        public string ResonOfFail { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lang { get; set; }
        public string TechniqName { get; set; }
    }
}
