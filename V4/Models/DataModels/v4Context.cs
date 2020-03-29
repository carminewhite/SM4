using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V4.Models
{
    public class v4Context : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public v4Context(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamAssignment> TeamAssignments { get; set; }
        public DbSet<Setting> Settings { get; set; }
    }
}
