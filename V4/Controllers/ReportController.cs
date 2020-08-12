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
using Newtonsoft.Json.Linq;
using RestSharp;
using V4.Models;
using V4.Models.DataModels;

namespace V4.Controllers
{
    public class ReportController : Controller
    {

        private readonly v4Context dbContext;

        // here we can "inject" our context service into the constructor
        public ReportController(v4Context context)
        {
            dbContext = context;
        }
        [HttpGet("reports")]
        public IActionResult Reports()
        {
            return View();
        }
        [HttpGet("rpt-byteam-day/{team}/{date}")]
        public IActionResult RPT_TeamDay(int team, string date)
        {

            DateTime thisDate = DateTime.Parse(date);
            List<Job> jobsThisDate = dbContext.Jobs
                            .Where(u => u.ScheduleDate == thisDate && u.TeamId == team)
                            .Include(c => c.Cust)
                            .Include(u => u.Tm)
                            .OrderBy(j => j.JobId)
                            .ToList();

            //query Tsheets API
            var client = new RestClient($"https://rest.tsheets.com/api/v1/timesheets?start_date={date}&end_date={date}&page=1");

            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer S.6__bd323aa9097fa841b85b146575b7347f22e86eb8");
            IRestResponse user_response = client_users.Execute(request);
            IRestResponse response = client.Execute(request);

            //----deserialize JSON data and convert into a list:
            JObject api_users = JObject.Parse(user_response.Content);
            var all_users = api_users["results"]["users"]
                .Children()
                .Children()
                .Select(c => c.ToObject<Employee>())
                .ToList();

            // grab company settings
            var thisCompanySetting = dbContext.Settings.FirstOrDefault(u => u.CompanyId == 1);

            //**************************   LABOR SECTION   **********************************

            //----deserialize JSON data and convert into a list:
            JObject api = JObject.Parse(response.Content);
            var timecards = api["results"]["timesheets"]
                .Children()
                .Children()
                .Select(i => i.ToObject<TimecardInfo>())
                .ToList();

            Console.WriteLine(new string('*', 75));
            Console.WriteLine($"Count of timecards: {timecards.Count}");

            //join lists to get ready for View
            var query = from timecard in timecards
                        join user in all_users
                        on timecard.user_id equals user.Id
                        select new
                        {
                            User_id = user.Id,
                            Date = timecard.date,
                            EmployeeFirstName = user.First_Name,
                            EmployeeLastName = user.Last_Name,
                            Start = timecard.start,
                            End = timecard.end,
                            Duration = (int)timecard.duration,
                            Wage = (decimal)user.Pay_Rate,
                            JobCode = (int)timecard.jobcode_id
                        };
            //prepare combined list for View
            List<RPT_TeamDate> reportThisDateThisTeam = new List<RPT_TeamDate>();
            foreach (var q in query)
            {
                RPT_TeamDate rpt = new RPT_TeamDate();
                rpt.User_id = q.User_id;
                rpt.Date = q.Date;
                rpt.EmployeeFirstName = q.EmployeeFirstName;
                rpt.EmployeeLastName = q.EmployeeLastName;
                rpt.Start = q.Start;
                rpt.End = q.End;
                rpt.Duration = Math.Round((q.Duration / 3600m),2); //convert seconds to hours
                rpt.Wage = q.Wage;
                rpt.Payroll_exp = Math.Round((rpt.Duration * rpt.Wage),2);
                rpt.Total = 0;
                rpt.JobCode = q.JobCode;
                reportThisDateThisTeam.Add(rpt);
            }

            var counter = 0;
            foreach (var q in reportThisDateThisTeam)
            {
                Console.WriteLine(new string('*', 75));
                Console.WriteLine($"{counter}.  {q.Date} - ({q.User_id}){q.EmployeeFirstName} {q.EmployeeLastName}, Duration: {q.Duration}");
                Console.WriteLine($"Start: {q.Start.ToString("h:mm tt")}   End: {q.End.ToString("h:mm tt")} ### Payrate: {q.Wage}");
                Console.WriteLine($"Type: {q.JobCode} ---- Payroll Cost: {q.Payroll_exp}");
                Console.WriteLine(new string('*', 75));

                counter++;
            }

            //**************************   JOB INFO SECTION   **********************************
            //Initialize job cost report and add to list
            List<JobCostReport> jcr = new List<JobCostReport>();
            foreach (var job in jobsThisDate)
            {
                JobCostReport jobCostCalc = new JobCostReport();
                jobCostCalc.JobId = job.JobId;
                jobCostCalc.Revenue = job.Amount;
                // run labor calculations
                int[] arrEmployeesThisJob = { job.TeamMemberId1, job.TeamMemberId2, job.TeamMemberId3 };
                for (var i = 0; i < 3; i++)
                {
                    
                    if (arrEmployeesThisJob[i] == 0)  // 0 means no employees assigned yet.
                    {
                        jobCostCalc.Labor += 0.01m; // should be null - need to make this nullable
                    }
                    if (arrEmployeesThisJob[i] == 1) // 1 means Previous Worker
                    {
                        //settings
                        jobCostCalc.Labor += thisCompanySetting.Default_Hourly_Wage * job.Hours;
                    }
                    if (arrEmployeesThisJob[i] == 2) // No worker assigned
                    {
                        jobCostCalc.Labor += 0;
                    }
                    Employee emp = all_users.FirstOrDefault(u => u.Id == arrEmployeesThisJob[i]);
                    if (emp != null) { // if team member id is in the current employees list
                        jobCostCalc.Labor += (decimal)emp.Pay_Rate * job.Hours;
                    } else // if team member is a past worker
                    {
                        jobCostCalc.Labor += thisCompanySetting.Default_Hourly_Wage * job.Hours;
                    }
                }
                jobCostCalc.JobCost = Math.Round((jobCostCalc.Revenue * (thisCompanySetting.Avg_Per_Job_Supply_Cost_amount / 100)), 2);
                jobCostCalc.PayrollExp = Math.Round((jobCostCalc.Labor * (thisCompanySetting.EE_payroll_burden_percent / 100)), 2);
                jobCostCalc.LaborAndBurden = Math.Round((jobCostCalc.Labor + (jobCostCalc.PayrollExp)), 2);
                jobCostCalc.Profit = Math.Round((jobCostCalc.Revenue - jobCostCalc.LaborAndBurden - jobCostCalc.JobCost),2);
                jobCostCalc.GPM = Math.Round((jobCostCalc.Profit / jobCostCalc.Revenue),4);
                jcr.Add(jobCostCalc);

            }
            //var counter = 1;
            //foreach (var job in jcr)
            //{
            //    Console.WriteLine(new string('*', 75));
            //    Console.WriteLine($"{counter}: Job: {job.JobId} - Revenue: {job.Revenue} - Labor: {job.Labor}");
            //    Console.WriteLine($"Job Cost: {job.JobCost} - Payroll Expense: {job.PayrollExp} - Total Labor: {job.LaborAndBurden}");
            //    Console.WriteLine($"Total Profit: {job.Profit} - GPM: {job.GPM}");
            //    Console.WriteLine(new string('*', 75));

            //    counter++;
            //}


            var JobTeamVM = new RPTTeamDateViewModel
            {
                Jobs = jobsThisDate,
                Employees = all_users,
                JobCostReports = jcr,
                Reports = reportThisDateThisTeam
            };
            return View("RPT_TeamDay", JobTeamVM);
        }

        //[HttpPost("rpt-byteam-day/{team}/{date}")]
        //public IActionResult RPT_TeamDay-sd()
        //{
        //    return View("Test");
        //}


        [HttpGet("rpt-allteam-day")]
        public IActionResult RPT_AllTeamsDay()
        {
            return View();
        }
    }
}