using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleIQ.Migrations
{
    /// <inheritdoc />
    public partial class AddAllocationMonth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Allocations_ProjectId_UserId_Month_Year",
                table: "Allocations");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Allocations");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Allocations",
                newName: "AllocationMonthId");

            migrationBuilder.CreateTable(
                name: "AllocationMonths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime('now')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationMonths", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AllocationMonths",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Month", "Year" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, 10, 2025 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_AllocationMonthId_ProjectId_UserId",
                table: "Allocations",
                columns: new[] { "AllocationMonthId", "ProjectId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_ProjectId",
                table: "Allocations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AllocationMonths_Month_Year",
                table: "AllocationMonths",
                columns: new[] { "Month", "Year" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Allocations_AllocationMonths_AllocationMonthId",
                table: "Allocations",
                column: "AllocationMonthId",
                principalTable: "AllocationMonths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allocations_AllocationMonths_AllocationMonthId",
                table: "Allocations");

            migrationBuilder.DropTable(
                name: "AllocationMonths");

            migrationBuilder.DropIndex(
                name: "IX_Allocations_AllocationMonthId_ProjectId_UserId",
                table: "Allocations");

            migrationBuilder.DropIndex(
                name: "IX_Allocations_ProjectId",
                table: "Allocations");

            migrationBuilder.RenameColumn(
                name: "AllocationMonthId",
                table: "Allocations",
                newName: "Year");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "Allocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Month", "Year" },
                values: new object[] { 10, 2025 });

            migrationBuilder.UpdateData(
                table: "Allocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Month", "Year" },
                values: new object[] { 10, 2025 });

            migrationBuilder.CreateIndex(
                name: "IX_Allocations_ProjectId_UserId_Month_Year",
                table: "Allocations",
                columns: new[] { "ProjectId", "UserId", "Month", "Year" },
                unique: true);
        }
    }
}
