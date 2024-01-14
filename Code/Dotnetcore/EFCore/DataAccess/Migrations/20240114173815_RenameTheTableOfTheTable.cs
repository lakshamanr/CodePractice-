using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class RenameTheTableOfTheTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_FluentBooks_BookID",
                table: "Fluent_BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "Fluent_BookDetails",
                newName: "FluentBookDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookDetails_BookID",
                table: "FluentBookDetails",
                newName: "IX_FluentBookDetails_BookID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentBookDetails",
                table: "FluentBookDetails",
                column: "BookDetail_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookDetails_FluentBooks_BookID",
                table: "FluentBookDetails",
                column: "BookID",
                principalTable: "FluentBooks",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookDetails_FluentBooks_BookID",
                table: "FluentBookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentBookDetails",
                table: "FluentBookDetails");

            migrationBuilder.RenameTable(
                name: "FluentBookDetails",
                newName: "Fluent_BookDetails");

            migrationBuilder.RenameIndex(
                name: "IX_FluentBookDetails_BookID",
                table: "Fluent_BookDetails",
                newName: "IX_Fluent_BookDetails_BookID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails",
                column: "BookDetail_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_FluentBooks_BookID",
                table: "Fluent_BookDetails",
                column: "BookID",
                principalTable: "FluentBooks",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
