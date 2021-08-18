using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeoApp.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Accuracy = table.Column<double>(nullable: false),
                    MeasurementDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoObjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeoObjects");
        }
    }
}
