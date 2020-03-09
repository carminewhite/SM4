using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using V4.Models;


namespace V4.Controllers
{
    public class CustomerController : Controller
    {
        private v4Context dbContext;

        public CustomerController(v4Context context)
        {
            dbContext = context;
        }

        [HttpGet("addcustomer")]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost("customer/create")]
        public IActionResult PostNewCustomer(CustomerForm form)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = new Customer();
                newCustomer.FirstName = form.FirstName;
                newCustomer.LastName = form.LastName;
                newCustomer.Address = form.Address;
                newCustomer.City = form.City;
                newCustomer.State = form.State;
                newCustomer.Zip = form.Zip;
                newCustomer.CompanyId = 1;  //change this once login is setup
                dbContext.Add(newCustomer);
                dbContext.SaveChanges();
            }
            else
            {
                return View("AddCustomer");
            }

            return RedirectToAction("Customers");
        }

        [HttpGet("customers")]
        public IActionResult Customers()
        {
            if (HttpContext.Session != null)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("Session exists!");
                List<object> RetrieveEmployeeList = HttpContext.Session.GetObjectFromJson<List<object>>("UsersList");
                Console.WriteLine(RetrieveEmployeeList);
            }
            else
            {
                Console.WriteLine("****************************");

                Console.WriteLine("Session does not exist!!");
            }
            //Console.WriteLine("****************************");
            //Console.WriteLine($"Count of Users: {RetrieveEmployeeList.Count}");
            //Console.WriteLine("****************************");

            List<Customer> AllCustomers = dbContext.Customers
                .Where(c => c.CompanyId == 1)
                .OrderByDescending(c => c.Id)
                .ToList();
            return View(AllCustomers);
        }

        [HttpGet("viewcustomer/{id}")]
        public IActionResult ViewCustomer(int id)
        {
            Customer thisCustomer = dbContext.Customers
                .Where(c => c.Id == id)
                .Include(c => c.CustomerJobs)
                .FirstOrDefault();

            List<Job> jobsForThisCustomer = dbContext.Jobs
                .Where(j => j.CustomerId == thisCustomer.Id)
                .ToList();

            CustomersJobsViewModel custAndJobs = new CustomersJobsViewModel
            {
                cjvmCustomer = thisCustomer,
                cjvmJobs = jobsForThisCustomer
            };
            return View(custAndJobs);
        }
    }
}