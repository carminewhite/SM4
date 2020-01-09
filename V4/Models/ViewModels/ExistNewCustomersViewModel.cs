using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{ 
    public class ExistNewCustomersJobsViewModel
    {
        public List<Customer> ExistingCustomers { get; set; }
        public List<Customer> NewCustomers { get; set; }
        public List<Job> NewJobs { get; set; }
    }
}
