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
        [HttpGet("rpt-byteam-day")]
        public IActionResult RPT_TeamDay()
        {
            return View();
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