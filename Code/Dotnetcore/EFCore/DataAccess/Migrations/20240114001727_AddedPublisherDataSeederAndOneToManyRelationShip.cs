using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddedPublisherDataSeederAndOneToManyRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_ID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_ID", "Location", "Name" },
                values: new object[] { 1, "Pune", "ABC" });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_ID", "Location", "Name" },
                values: new object[] { 2, "Ambe", "MNO" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1,
                column: "Publisher_ID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2,
                column: "Publisher_ID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Publisher_ID",
                table: "Books",
                column: "Publisher_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_Publisher_ID",
                table: "Books",
                column: "Publisher_ID",
                principalTable: "Publishers",
                principalColumn: "Publisher_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_Publisher_ID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Publisher_ID",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Publisher_ID",
                table: "Books");
        }
    }
}
