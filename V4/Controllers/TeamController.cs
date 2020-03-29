using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Globalization;
using System.IO;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using V4.Models;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace V4.Controllers
{
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
    public class TeamController : Controller
    {
        private readonly v4Context dbContext;

        // here we can "inject" our context service into the constructor
        public TeamController(v4Context context)
        {
            dbContext = context;
        }

        [HttpPost("update-default-team")]
        public IActionResult UpdateDefaultTeam(TeamAssignmentForm form)
        {
            Team thisTeam = dbContext.Teams.FirstOrDefault(u => u.Id == form.TeamId);

            thisTeam.DefaultTeamMember1Id = form.EmpId1;
            thisTeam.DefaultTeamMember2Id = form.EmpId2;
            thisTeam.DefaultTeamMember3Id = form.EmpId3;
            thisTeam.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();

            return RedirectToAction("Teams");
        }

        [HttpGet("teams")]
        public IActionResult Teams()
        {
            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users?active=true");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer S.6__bd323aa9097fa841b85b146575b7347f22e86eb8");
            IRestResponse user_response = client_users.Execute(request);

            //----deserialize JSON data and convert into a list:
            JObject api_users = JObject.Parse(user_response.Content);
            var all_users = api_users["results"]["users"]
                .Children()
                .Children()
                .Select(c => c.ToObject<Employee>())
                .ToList();

            List<Team> allteams = dbContext.Teams
                      .OrderBy(t => t.TeamName)
                      .ToList();

            var TeamEmpVM = new TeamEmployeeViewModel
            {
                Teams = allteams,
                Employees = all_users
            };
            return View(TeamEmpVM);
        }

        [HttpGet("teams/{id}")]
        public IActionResult TeamsById(int id)
        {
            return View();
        }

        [HttpPost("teamassignmentsdate")]
        public IActionResult TeamAssignmentsDatePost(string teamDate)
        {

            return RedirectToAction("TeamAssignmentsByDate", new { date = teamDate });
        }

        [HttpGet("team-assignments")]
        public IActionResult TeamAssignments()
        {

            return View("TeamAssignmentsMain");
        }

        [HttpGet("team-assignments/{date}")]
        public IActionResult TeamAssignmentsByDate(string date)
        {
            DateTime assignmentDate = DateTime.Parse(date);

            List<Job> jobsThisDate = dbContext.Jobs
                                        .Where(u => u.ScheduleDate == assignmentDate)
                                        .Include(u => u.Tm)
                                        .OrderBy(u => u.Tm.TeamName)
                                        .ToList();
            var client_users = new RestClient("https://rest.tsheets.com/api/v1/users");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer S.6__bd323aa9097fa841b85b146575b7347f22e86eb8");
            IRestResponse user_response = client_users.Execute(request);

            //----deserialize JSON data and convert into a list:
            JObject api_users = JObject.Parse(user_response.Content);
            var all_users = api_users["results"]["users"]
                .Children()
                .Children()
                .Select(c => c.ToObject<Employee>())
                .ToList();

            List<Team> pull_teams = dbContext.Teams
                                    .OrderBy(u => u.TeamName)
                                    .ToList();
            List<TeamAssignment> tm_assignments = dbContext.TeamAssignments
                                                    .Where(d => d.AssignedDate == assignmentDate)
                                                    .OrderBy(t => t.TeamId)
                                                    .ToList();

            var jtVM = new JobTeamViewModel
            {
                Jobs = jobsThisDate,
                Employees = all_users,
                Teams = pull_teams,
                Assignments = tm_assignments,
            };
            return View("TeamAssignments", jtVM);
        }

        [HttpPost("save-team-assignment")]
        public IActionResult SaveTeamAssignment(TeamAssignmentForm form, string command)
        {
            if (command.Equals("Save Today Only"))
                //Assignment by date
            {
                //If team and date both exist, then update record with new team assignment
                TeamAssignment checkAssignment = dbContext.TeamAssignments
                                                 .FirstOrDefault(u => u.AssignedDate == form.AssignedDate && u.TeamId == form.TeamId);
                if (checkAssignment != null)
                {
                    checkAssignment.EmpId1 = form.EmpId1;
                    checkAssignment.EmpId2 = form.EmpId2;
                    checkAssignment.EmpId3 = form.EmpId3;
                    checkAssignment.AssignmentCompleted = form.AssignmentCompleted;
                    checkAssignment.UpdatedAt = DateTime.Now;
                    dbContext.SaveChanges();
                }
                //Else add new record
                else
                {
                    TeamAssignment newTA = new TeamAssignment
                    {
                        AssignedDate = form.AssignedDate,
                        AssignmentCompleted = form.AssignmentCompleted,
                        EmpId1 = form.EmpId1,
                        EmpId2 = form.EmpId2,
                        EmpId3 = form.EmpId3,
                        TeamId = form.TeamId
                    };
                    dbContext.Add(newTA);
                    dbContext.SaveChanges();
                }

                string reroutedate = form.AssignedDate.ToString("yyyy-MM-dd");

                return RedirectToAction("TeamAssignmentsByDate", new { date = reroutedate });
            }
            else
            ///  Default team assignment
            {
                Team pullTeam = dbContext.Teams
                                .FirstOrDefault(u => u.Id == form.TeamId);
                pullTeam.DefaultTeamMember1Id = form.EmpId1;
                pullTeam.DefaultTeamMember2Id = form.EmpId2;
                pullTeam.DefaultTeamMember3Id = form.EmpId3;
                pullTeam.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();

                //*********  duplicate code as above ************

                //If team and date both exist, then update record with new team assignment
                TeamAssignment checkAssignment = dbContext.TeamAssignments
                                                 .FirstOrDefault(u => u.AssignedDate == form.AssignedDate && u.TeamId == form.TeamId);
                if (checkAssignment != null)
                {
                    checkAssignment.EmpId1 = form.EmpId1;
                    checkAssignment.EmpId2 = form.EmpId2;
                    checkAssignment.EmpId3 = form.EmpId3;
                    checkAssignment.AssignmentCompleted = form.AssignmentCompleted;
                    checkAssignment.UpdatedAt = DateTime.Now;
                    dbContext.SaveChanges();
                }
                //Else add new record
                else
                {
                    TeamAssignment newTA = new TeamAssignment
                    {
                        AssignedDate = form.AssignedDate,
                        AssignmentCompleted = form.AssignmentCompleted,
                        EmpId1 = form.EmpId1,
                        EmpId2 = form.EmpId2,
                        EmpId3 = form.EmpId3,
                        TeamId = form.TeamId
                    };
                    dbContext.Add(newTA);
                    dbContext.SaveChanges();
                }
                string reroutedate = form.AssignedDate.ToString("yyyy-MM-dd");

                return RedirectToAction("TeamAssignmentsByDate", new { date = reroutedate });
            }
        }

        // ***********  Trying to make an AJAX post, so we can assign the default team on the team assignments page without refreshing)

        //[HttpPost("save-default-team-assignment")]
        //public IActionResult SaveDefaultTeamAssignment(TeamAssignmentForm form)
        //{

        //    TeamAssignment tmAssTest = new TeamAssignment();
        //    tmAssTest.EmpId1 = form.EmpId1;
        //    tmAssTest.EmpId2 = form.EmpId2;
        //    tmAssTest.EmpId3 = form.EmpId3;
        //    tmAssTest.Id = form.TeamId;

        //    return Json(tmAssTest);
        //}
    }
}