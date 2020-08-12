using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using V4.Models;

namespace V4.Controllers
{
    public class HomeController : Controller
    {

        private readonly v4Context dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(v4Context context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("save-company-settings")]
        public IActionResult CompanySettingsPost(Setting form)
        {
            Setting current_setting = dbContext.Settings.FirstOrDefault(u => u.CompanyId == 1);
            if (current_setting == null)
            {
                Setting first_time_setting = new Setting();
                {
                    first_time_setting.CompanyId = 1;
                    first_time_setting.Default_Hourly_Wage = form.Default_Hourly_Wage;
                    first_time_setting.EE_payroll_burden_percent = form.EE_payroll_burden_percent;
                    first_time_setting.Avg_Merch_Fees_percent = form.Avg_Merch_Fees_percent;
                    first_time_setting.Avg_Per_Job_Supply_Cost_amount = form.Avg_Per_Job_Supply_Cost_amount;
                    first_time_setting.Avg_Vehicle_Costs_percent = form.Avg_Vehicle_Costs_percent;
                    first_time_setting.Misc_Additional_percent = form.Misc_Additional_percent;
                    first_time_setting.CreatedAt = DateTime.Now;
                    first_time_setting.UpdatedAt = DateTime.Now;
                    dbContext.Add(first_time_setting);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                current_setting.Default_Hourly_Wage = form.Default_Hourly_Wage;
                current_setting.EE_payroll_burden_percent = form.EE_payroll_burden_percent;
                current_setting.Avg_Merch_Fees_percent = form.Avg_Merch_Fees_percent;
                current_setting.Avg_Vehicle_Costs_percent = form.Avg_Vehicle_Costs_percent;
                current_setting.Avg_Per_Job_Supply_Cost_amount = form.Avg_Per_Job_Supply_Cost_amount;
                current_setting.Misc_Additional_percent = form.Misc_Additional_percent;
                current_setting.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
            }
            return RedirectToAction("Settings");
        }

        [HttpGet("settings")]
        public IActionResult Settings()
        {
            Setting current_setting = dbContext.Settings.FirstOrDefault(u => u.CompanyId == 1);
            if (current_setting == null)
            {
                Setting first_time_setting = new Setting();
                {
                    first_time_setting.EE_payroll_burden_percent = 0;
                    first_time_setting.Avg_Merch_Fees_percent = 0;
                    first_time_setting.Avg_Per_Job_Supply_Cost_amount = 0;
                    first_time_setting.Avg_Vehicle_Costs_percent = 0;
                    first_time_setting.Misc_Additional_percent = 0;
                    return View(first_time_setting);
                }
            }
            else
            {
                return View(current_setting);
            }

        }
    }
}
