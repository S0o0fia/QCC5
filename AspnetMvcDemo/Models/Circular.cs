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
    
    public partial class Circular
    {
        public int id { get; set; }
        public string fileName { get; set; }
        public Nullable<int> factoryId { get; set; }
        public Nullable<System.DateTime> fileDate { get; set; }
        public Nullable<bool> download { get; set; }
    }
}