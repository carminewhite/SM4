using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class RPT_TeamDate
    {
        public int User_id { get; set; }
        public string Date { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Duration { get; set; }
        public decimal Wage { get; set; }
        public decimal Payroll_exp { get; set; }
        public decimal Total { get; set; }
        public int JobCode { get; set; }
    }
}
