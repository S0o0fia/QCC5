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
    
    public partial class Pledge
    {
        public int ID { get; set; }
        public Nullable<int> FactoryID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Path { get; set; }
    
        public virtual Factory11 Factory { get; set; }
        public virtual Location Location { get; set; }
    }
}