using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Habitr.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNullableActivityLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Activities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities",
                column: "LocationId",
                principalTable: "GeoLocations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_GeoLocations_LocationId",
                table: "Activities",
                column: "LocationId",
                principalTable: "GeoLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
