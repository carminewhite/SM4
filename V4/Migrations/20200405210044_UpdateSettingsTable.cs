using Microsoft.EntityFrameworkCore.Migrations;

namespace V4.Migrations
{
    public partial class UpdateSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Default_Hourly_Wage",
                table: "Settings",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Default_Hourly_Wage",
                table: "Settings");
        }
    }
}
