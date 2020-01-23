using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models.DataModels
{
    //I disabled the IDE1006 naming style warning in this document.  I'm not sure if changing all of them would present a
    //problem with the Tsheets API
    public class TSitem
    {
#pragma warning disable IDE1006 // Naming Styles
        public int _status_code { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string _status_message { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int user_id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int jobcode_id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime start { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime end { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int duration { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string date { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int tz { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string tz_str { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string type { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string location { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string active { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public int locked { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string notes { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        //may need to change customfields to a dictionary
#pragma warning disable IDE1006 // Naming Styles
        public string customfields { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public List<int> attached_files { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime last_modified { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }

    public class Timesheets
    {
#pragma warning disable IDE1006 // Naming Styles
        public Dictionary<string, TSitem> item { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }

    public class RootObject
    {
#pragma warning disable IDE1006 // Naming Styles
        public Result results { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }

    public class Result
    {
#pragma warning disable IDE1006 // Naming Styles
        public Timesheets timesheets { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }


    public class TimecardInfo
    {
#pragma warning disable IDE1006 // Naming Styles
        public int user_id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime start { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime end { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public double duration { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string date { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }

    public class Users
    {
#pragma warning disable IDE1006 // Naming Styles
        public int id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string first_name { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string last_name { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public bool active { get; set; } 
#pragma warning restore IDE1006 // Naming Styles
        
    }

    public class TimeCardView
    {
        public int EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
#pragma warning disable IDE1006 // Naming Styles
        public DateTime start { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public DateTime end { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        public double Duration { get; set; }
        public string JobDate { get; set; }
    }
}
