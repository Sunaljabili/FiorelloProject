using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class BlogSayStartInstagramAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 300, nullable: true),
                    CardImage = table.Column<string>(nullable: true),
                    CardTitle = table.Column<string>(maxLength: 50, nullable: true),
                    CardBody = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instagrams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instagrams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SayStarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertImage = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    ExpertName = table.Column<string>(maxLength: 50, nullable: true),
                    ExpertPosition = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SayStarts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Instagrams");

            migrationBuilder.DropTable(
                name: "SayStarts");
        }
    }
}
