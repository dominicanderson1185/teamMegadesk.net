using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_megadesk_.net.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(nullable: false),
                    productionTime = table.Column<int>(nullable: false),
                    deskWidth = table.Column<double>(nullable: false),
                    deskDepth = table.Column<double>(nullable: false),
                    deskMaterial = table.Column<int>(nullable: false),
                    deskDrawers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
