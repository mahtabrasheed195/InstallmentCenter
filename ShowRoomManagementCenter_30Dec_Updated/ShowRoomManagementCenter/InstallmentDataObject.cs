using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowRoomManagementCenter
{
    public class InstallmentDataObject
    {
        public int InstallmentNo { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal InstallmentAmount { get; set; }
        public DateTime DueDate { get; set; }
    }
}