using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1709), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1729), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1752), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1755), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 1, 4, 16, 18, 53, 788, DateTimeKind.Local).AddTicks(1605) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5558), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5578), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5582), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5597), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5454), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5454) });
        }
    }
}
