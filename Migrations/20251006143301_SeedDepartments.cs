using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeopleIQ.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(4542), null, true, "Corporate" },
                    { 2, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5112), null, true, "SISCO" },
                    { 3, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5114), null, true, "Captives" },
                    { 4, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5114), null, true, "Transportation" },
                    { 5, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5122), null, true, "Benefits" },
                    { 6, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5123), null, true, "BCC" },
                    { 7, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5124), null, true, "CBCS" },
                    { 8, new DateTime(2025, 10, 6, 14, 33, 0, 735, DateTimeKind.Utc).AddTicks(5125), null, true, "Wellness" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
