using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using V4.Models;
using RestSharp;
using Newtonsoft.Json.Linq;

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
       

            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer  S.6__cc1db510635d837d1c4d4020f9ebbed424dc3dc8");
            IRestResponse user_response = client_users.Execute(request);

            //----deserialize JSON data and convert into a list:
            JObject api_users = JObject.Parse(user_response.Content);
            var all_users = api_users["results"]["users"]
                .Children()
                .Children()
                .Select(c => c.ToObject<Employee>())
                .ToList();

            // Initialize a list of job details
            List<JobDetails> job_details = new List<JobDetails>();
            // filter list of employees to be shown only if they are on the job
            List<int> filtered_list = new List<int>
            {
                // add each member id to a generic int list so we can iterate over them.
                thisjob.TeamMemberId1,
                thisjob.TeamMemberId2,
                thisjob.TeamMemberId3,
                thisjob.TeamMemberId4,
            };
            //pull DB default settings into a list, to limit DB calls
            Setting settings = dbContext.Settings
                               .FirstOrDefault();

            foreach (var item in filtered_list)
            {
                var emp = all_users.FirstOrDefault(u => u.Id == item);
                if (emp != null)
                {
                    // found a match in both lists
                    Console.WriteLine($"########\r\n(not null)Employee 1: {emp.Id} - {emp.First_Name} {emp.Last_Name}");
                    JobDetails j = new JobDetails
                    {
                        EmployeeName = emp.First_Name + " " + emp.Last_Name,
                        WagesCost = (decimal)emp.Pay_Rate * thisjob.Hours,
                    };
                    j.PayrollBurdenCost = (j.WagesCost * settings.EE_payroll_burden_percent) / 100;
                    job_details.Add(j);

                }
                else
                {
                    if (item == 0)
                    {
                        Console.WriteLine("\nEmployee # is 0 - NOT ASSIGNED");
                        JobDetails j = new JobDetails
                        {
                            EmployeeName = "No employee assigned",
                            WagesCost = 0,
                            PayrollBurdenCost = 0
                        };
                        //job_details.Add(j);

                    }
                    else if (item == 1)
                    {
                        Console.WriteLine("\n1:  Previous worker.  Need to default #'s");
                        JobDetails j = new JobDetails
                        {
                            EmployeeName = "Past worker (default #'s)",
                            WagesCost = settings.Default_Hourly_Wage * thisjob.Hours,
                        };
                        j.PayrollBurdenCost = (j.WagesCost * settings.EE_payroll_burden_percent)/100;
                        job_details.Add(j);

                    }
                    else if (item == 2)
                    {
                        Console.WriteLine("\n2:  No worker in this slot today");
                        JobDetails j = new JobDetails
                        {
                            EmployeeName = "No employee assigned",
                            WagesCost = 0,
                            PayrollBurdenCost = 0
                        };
                        job_details.Add(j);

                    }
                    else
                    {
                        Console.WriteLine("\nsomething weird happened here, not sure what");
                        JobDetails j = new JobDetails
                        {
                            EmployeeName = "Something went wrong",
                            WagesCost = 0,
                            PayrollBurdenCost = 0
                        };
                        job_details.Add(j);
                    }
                }
            }
            //List<JobDetails> this_job_details = new List<JobDetails>();





            //final calcs
            decimal wages_sum = 0;
            decimal burden_sum = 0;
            foreach (var item in job_details)
            {
                wages_sum += item.WagesCost;
                burden_sum += item.PayrollBurdenCost;
            }

            decimal merch_cost = thisjob.Amount * settings.Avg_Merch_Fees_percent;
            decimal veh_cost = thisjob.Amount * settings.Avg_Vehicle_Costs_percent;
            decimal supplies_cost = thisjob.Amount * settings.Avg_Per_Job_Supply_Cost_amount;
            decimal misc_cost = thisjob.Amount * settings.Misc_Additional_percent;
            decimal gross_profit = thisjob.Amount - wages_sum - burden_sum - merch_cost - veh_cost - supplies_cost - misc_cost;
            

            var JobEmployeeVM = new ThisJobEmployeeListViewModel
            {
                JobDetails = job_details,
                Job = thisjob,
                TotalPayroll = wages_sum + burden_sum,
                MerchantFeesCost = merch_cost,
                VehicleCost = veh_cost,
                SuppliesCost = supplies_cost,
                MiscCost = misc_cost,
                GrossProfit = gross_profit,
                TotalWages = wages_sum,
                TotalPayrollBurden = burden_sum,
                OveragePerWorker = thisjob.Overage / thisjob.Men,
                OveragePctPerWorker = (thisjob.Overage / thisjob.Men) / thisjob.BudgetedHours,
                OveragePctTotal = thisjob.Overage / thisjob.Men
            };

            // run all calculations here, then send as a list to the view






            Console.WriteLine($"************** \r\nEmployee 1: {thisjob.TeamMemberId1}\r\nEmployee 2: {thisjob.TeamMemberId2}\nEmployee 3: {thisjob.TeamMemberId3}\nEmployee 4: {thisjob.TeamMemberId4}");
            return View("ViewJob", JobEmployeeVM);

            //List<Team> pull_teams = dbContext.Teams
            //                        .OrderBy(u => u.TeamName)
            //                        .ToList();
            ////List<TeamAssignment> tm_assignments = dbContext.TeamAssignments
            ////                                        .Where(d => d.AssignedDate == assignmentDate)
            ////                                        .OrderBy(t => t.TeamId)
            ////                                        .ToList();
            //List<Team> filteredTeams = new List<Team>();
            //foreach (var team in pull_teams)
            //{
            //    if (jobsThisDate.Any(u => u.TeamId == team.Id))
            //    {
            //        filteredTeams.Add(team);
            //    }
            //}


            //var jtVM = new JobTeamViewModel
            //{
            //    Jobs = jobsThisDate,
            //    Employees = all_users,
            //    Teams = filteredTeams
            //    //Assignments = tm_assignments,
            //};
            //return View("TeamAssignments", jtVM);
        }


    }
 
}