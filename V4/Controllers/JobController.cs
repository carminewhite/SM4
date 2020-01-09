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
            Console.WriteLine();
            Console.WriteLine("On Job Route");
            Console.WriteLine();
            return View("Upload");
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
                        //convert date in this object to a "MM-dd-yyyy" string format
                        //var dateTime = DateTime.FromOADate(date).ToString("MM-dd-yyyy");
                        //j.ScheduleDate = dateTime;

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
                                AssignedTo = j.AssignedTo,
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
                                AssignedTo = j.AssignedTo,
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


                    //convert string date in this object to a datetime format
                    //double date2 = double.Parse(jobdate);
                    //var dateTime2 = DateTime.FromOADate(date2).ToString("MM-dd-yyyy");
                    //jobdate = dateTime2;
                    return RedirectToAction("JobsByDate"/*, new { jobdate }*/);
                }
            }
            else
            {
                ModelState.AddModelError("File", "Please Upload Your file");
            }
            return View();
        }


        [Route("jobs/test")]
        [HttpGet]
        public ActionResult JobsByDate()
        {
            var lastjobdate = dbContext.Jobs
                  .OrderByDescending(p => p.JobId)
                  .FirstOrDefault();

            string correctDate = DateTime.ParseExact(lastjobdate.ScheduleDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            String.Format("{0:yyyy-MM-dd}", correctDate);
            Console.WriteLine("*************************************");
            Console.WriteLine($"Last Job Date: {lastjobdate.JobId}, Date: {lastjobdate.ScheduleDate}");
            Console.WriteLine($"Last job date in String format: {correctDate}");
            Console.WriteLine("*************************************");



            //DateTime oDate = DateTime.P(jobdate);
            //List<Job> AllJobsByDate = dbContext.Jobs
            //                            .Where(j => j.ScheduleDate == oDate)
            //                            .Include(c => c.Cust)
            //                            .OrderBy(c => c.Cust.LastName)
            //                            .ToList();



            return View("Upload");
        }


     


        //[HttpPost("customer/create")]
        //public IActionResult PostNewCustomer(CustomerForm form)
        //{
        //    return RedirectToAction()
        //}

        //[HttpPost("import")]
        //public async Task<DemoResponse<List<UserInfo>>> Import(IFormFile formFile, CancellationToken cancellationToken)
        //{
        //    if (formFile != null || formFile.Length > 0)
        //    {


        //        Stream stream = formFile.OpenReadStream();
        //        IExcelDataReader reader = null;

        //        if (Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
        //        {
        //            //return DemoResponse<List<UserInfo>>.GetResult(-1, "Not Support file extension");
        //            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        //        }
        //        else if (Path.GetExtension(formFile.FileName).Equals(".xls", StringComparison.OrdinalIgnoreCase))
        //        {
        //            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        //        }
        //        else
        //        {
        //            return DemoResponse<List<UserInfo>>.GetResult(-1, "This file format is not supported");
        //        }

        //        reader.IsFirstRowAsColumnNames = true;
        //        var list = new List<UserInfo>();
        //        List<Job> listJobs = new List<Job>();


        //        // *************** this only works for xlsx files.  Need one for xls files *****************************
        //        using (var stream = new MemoryStream())
        //        {
        //            await formFile.CopyToAsync(stream, cancellationToken);

        //            using (var package = new ExcelPackage(stream))
        //            {
        //                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
        //                var rowCount = worksheet.Dimension.Rows;

        //                for (int row = 2; row <= rowCount; row++)
        //                {
        //                    Job j = new Job
        //                    {
        //                        ClientFirstName = worksheet.Cells[row, 2].Value.ToString().Trim(),
        //                        ClientLastName = worksheet.Cells[row, 3].Value.ToString().Trim(),
        //                        ClientAddressLine1 = worksheet.Cells[row, 4].Value.ToString().Trim(),
        //                        ClientCity = worksheet.Cells[row, 5].Value.ToString().Trim(),
        //                        ClientZIP = int.Parse(worksheet.Cells[row, 6].Value.ToString().Trim()),
        //                        ClientSince = worksheet.Cells[row, 8].Value.ToString().Trim(),
        //                        ScheduleDate = worksheet.Cells[row, 13].Value.ToString().Trim(),
        //                        StartTime = worksheet.Cells[row, 14].Value.ToString().Trim(),
        //                        EndTime = worksheet.Cells[row, 15].Value.ToString().Trim(),
        //                        Men = int.Parse(worksheet.Cells[row, 16].Value.ToString().Trim()),
        //                        AppStartTime = worksheet.Cells[row, 17].Value.ToString().Trim(),
        //                        AppEndTime = worksheet.Cells[row, 18].Value.ToString().Trim(),
        //                        BudgetedHours = decimal.Parse(worksheet.Cells[row, 19].Value.ToString().Trim()),
        //                        ScheduleStatus = worksheet.Cells[row, 21].Value.ToString().Trim(),
        //                        ServiceAddressLine1 = worksheet.Cells[row, 25].Value.ToString().Trim(),
        //                        ServiceCity = worksheet.Cells[row, 26].Value.ToString().Trim(),
        //                        ServiceZIP = int.Parse(worksheet.Cells[row, 27].Value.ToString().Trim()),
        //                        AssignedTo = worksheet.Cells[row, 28].Value.ToString().Trim(),
        //                        Hours = decimal.Parse(worksheet.Cells[row, 29].Value.ToString().Trim()),
        //                        Quantity = decimal.Parse(worksheet.Cells[row, 30].Value.ToString().Trim()),
        //                        Rate = decimal.Parse(worksheet.Cells[row, 31].Value.ToString().Trim()),
        //                        Amount = decimal.Parse(worksheet.Cells[row, 32].Value.ToString().Trim()),
        //                        RouteNotes = worksheet.Cells[row, 33].Value.ToString().Trim()
        //                    };
        //                    listJobs.Add(j);
        //                }
        //            }

        //        }

        //        var counter = 1;
        //        foreach (var jobs in listJobs)
        //        {
        //            Console.WriteLine($"{counter}: {jobs.ClientFirstName} {jobs.ClientLastName} - {jobs.ScheduleDate}");
        //            counter++;
        //        }
        //        //*********************************   test list *********************************
        //        //var list = new List<UserInfo>();

        //        //using (var stream = new MemoryStream())
        //        //{
        //        //    await formFile.CopyToAsync(stream, cancellationToken);

        //        //    using (var package = new ExcelPackage(stream))
        //        //    {
        //        //        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
        //        //        var rowCount = worksheet.Dimension.Rows;

        //        //        for (int row = 2; row <= rowCount; row++)
        //        //        {
        //        //            list.Add(new UserInfo
        //        //            {
        //        //                UserName = worksheet.Cells[row, 1].Value.ToString().Trim(),
        //        //                Age = int.Parse(worksheet.Cells[row, 2].Value.ToString().Trim()),
        //        //            });
        //        //        }
        //        //    }
        //        //}
        //        //*********************************   test list *********************************

        //        // add list to db ..  
        //        // here just read and return  

        //        return DemoResponse<List<UserInfo>>.GetResult(0, "OK", list);
        //    }
        //}


    }
}