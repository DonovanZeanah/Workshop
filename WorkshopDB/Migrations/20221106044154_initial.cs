using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopDB.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WsProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WsProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tools_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StationId = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Tools_ToolId",
                        column: x => x.ToolId,
                        principalTable: "Tools",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception of Workshop Program" },
                    { 2, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weekday - typical day spent not being a millionaire" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name", "Price", "StationId", "ToolId", "Type" },
                values: new object[,]
                {
                    { 1, "2x4", 30.0, 4, null, "Wood" },
                    { 2, "Steel", 10.0, 4, null, "Metal-Rod" },
                    { 3, "steel", 20.0, 4, null, "Sheet-metal" },
                    { 4, "Brick", 3.0, 4, null, "Regular" },
                    { 5, "Brick", 8.0, 4, null, "CinderBlock" },
                    { 6, "Glass", 11.0, 4, null, "Stained-Blue" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A dedicated station for cleaning. It is more efficient to clean things here, than anywhere else!", "Cleaning" },
                    { 2, "A universal Workbench. Your vice is here, stop using the floor to work on your projects...", "Workbench" },
                    { 3, "A random location with which none of your tools are present at ...because you didn't put them ... you suck; change.", "ToolWall" },
                    { 4, "A place for all the scrap material your not man enough to throw away", "Storage" }
                });

            migrationBuilder.InsertData(
                table: "WsProjects",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Dedicated cameras pointed at different stations to capture action and auto-sequence a video timeline.", "Video System" },
                    { 2, "Modify a pressure washer and combine it with the cnc system of a 3d printer to cut complex sheet metal programmatically (preferably while sleeping.)", "Waterjet" }
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Name", "Price", "StationId", "Type" },
                values: new object[,]
                {
                    { 1, "Hammer", 20.0, 3, "Regular" },
                    { 2, "Saw", 15.0, 3, "Hack" },
                    { 3, "Drill", 80.0, 3, "Cordless-Electric" },
                    { 4, "Chisel", 5.0, 3, "3 \"" },
                    { 5, "Saw", 150.0, 3, "Mitre" },
                    { 6, "Drillbit", 13.0, 3, "Forestner - 30 mm" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ToolId",
                table: "Materials",
                column: "ToolId");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_StationId",
                table: "Tools",
                column: "StationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "WsProjects");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
