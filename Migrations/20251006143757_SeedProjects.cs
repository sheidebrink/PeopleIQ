using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeopleIQ.Migrations
{
    /// <inheritdoc />
    public partial class SeedProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "CreatedAt", "DepartmentId", "Description", "EndDate", "Name", "Priority", "Progress", "StartDate", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overhead", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 2, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "PTO", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 3, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Info-capture", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 4, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janus / Iris / Engage Maintenance / Improvements", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 5, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee Historical DB", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 6, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrier / Wholesale Dashboard", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 7, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janus SSO", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 8, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janus Roles Power BI", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 9, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training", 0, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 10, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actuaria Drug Warranty Online Claims Submission", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 11, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verification Phase II", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 12, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Map Field LuminX Phase II", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 13, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verification Eligibility Audit (AWS AI)", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 14, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bank Reconciliation Phase II", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 15, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Report Power BI vs C#", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 16, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSR24 Highway Project", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 17, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independent Contractor Score Card", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 18, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VIN DB Backup Automation", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 19, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Producer Top 10", 0, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 20, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Client Iris", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 21, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk - Management Migration Dashboard", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 22, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "NSTD Direct / Backoffice Iris", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 23, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Team Changes", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 24, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrier premium reporting updates", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 25, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escrow Invoices", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 26, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Submission Page", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 27, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adjuster/Vetiv Evaluation", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 28, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Critical Email Mining Phase II", 2, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 29, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summary Sheet Automation & Efficiencies", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 30, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wellness", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 31, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engage360", 1, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31);
        }
    }
}
