using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace V4.Models
{
    public class Team : DataModel
    {
        [Key]
        public int Id { get; set; }
        public string TeamName { get; set; }
        public bool Active { get; set; }

        public int DefaultTeamMember1Id { get; set; }
        public int DefaultTeamMember2Id { get; set; }
        public int DefaultTeamMember3Id { get; set; }
        public int DefaultTeamMember4Id { get; set; }


        public int CompanyID { get; set; }

        public List<Employee> TeamEmployees { get; set; }

    }
}
