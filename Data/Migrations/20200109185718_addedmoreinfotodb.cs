using Microsoft.EntityFrameworkCore.Migrations;

namespace NWI2.Data.Migrations
{
    public partial class addedmoreinfotodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kenosha",
                table: "GED");

            migrationBuilder.DropColumn(
                name: "Milwaukee",
                table: "GED");

            migrationBuilder.DropColumn(
                name: "Racine",
                table: "GED");

            migrationBuilder.AddColumn<string>(
                name: "LOCATION",
                table: "GED",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LOCATION",
                table: "GED");

            migrationBuilder.AddColumn<string>(
                name: "Kenosha",
                table: "GED",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Milwaukee",
                table: "GED",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Racine",
                table: "GED",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
