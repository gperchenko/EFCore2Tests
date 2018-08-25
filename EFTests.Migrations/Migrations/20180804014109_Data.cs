using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTests.DataAccess.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entity2",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Name21" });

            migrationBuilder.InsertData(
                table: "Entity2",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Name22" });

            migrationBuilder.InsertData(
                table: "Entity1",
                columns: new[] { "Id", "Entity2Id", "Name" },
                values: new object[] { 1, 1, "Name21" });

            migrationBuilder.InsertData(
                table: "Entity1",
                columns: new[] { "Id", "Entity2Id", "Name" },
                values: new object[] { 2, 2, "Name22" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entity1",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entity1",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entity2",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entity2",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
