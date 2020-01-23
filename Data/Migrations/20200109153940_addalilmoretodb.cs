using Microsoft.EntityFrameworkCore.Migrations;

namespace NWI2.Data.Migrations
{
    public partial class addalilmoretodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GED",
                columns: table => new
                {
                    VID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STUDENTINFO = table.Column<string>(nullable: true),
                    CLASSES = table.Column<string>(nullable: true),
                    EMPLOYED = table.Column<string>(nullable: true),
                    Racine = table.Column<string>(nullable: true),
                    Milwaukee = table.Column<string>(nullable: true),
                    Kenosha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GED", x => x.VID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GED");
        }
    }
}
