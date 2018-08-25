using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTests.DataAccess.Migrations
{
    public partial class DataUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entity2",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Name21Updated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entity2",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Name21");
        }
    }
}
