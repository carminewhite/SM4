﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using V4.Models;

namespace V4.Migrations
{
    [DbContext(typeof(v4Context))]
    partial class v4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("V4.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Industry");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("V4.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("State");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("V4.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("AppEndTime");

                    b.Property<string>("AppStartTime");

                    b.Property<string>("AssignedTo");

                    b.Property<decimal>("BudgetedHours");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CustomerId");

                    b.Property<string>("EndTime");

                    b.Property<decimal>("Hours");

                    b.Property<int>("Men");

                    b.Property<decimal>("Quantity");

                    b.Property<decimal>("Rate");

                    b.Property<string>("RouteNotes");

                    b.Property<string>("ScheduleDate");

                    b.Property<string>("ScheduleStatus");

                    b.Property<string>("StartTime");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("V4.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
