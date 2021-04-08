using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class DBseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "ContactNumber", "Email", "FirstName", "FullName", "LastName" },
                values: new object[] { 1, "Address one", "0750000000", "UserOne@gmail.com", "User", null, "One" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
