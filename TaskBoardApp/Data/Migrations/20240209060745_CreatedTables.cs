using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Data.Migrations
{
    public partial class CreatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "54f91466-58af-4629-b32a-b22a748a2aa5", 0, "439368d2-5d5a-4c6a-b15a-17a021e33ded", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEI41wO9smu78WzVDZuiDyqUw7OEMGSSt1OGFEmdUNl3zJuR3bT6rIRBoeNs71JkxPA==", null, false, "58127336-c3a0-4df8-9ff1-b3cceeca2a7f", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 24, 8, 7, 44, 521, DateTimeKind.Local).AddTicks(5831), "Implement better styling for all public pages", "54f91466-58af-4629-b32a-b22a748a2aa5", "Improve CSS styles", null },
                    { 2, 1, new DateTime(2024, 2, 4, 8, 7, 44, 521, DateTimeKind.Local).AddTicks(5889), "Create Android client app for the TaskBoard RESTful API", "54f91466-58af-4629-b32a-b22a748a2aa5", "Android Client App", null },
                    { 3, 2, new DateTime(2024, 2, 8, 8, 7, 44, 521, DateTimeKind.Local).AddTicks(5893), "Create Windows Forms desktop app client for the TaskBoard RESTful API", "54f91466-58af-4629-b32a-b22a748a2aa5", "Desktop Client App", null },
                    { 4, 3, new DateTime(2024, 2, 8, 8, 7, 44, 521, DateTimeKind.Local).AddTicks(5896), "Implement [Create Task] page for adding new tasks", "54f91466-58af-4629-b32a-b22a748a2aa5", "Create Tasks", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54f91466-58af-4629-b32a-b22a748a2aa5");
        }
    }
}
