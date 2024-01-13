using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class DeletedTheTableAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_ID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_BookID",
                table: "BookDetails",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_BookID",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "BookDetail_ID",
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
    }
}
