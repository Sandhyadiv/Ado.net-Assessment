using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootWearAssessment.DatabaseConnection
{
    public class StatusProperty
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
    }
}