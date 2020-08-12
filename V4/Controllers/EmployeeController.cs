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
using V4.Models;
using RestSharp;
using Intuit.TSheets;
using V4.Models.DataModels;

namespace V4.Controllers
{
    public class EmployeeController : Controller
    {

        //private static string _baseUri = "https://rest.tsheets.com/api/v1";

        //private static ConnectionInfo _connection;
        //private static Intuit.TSheets.Client.Core.IOAuth2 _authProvider;


        //private static string _clientId;
        //private static string _redirectUri;
        //private static string _clientSecret;
        //private static string _manualToken;


        private readonly v4Context dbContext;

        public EmployeeController(v4Context context)
        {
            dbContext = context;
        }


        //private static void AuthenticateWithManualToken()
        //{
        //    _authProvider = new Intuit.TSheets.Client.Core.StaticAuthentication(_manualToken);
        //}

        [HttpGet("Employees")]
        public IActionResult Employees()
        {
            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users?active=true");
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

            return View(all_users);
        }


        [HttpGet("timecards")]
        public IActionResult Timecards()
        {

            //_clientId = Environment.GetEnvironmentVariable("99449a7d970345758aa06bb4b5c3de4c");
            //_redirectUri = Environment.GetEnvironmentVariable("http://localhost:5000/");
            //_clientSecret = Environment.GetEnvironmentVariable("95f8c0ba8de747228dc9e3723e94dac9");
            //_manualToken = Environment.GetEnvironmentVariable("S.6__f722ed789e07d6dab956b322e86be7a34836991e");

            //int clientPage = 5;

            var client = new RestClient($"https://rest.tsheets.com/api/v1/timesheets?start_date=2019-09-24&end_date=2019-09-25&page=1");
            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users");

            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer  S.6__cc1db510635d837d1c4d4020f9ebbed424dc3dc8");
            IRestResponse response = client.Execute(request);
            IRestResponse user_response = client_users.Execute(request);

            //----deserialize JSON data and convert into a list:
            JObject api = JObject.Parse(response.Content);
            var timecards = api["results"]["timesheets"]
                .Children()
                .Children()
                .Select(i => i.ToObject<TimecardInfo>())
                .ToList();

            Console.WriteLine("****************************");
            Console.WriteLine($"Count of timecards: {timecards.Count}");
            Console.WriteLine("****************************");

            //----deserialize JSON data and convert into a list:
            JObject api_users = JObject.Parse(user_response.Content);
            var all_users = api_users["results"]["users"]
                .Children()
                .Children()
                .Select(c => c.ToObject<Users>())
                .ToList();
            Console.WriteLine("****************************");
            Console.WriteLine($"Count of Users: {all_users.Count}");
            Console.WriteLine("****************************");

            // ---- join these lists on the id column

            var query = from timecard in timecards
                        join user in all_users
                        on timecard.user_id equals user.id
                        select new
                        {
                            EmployeeID = user.id,
                            JobDate = timecard.date,
                            EmployeeFirstName = user.first_name,
                            EmployeeLastName = user.last_name,
                            Duration = timecard.duration
                        };
            var counter = 0;
            foreach (var q in query)
            {
                //Console.WriteLine($"{counter}.  {q.JobDate} - ({q.EmployeeID}){q.EmployeeFirstName} {q.EmployeeLastName}, Duration: {q.Duration}");
                counter++;
            }
            return View();
        }


    }
}