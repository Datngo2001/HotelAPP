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
    
    public partial class Check_out
    {
        public System.DateTime check_out_date { get; set; }
        public int emp_id { get; set; }
        public Nullable<System.TimeSpan> check_out_time { get; set; }
    
        public virtual Check_in Check_in { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
