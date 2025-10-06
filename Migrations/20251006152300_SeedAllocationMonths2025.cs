using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeopleIQ.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllocationMonths2025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 1,
                column: "Month",
                value: 1);

            migrationBuilder.InsertData(
                table: "AllocationMonths",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Month", "Year" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 2, 2025 },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 3, 2025 },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 4, 2025 },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 5, 2025 },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 6, 2025 },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 7, 2025 },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 8, 2025 },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 9, 2025 },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 10, 2025 }
                });

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "AllocationMonthId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 2,
                column: "AllocationMonthId",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AllocationMonths",
                keyColumn: "Id",
                keyValue: 1,
                column: "Month",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "AllocationMonthId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 2,
                column: "AllocationMonthId",
                value: 1);
        }
    }
}
