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
    
    public partial class ConClsMixer
    {
        public int ID { get; set; }
        public int FactId { get; set; }
        public int YearCls { get; set; }
        public Nullable<int> TotalMixers { get; set; }
        public Nullable<bool> WaysOfMixer { get; set; }
        public string MixerSize { get; set; }
        public string MixerPeriod { get; set; }
        public Nullable<bool> WeightControl { get; set; }
        public Nullable<bool> SizeControl { get; set; }
        public Nullable<bool> IsAmountRegisterUsing { get; set; }
        public Nullable<bool> IsRegisterExistAnyTime { get; set; }
        public Nullable<int> StationNo { get; set; }
        public Nullable<bool> IsMzReadDevice { get; set; }
        public Nullable<bool> IsMzGoodSize { get; set; }
        public Nullable<bool> IsMzAccurate { get; set; }
        public Nullable<bool> IsAllArrowGoodProtected { get; set; }
        public Nullable<bool> IsLargeNoEasyRead { get; set; }
        public Nullable<bool> IsMixerManul { get; set; }
        public Nullable<bool> IsMixerDigital { get; set; }
        public Nullable<bool> IsMixerMix { get; set; }
    }
}