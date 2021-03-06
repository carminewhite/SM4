﻿using System;
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
        public float Pay_Rate { get; set; }
        public int DefaultTeam { get; set; }
        public bool Active { get; set; }

        //Foreign keys
        public int CompanyID { get; set; }



    }
}
