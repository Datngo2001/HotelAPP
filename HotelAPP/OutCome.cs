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
    
    public partial class OutCome
    {
        public int outComeId { get; set; }
        public Nullable<System.DateTime> executeDate { get; set; }
        public Nullable<int> empId { get; set; }
        public Nullable<decimal> moneyTranfer { get; set; }
        public string description { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
