using Microsoft.EntityFrameworkCore.Migrations;

namespace BazaNieruchomosci.Migrations
{
    public partial class ModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlotArea",
                table: "Houses",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlotArea",
                table: "Houses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
