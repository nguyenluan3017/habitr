using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Habitr.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Activities",
                newName: "GeoLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_LocationId",
                table: "Activities",
                newName: "IX_Activities_GeoLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_GeoLocations_GeoLocationId",
                table: "Activities",
                column: "GeoLocationId",
                principalTable: "GeoLocations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_GeoLocations_GeoLocationId",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "GeoLocationId",
                table: "Activities",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_GeoLocationId",
                table: "Activities",
                newName: "IX_Activities_LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities",
                column: "LocationId",
                principalTable: "GeoLocations",
                principalColumn: "Id");
        }
    }
}
