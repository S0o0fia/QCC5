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
    
    public partial class MixingStationsAnswersOfFactory
    {
        public int ID { get; set; }
        public int StationNumber { get; set; }
        public string InputValue { get; set; }
        public int FactoryId { get; set; }
        public int MixingStationsQuestionsId { get; set; }
    
        public virtual Factory11 Factory { get; set; }
        public virtual MixingStationsQuestion MixingStationsQuestion { get; set; }
    }
}
