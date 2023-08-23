using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETMVCCRUD.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
