using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class Setting : DataModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal EE_payroll_burden_percent { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Avg_Merch_Fees_percent { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Avg_Vehicle_Costs_percent { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Avg_Per_Job_Supply_Cost_amount { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Misc_Additional_percent { get; set; }

        public int CompanyId { get; set; }
    }
}
