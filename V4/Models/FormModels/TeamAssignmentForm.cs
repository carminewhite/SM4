using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace V4.Models
{
    public class TeamAssignmentForm
    {
        public DateTime AssignedDate { get; set; }
        public int TeamId { get; set; }
        public int EmpId1 { get; set; }
        public int EmpId2 { get; set; }
        public int EmpId3 { get; set; }
        public int EmpId4 { get; set; }
        public bool AssignmentCompleted { get; set; }
    }
}
