//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class empSchedule
    {
        public int empID { get; set; }
        public int weekDay { get; set; }
        public Nullable<int> shift { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift1 { get; set; }
    }
}