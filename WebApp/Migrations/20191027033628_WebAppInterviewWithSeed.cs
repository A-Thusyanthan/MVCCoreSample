using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class WebAppInterviewWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AdditionalRequest", "DateRegistered", "Day1", "Day2", "Day3", "Email", "Gender", "Name" },
                values: new object[] { 1, "Act", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, "thus@gmail.com", "M", "Thus" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AdditionalRequest", "DateRegistered", "Day1", "Day2", "Day3", "Email", "Gender", "Name" },
                values: new object[] { 2, "Act", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, "ram@gmail.com", "M", "Ram" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
