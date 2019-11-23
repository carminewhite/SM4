using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class CustomerForm
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2)]
        public string Address { get; set; }

        [Required]
        [MinLength(2)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        [MinLength(2)]
        public string State { get; set; }

        [Required]
        [Range(10000, 99999, ErrorMessage = "Zip must be 5 characters")]
        public int Zip { get; set; }
    }
}
