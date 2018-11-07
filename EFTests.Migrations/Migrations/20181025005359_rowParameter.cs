using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTests.DataAccess.Migrations
{
    public partial class rowParameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Samurais",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Samurais");
        }
    }
}
