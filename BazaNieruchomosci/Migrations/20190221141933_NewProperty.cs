using Microsoft.EntityFrameworkCore.Migrations;

namespace BazaNieruchomosci.Migrations
{
    public partial class NewProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Houses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Flats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "CommercialSpaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "BuildingPlots",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "CommercialSpaces");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "BuildingPlots");
        }
    }
}
