using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BazaNieruchomosci.Migrations
{
    public partial class images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Houses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnail",
                table: "Houses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Flats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnail",
                table: "Flats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CommercialSpaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnail",
                table: "CommercialSpaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BuildingPlots",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnail",
                table: "BuildingPlots",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "ImageThumbnail",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "ImageThumbnail",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CommercialSpaces");

            migrationBuilder.DropColumn(
                name: "ImageThumbnail",
                table: "CommercialSpaces");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "BuildingPlots");

            migrationBuilder.DropColumn(
                name: "ImageThumbnail",
                table: "BuildingPlots");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminPermissions = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
