using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowRoomManagementCenter
{
    public class InstallmentTable
    {
        public int Instal_No { get; set; }
        public decimal Instal_Amount { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public Nullable<System.DateTime> DueDateEnd { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<decimal> PayedAmount { get; set; }
        public Nullable<bool> Late { get; set; }
        public string ReceivedBy { get; set; }
       // public Nullable<bool> IsPayed { get; set; }
    }
}