using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V4.Models.DataModels;


namespace V4.Models
{
    public class RPTTeamDateViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Employee> Employees { get; set; }
        public List<JobCostReport> JobCostReports { get; set; }
        public List<RPT_TeamDate> Reports { get; set; }
    }
}
