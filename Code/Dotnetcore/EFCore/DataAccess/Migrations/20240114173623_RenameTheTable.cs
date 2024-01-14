using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class RenameTheTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomeFluentAuthorBookMap_FluentAuthor_Author_id",
                table: "CustomeFluentAuthorBookMap");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomeFluentAuthorBookMap_FluentBooks_BookID",
                table: "CustomeFluentAuthorBookMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomeFluentAuthorBookMap",
                table: "CustomeFluentAuthorBookMap");

            migrationBuilder.RenameTable(
                name: "CustomeFluentAuthorBookMap",
                newName: "FluentAuthorBookMap");

            migrationBuilder.RenameIndex(
                name: "IX_CustomeFluentAuthorBookMap_Author_id",
                table: "FluentAuthorBookMap",
                newName: "IX_FluentAuthorBookMap_Author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentAuthorBookMap",
                table: "FluentAuthorBookMap",
                columns: new[] { "BookID", "Author_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_FluentAuthorBookMap_FluentAuthor_Author_id",
                table: "FluentAuthorBookMap",
                column: "Author_id",
                principalTable: "FluentAuthor",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentAuthorBookMap_FluentBooks_BookID",
                table: "FluentAuthorBookMap",
                column: "BookID",
                principalTable: "FluentBooks",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentAuthorBookMap_FluentAuthor_Author_id",
                table: "FluentAuthorBookMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentAuthorBookMap_FluentBooks_BookID",
                table: "FluentAuthorBookMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentAuthorBookMap",
                table: "FluentAuthorBookMap");

            migrationBuilder.RenameTable(
                name: "FluentAuthorBookMap",
                newName: "CustomeFluentAuthorBookMap");

            migrationBuilder.RenameIndex(
                name: "IX_FluentAuthorBookMap_Author_id",
                table: "CustomeFluentAuthorBookMap",
                newName: "IX_CustomeFluentAuthorBookMap_Author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomeFluentAuthorBookMap",
                table: "CustomeFluentAuthorBookMap",
                columns: new[] { "BookID", "Author_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomeFluentAuthorBookMap_FluentAuthor_Author_id",
                table: "CustomeFluentAuthorBookMap",
                column: "Author_id",
                principalTable: "FluentAuthor",
                principalColumn: "Author_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomeFluentAuthorBookMap_FluentBooks_BookID",
                table: "CustomeFluentAuthorBookMap",
                column: "BookID",
                principalTable: "FluentBooks",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
