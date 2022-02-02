using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootWearAssessment.DatabaseConnection
{
    public class FootWearModel
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }

    }
}