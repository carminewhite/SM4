using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class JobTeamViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Team> Teams { get; set; }
        public List<TeamAssignment> Assignments { get; set; }
        public TeamAssignmentForm TAF { get; set; }
    }
}
