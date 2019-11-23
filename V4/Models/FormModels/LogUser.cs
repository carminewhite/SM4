using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LogEmail { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LogPassword { get; set; }
    }
}
