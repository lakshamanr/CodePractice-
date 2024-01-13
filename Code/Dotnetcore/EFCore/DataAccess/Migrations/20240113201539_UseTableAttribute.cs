using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class UseTableAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "SGT_GENRE");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "SGT_BOOK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SGT_GENRE",
                table: "SGT_GENRE",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SGT_BOOK",
                table: "SGT_BOOK",
                column: "BookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SGT_GENRE",
                table: "SGT_GENRE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SGT_BOOK",
                table: "SGT_BOOK");

            migrationBuilder.RenameTable(
                name: "SGT_GENRE",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "SGT_BOOK",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookID");
        }
    }
}
