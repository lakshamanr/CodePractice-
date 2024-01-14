using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FluentAPIOnetoOneMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_BookID",
                table: "Fluent_BookDetails",
                column: "BookID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_FluentBooks_BookID",
                table: "Fluent_BookDetails",
                column: "BookID",
                principalTable: "FluentBooks",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_FluentBooks_BookID",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_BookID",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "Fluent_BookDetails");
        }
    }
}
