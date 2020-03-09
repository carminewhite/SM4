using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using V4.Models;

namespace V4.Controllers
{
    public static class DateTimeExtensions
    {
        //Convert datetimes to a date we can send through a get route
        public static string ToYMD(this DateTime theDate)
        {
            return theDate.ToString("yyyy-MM-dd");
        }

        public static string ToYMD(this DateTime? theDate)
        {
            return theDate.HasValue ? theDate.Value.ToYMD() : string.Empty;
        }
    }

    public class JobController : Controller
    {
 
        private readonly v4Context dbContext;

        // here we can "inject" our context service into the constructor
        public JobController(v4Context context)
        {
            dbContext = context;
        }

        // GET: Job
        [Route("job")]
        [HttpGet]
        public ActionResult Index()
        {
            //upload route.  Probably should rename?
            return View("Upload");
        }

        [HttpGet("jobs-by-date")]
        public IActionResult Jobs()
        {
            return View("Jobs");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("******************  Model State is Valid *************");
                if (upload != null && upload.Length > 0)
                {
                    // ExcelDataReader works with the binary Excel file, so it needs a FileStream
                    // to get started. This is how we avoid dependencies on ACE or Interop:
                    Stream stream = upload.OpenReadStream();

                    // We return the interface, so that
                    IExcelDataReader reader = null;


                    if (upload.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (upload.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "This file format is not supported");
                        return View();
                    }



                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    var worksheet = result.Tables[0];

                    List<Customer> existingCustomersList = new List<Customer>();
                    List<Customer> newCustomerList = new List<Customer>();

                    for (int row = 0; row < worksheet.Rows.Count; row++)
                    {
                        JobUpload j = new JobUpload
                        {
                            ClientFirstName = worksheet.Rows[row][1].ToString().Trim(),
                            ClientLastName = worksheet.Rows[row][2].ToString().Trim(),
                            ClientAddressLine1 = worksheet.Rows[row][3].ToString().Trim(),
                            ClientCity = worksheet.Rows[row][4].ToString().Trim(),
                            ClientZIP = Convert.ToInt32(worksheet.Rows[row][5]),
                            ClientSince = worksheet.Rows[row][7].ToString().Trim(),
                            ScheduleDate = Convert.ToDateTime(worksheet.Rows[row][12]),
                            StartTime = worksheet.Rows[row][13].ToString().Trim(),
                            EndTime = worksheet.Rows[row][14].ToString().Trim(),
                            Men = Convert.ToInt32(worksheet.Rows[row][15]),
                            AppStartTime = worksheet.Rows[row][16].ToString().Trim(),
                            AppEndTime = worksheet.Rows[row][17].ToString().Trim(),
                            BudgetedHours = decimal.Parse(worksheet.Rows[row][18].ToString().Trim()),
                            ScheduleStatus = worksheet.Rows[row][20].ToString().Trim(),
                            ServiceAddressLine1 = worksheet.Rows[row][24].ToString().Trim(),
                            ServiceCity = worksheet.Rows[row][25].ToString().Trim(),
                            ServiceZIP = Convert.ToInt32(worksheet.Rows[row][26]),
                            AssignedTo = worksheet.Rows[row][27].ToString().Trim(),
                            Hours = decimal.Parse(worksheet.Rows[row][28].ToString().Trim()),
                            Quantity = decimal.Parse(worksheet.Rows[row][29].ToString().Trim()),
                            Rate = decimal.Parse(worksheet.Rows[row][30].ToString().Trim()),
                            Amount = decimal.Parse(worksheet.Rows[row][31].ToString().Trim()),
                            RouteNotes = worksheet.Rows[row][32].ToString().Trim()
                        };

                        //query team name to see if the team already exists.  If it exists, assign the Assigned To to that team
                        //if not then create the team, query the new team and then assign to that new team.
                        int existingTeamId;
                        Team existingTeam = dbContext.Teams.FirstOrDefault(t => t.TeamName == j.AssignedTo);
                        if (existingTeam != null)
                        {
                            existingTeamId = existingTeam.Id;
                        }
                        else
                        {
                            Team newTeam = new Team
                            {
                                TeamName = j.AssignedTo,
                                Active = true,
                                CompanyID = 1
                            };
                            dbContext.Add(newTeam);
                            dbContext.SaveChanges();

                            Team justAddedTeam = dbContext.Teams.FirstOrDefault(t => t.TeamName == j.AssignedTo);
                            existingTeamId = justAddedTeam.Id;
                        }

                        //query customer where name and address are all the same as uploaded
                        Customer existingCustomer = dbContext.Customers.FirstOrDefault(c => c.FirstName == j.ClientFirstName && c.LastName == j.ClientLastName && c.Address == j.ClientAddressLine1);

                        if (existingCustomer != null)
                        {
                            //get customer id and add it to the list of jobs for existing customers
                            //existingCustomersList.Add(existingCustomer);
                            Job newJob = new Job
                            {
                                CustomerId = existingCustomer.Id,
                                ScheduleDate = j.ScheduleDate,
                                StartTime = j.StartTime,
                                EndTime = j.EndTime,
                                Men = j.Men,
                                AppStartTime = j.AppStartTime,
                                AppEndTime = j.AppEndTime,
                                BudgetedHours = j.BudgetedHours,
                                ScheduleStatus = j.ScheduleStatus,
                                TeamId = existingTeamId,
                                Hours = j.Hours,
                                Quantity = j.Quantity,
                                Rate = j.Rate,
                                Amount = j.Amount,
                                RouteNotes = j.RouteNotes,
                                CompanyId = 1
                            };
                            dbContext.Add(newJob);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            //add to list of new customers to send to the view, along with the job information
                            Customer newcust = new Customer
                            {
                                FirstName = j.ClientFirstName,
                                LastName = j.ClientLastName,
                                Address = j.ClientAddressLine1,
                                City = j.ClientCity,
                                State = "WA",
                                Zip = j.ClientZIP,
                                CompanyId = 1
                            };
                            dbContext.Add(newcust);
                            dbContext.SaveChanges();
                            Customer justAddedCustomer = dbContext.Customers.FirstOrDefault(c => c.FirstName == newcust.FirstName && c.LastName == newcust.LastName && c.Address == newcust.Address);

                            Job newJob2 = new Job
                            {
                                CustomerId = justAddedCustomer.Id,
                                ScheduleDate = j.ScheduleDate,
                                StartTime = j.StartTime,
                                EndTime = j.EndTime,
                                Men = j.Men,
                                AppStartTime = j.AppStartTime,
                                AppEndTime = j.AppEndTime,
                                BudgetedHours = j.BudgetedHours,
                                ScheduleStatus = j.ScheduleStatus,
                                TeamId = existingTeamId,
                                Hours = j.Hours,
                                Quantity = j.Quantity,
                                Rate = j.Rate,
                                Amount = j.Amount,
                                RouteNotes = j.RouteNotes,
                                CompanyId = 1
                            };
                            dbContext.Add(newJob2);
                            dbContext.SaveChanges();
                        }
                    }
                    reader.Close();

                    //send both lists to the View --- NOT USING THIS ANYMORE RIGHT NOW
                    var ExistNewCustomers = new ExistNewCustomersJobsViewModel { ExistingCustomers = existingCustomersList, NewCustomers = newCustomerList };
                    // pick the most recent job date, and send to the jobs/jobdate route with the parameter of the most recently uploaded job
                    var lastjobdate = dbContext.Jobs
                                      .OrderByDescending(p => p.JobId)
                                      .FirstOrDefault();

                    var lastjobdateString = lastjobdate.ScheduleDate.ToYMD();


                    return RedirectToAction("JobsByDate", new { startjobdate = lastjobdateString, endjobdate = lastjobdateString });
                }
            }
            else
            {
                ModelState.AddModelError("File", "Please Upload Your file");
            }
            return View();
        }

