using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class JobCostReport

        // JOB INFO SECTION
    {
        public int JobId { get; set; }
        public decimal Revenue { get; set; }
        public decimal Labor { get; set; }
        public decimal JobCost { get; set; }
        public decimal Profit { get; set; }
        public decimal GPM { get; set; }
        public decimal PayrollExp { get; set; }
        public decimal LaborAndBurden { get; set; }

    }
}
