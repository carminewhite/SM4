using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class JobUpload
    {
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientAddressLine1 { get; set; }
        public string ClientCity { get; set; }
        public int ClientZIP { get; set; }
        public string ClientSince { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Men { get; set; }
        public string AppStartTime { get; set; }
        public string AppEndTime { get; set; }
        public decimal BudgetedHours { get; set; }
        public string ScheduleStatus { get; set; }
        public string ServiceAddressLine1 { get; set; }
        public string ServiceCity { get; set; }
        public int ServiceZIP { get; set; }
        public string AssignedTo { get; set; }
        public decimal Hours { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string RouteNotes { get; set; }
    }
}
