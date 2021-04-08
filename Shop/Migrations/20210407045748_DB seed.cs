using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class DBseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Color", "Description", "DiscountPrecentage", "ImgUrl", "Price", "Size", "Title", "Type" },
                values: new object[] { 1, 0, "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1500f, 0, "Long Sleeve T-Shirt", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Color", "Description", "DiscountPrecentage", "ImgUrl", "Price", "Size", "Title", "Type" },
                values: new object[] { 2, 2, "", 2f, "https://www.nolimit.lk/storage/products/135.jpg", 1800f, 1, "Basic Polo T-Shirt", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Color", "Description", "DiscountPrecentage", "ImgUrl", "Price", "Size", "Title", "Type" },
                values: new object[] { 3, 1, "", 1.5f, "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg", 2800f, 2, "GENTS CASUAL SHIRT", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
