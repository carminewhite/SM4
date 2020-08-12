using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class ThisJobEmployeeListViewModel
    {
        public List<JobDetails> JobDetails { get; set; }
        public Job Job { get; set; }

        public decimal TotalWages { get; set; }
        public decimal TotalPayrollBurden { get; set; }
        public decimal TotalPayroll { get; set; }
        public decimal TotalJobCost { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal JobGPM { get; set; }
        public decimal MerchantFeesCost { get; set; }
        public decimal VehicleCost { get; set; }
        public decimal SuppliesCost { get; set; }
        public decimal MiscCost { get; set; }
        public decimal OveragePerWorker { get; set; }
        public decimal OveragePctPerWorker { get; set; }
        public decimal OveragePctTotal { get; set; }
    }
}
