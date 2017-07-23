using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRS_Project.Migrations
{
    public partial class Usersrenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityUsers",
                table: "UniversityUsers");

            migrationBuilder.RenameTable(
                name: "UniversityUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UniversityUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityUsers",
                table: "UniversityUsers",
                column: "Id");
        }
    }
}
