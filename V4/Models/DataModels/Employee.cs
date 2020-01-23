using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class Employee : DataModel
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Username { get; set; }
        public decimal Wage { get; set; }
        public string DefaultTeam { get; set; }
        public bool Active { get; set; }
        public int CompanyID { get; set; }

    }
}
