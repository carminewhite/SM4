using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class JobDetails
    {
        public string EmployeeName {get; set;}
        public decimal WagesCost { get; set; }
        public decimal PayrollBurdenCost { get; set; }
        public decimal MerchantFeesCost { get; set; }
        public decimal VehicleCost { get; set; }
        public decimal SuppliesCost { get; set; }
        public decimal MiscCost { get; set; }
    }
}
