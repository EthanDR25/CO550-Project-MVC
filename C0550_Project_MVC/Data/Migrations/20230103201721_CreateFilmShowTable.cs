using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C0550_Project_MVC.Data.Migrations
{
    public partial class CreateFilmShowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmShow",
                columns: table => new
                {
                    FilmShowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmShow", x => x.FilmShowID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmShow");
        }
    }
}
