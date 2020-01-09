using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace V4.Migrations
{
    public partial class NewJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    ScheduleDate = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    Men = table.Column<int>(nullable: false),
                    AppStartTime = table.Column<string>(nullable: true),
                    AppEndTime = table.Column<string>(nullable: true),
                    BudgetedHours = table.Column<decimal>(nullable: false),
                    ScheduleStatus = table.Column<string>(nullable: true),
                    AssignedTo = table.Column<string>(nullable: true),
                    Hours = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    RouteNotes = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
