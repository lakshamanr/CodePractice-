using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class OneToManyReleationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_ID",
                table: "FluentBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_Publisher_ID",
                table: "FluentBooks",
                column: "Publisher_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentPublishers_Publisher_ID",
                table: "FluentBooks",
                column: "Publisher_ID",
                principalTable: "FluentPublishers",
                principalColumn: "Publisher_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentPublishers_Publisher_ID",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_Publisher_ID",
                table: "FluentBooks");

            migrationBuilder.DropColumn(
                name: "Publisher_ID",
                table: "FluentBooks");
        }
    }
}
