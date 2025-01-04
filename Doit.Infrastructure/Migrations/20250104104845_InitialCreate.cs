using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    BoardId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.BoardId);
                    table.ForeignKey(
                        name: "FK_Boards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskLists",
                columns: table => new
                {
                    TaskListId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<long>(type: "bigint", nullable: false),
                    TaskListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLists", x => x.TaskListId);
                    table.ForeignKey(
                        name: "FK_TaskLists_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskListId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskLists_TaskListId",
                        column: x => x.TaskListId,
                        principalTable: "TaskLists",
                        principalColumn: "TaskListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "FirstName", "LastName", "ModifiedDate", "Password", "Username" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5404), "John", "Doe", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5415), "1234", "JohnDoe" },
                    { 2L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5454), "Jane", "Doe", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5454), "5678", "JaneDoe" }
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "BoardId", "BoardName", "CreatedDate", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, "Project Alpha", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5558), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5558), 1L },
                    { 2L, "Project Beta", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5560), 2L }
                });

            migrationBuilder.InsertData(
                table: "TaskLists",
                columns: new[] { "TaskListId", "BoardId", "CreatedDate", "ModifiedDate", "Order", "TaskListName" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5578), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5579), 1, "To Do" },
                    { 2L, 1L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5581), 2, "In Progress" },
                    { 3L, 2L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5582), new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5582), 1, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CreatedDate", "Description", "Image", "ModifiedDate", "Order", "Status", "TaskListId", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5597), "First Task", "", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5598), 1, "Open", 1L, "Task 1" },
                    { 2L, new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5600), "Second Task", "", new DateTime(2025, 1, 4, 16, 18, 45, 260, DateTimeKind.Local).AddTicks(5601), 2, "Open", 1L, "Task 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boards_UserId",
                table: "Boards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_BoardId",
                table: "TaskLists",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskListId",
                table: "Tasks",
                column: "TaskListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskLists");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
