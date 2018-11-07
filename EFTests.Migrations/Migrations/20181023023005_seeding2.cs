using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTests.DataAccess.Migrations
{
    public partial class seeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "SecretIdentity2",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Samurais",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Supper Samurai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "SecretIdentity2",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Samurais",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Samu1");
        }
    }
}
