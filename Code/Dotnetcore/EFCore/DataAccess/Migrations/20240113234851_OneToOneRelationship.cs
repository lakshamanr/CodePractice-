using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class OneToOneRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "BookDetail_ID",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails",
                column: "BookID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails");

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_ID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookID",
                table: "BookDetails",
                column: "BookID");
        }
    }
}
