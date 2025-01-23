using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBoardId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BoardId",
                table: "Tasks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6366), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6368), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6388), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6390), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6392), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1L,
                columns: new[] { "BoardId", "CreatedDate", "ModifiedDate" },
                values: new object[] { 0L, new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6411), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2L,
                columns: new[] { "BoardId", "CreatedDate", "ModifiedDate" },
                values: new object[] { 0L, new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6413), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6257), new DateTime(2025, 1, 18, 21, 40, 20, 151, DateTimeKind.Local).AddTicks(6257) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9069), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9072), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9093), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9096), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "TaskLists",
                keyColumn: "TaskListId",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9097), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9121), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(8942), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 1, 18, 21, 24, 35, 26, DateTimeKind.Local).AddTicks(8959) });
        }
    }
}
