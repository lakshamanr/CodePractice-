using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addNewTableCustomeManyTomayMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomeFluentAuthorBookMap",
                columns: table => new
                {
                    Author_id = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomeFluentAuthorBookMap", x => new { x.BookID, x.Author_id });
                    table.ForeignKey(
                        name: "FK_CustomeFluentAuthorBookMap_FluentAuthor_Author_id",
                        column: x => x.Author_id,
                        principalTable: "FluentAuthor",
                        principalColumn: "Author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomeFluentAuthorBookMap_FluentBooks_BookID",
                        column: x => x.BookID,
                        principalTable: "FluentBooks",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomeFluentAuthorBookMap_Author_id",
                table: "CustomeFluentAuthorBookMap",
                column: "Author_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomeFluentAuthorBookMap");
        }
    }
}
