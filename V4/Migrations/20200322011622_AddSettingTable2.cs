using Microsoft.EntityFrameworkCore.Migrations;

namespace V4.Migrations
{
    public partial class AddSettingTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Misc_Additional_percent",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "EE_payroll_burden_percent",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Vehicle_Costs_percent",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Per_Job_Supply_Cost_amount",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Merch_Fees_percent",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Misc_Additional_percent",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EE_payroll_burden_percent",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Vehicle_Costs_percent",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Per_Job_Supply_Cost_amount",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Avg_Merch_Fees_percent",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");
        }
    }
}
