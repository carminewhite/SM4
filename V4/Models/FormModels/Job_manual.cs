using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class Job_manual
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Job { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LogPassword { get; set; }
    }
}
