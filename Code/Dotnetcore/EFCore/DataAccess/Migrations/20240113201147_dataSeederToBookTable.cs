using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class dataSeederToBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "BookTitle", "ISBN", "Price" },
                values: new object[] { 1, "Automic Habits", "1234", 10.10m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "BookTitle", "ISBN", "Price" },
                values: new object[] { 2, "How To Write Journal", "1234", 20.10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);
        }
    }
}