        [HttpPost("jobsdaterange")]
        public IActionResult DateRangePost(string startDate, string endDate)
        {
            return RedirectToAction("JobsByDate", new { startjobdate = startDate, endjobdate = endDate });
        }

        [Route("jobs/{startjobdate}/{endjobdate}")]
        [HttpGet]
        public ActionResult JobsByDate(string startjobdate, string endjobdate)
        {

            DateTime sDate = DateTime.Parse(startjobdate);
            DateTime eDate = DateTime.Parse(endjobdate);
            List<Job> AllJobsByDate = dbContext.Jobs
                                        .Where(j => j.ScheduleDate >= sDate && j.ScheduleDate <= eDate)
                                        .Include(c => c.Cust)
                                        .Include(t => t.Tm)
                                        .OrderByDescending(j => j.ScheduleDate)
                                        .ThenBy(t => t.Tm.TeamName)
                                        .ThenBy(j => j.JobId)
                                        .ToList();

            return View("JobsByDate", AllJobsByDate);
        }

        [HttpGet("viewjob/{id}")]
        public IActionResult JobById(int id)
        {
            Job thisjob = dbContext.Jobs
                        .Where(j => j.JobId == id)
                        .Include(c => c.Cust)
                        .Include(t => t.Tm)
                        .FirstOrDefault();
            Console.WriteLine($"Job#: {thisjob.JobId}, Name: {thisjob.Cust.FirstName}");
            return View("ViewJob", thisjob);
        }
    }
}