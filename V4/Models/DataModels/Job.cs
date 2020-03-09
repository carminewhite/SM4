using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class Job : DataModel
    {

        [Key]
        public int JobId { get; set; }
        
        //Foreign key
        public int CustomerId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Men { get; set; }
        public string AppStartTime { get; set; }
        public string AppEndTime { get; set; }
        public decimal BudgetedHours { get; set; }
        public string ScheduleStatus { get; set; }
        public int TeamId { get; set; }

        public int TeamMemberId1 { get; set; }
        public int TeamMemberId2 { get; set; }
        public int TeamMemberId3 { get; set; }
        public int TeamMemberId4 { get; set; }

        public decimal Hours { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string RouteNotes { get; set; }
        // Foreign Keys
        public int CompanyId { get; set; }
        public Customer Cust { get; set; }
        public Team Tm { get; set; }
    }
}
