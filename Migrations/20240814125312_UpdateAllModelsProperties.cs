using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Habitr.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModelsProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "GeoLocations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "GeoLocations",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "GeoLocations",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "GeoLocations");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "GeoLocations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "GeoLocations");
        }
    }
}
