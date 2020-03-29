using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace V4.Migrations
{
    public partial class AddSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wage",
                table: "Employees");

            migrationBuilder.AddColumn<float>(
                name: "Pay_Rate",
                table: "Employees",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    EE_payroll_burden_percent = table.Column<decimal>(nullable: false),
                    Avg_Merch_Fees_percent = table.Column<decimal>(nullable: false),
                    Avg_Vehicle_Costs_percent = table.Column<decimal>(nullable: false),
                    Avg_Per_Job_Supply_Cost_amount = table.Column<decimal>(nullable: false),
                    Misc_Additional_percent = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamAssignments_TeamId",
                table: "TeamAssignments",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAssignments_Teams_TeamId",
                table: "TeamAssignments",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamAssignments_Teams_TeamId",
                table: "TeamAssignments");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_TeamAssignments_TeamId",
                table: "TeamAssignments");

            migrationBuilder.DropColumn(
                name: "Pay_Rate",
                table: "Employees");

            migrationBuilder.AddColumn<decimal>(
                name: "Wage",
                table: "Employees",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
