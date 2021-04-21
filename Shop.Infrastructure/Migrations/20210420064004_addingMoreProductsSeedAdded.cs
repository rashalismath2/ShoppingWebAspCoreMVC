using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class addingMoreProductsSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "Title" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 928, DateTimeKind.Local).AddTicks(2478), 1501f, "Long Sleeve T-Shirt 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl", "Price", "Title" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4262), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1502f, "Long Sleeve T-Shirt 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountPrecentage", "ImgUrl", "Price", "Title", "Type" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4595), 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1503f, "Long Sleeve T-Shirt 3", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CreatedDate", "Description", "DiscountPrecentage", "ImgUrl", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4662), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1504f, "Long Sleeve T-Shirt 4", 0 },
                    { 5, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4718), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1505f, "Long Sleeve T-Shirt 5", 0 },
                    { 6, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4790), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1506f, "Long Sleeve T-Shirt 6", 0 },
                    { 7, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4842), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1507f, "Long Sleeve T-Shirt 7", 0 },
                    { 8, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4893), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1508f, "Long Sleeve T-Shirt 8", 0 },
                    { 9, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4949), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1509f, "Long Sleeve T-Shirt 9", 0 },
                    { 10, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5006), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1510f, "Long Sleeve T-Shirt 10", 0 },
                    { 11, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5057), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1511f, "Long Sleeve T-Shirt 11", 0 },
                    { 12, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5108), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1512f, "Long Sleeve T-Shirt 12", 0 },
                    { 13, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5160), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1513f, "Long Sleeve T-Shirt 13", 0 },
                    { 14, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5211), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1514f, "Long Sleeve T-Shirt 14", 0 },
                    { 20, new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5257), "", 1.5f, "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg", 2800f, "GENTS CASUAL SHIRT", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "Title" },
                values: new object[] { new DateTime(2021, 4, 17, 16, 15, 52, 489, DateTimeKind.Local).AddTicks(1194), 1500f, "Long Sleeve T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl", "Price", "Title" },
                values: new object[] { new DateTime(2021, 4, 17, 16, 15, 52, 499, DateTimeKind.Local).AddTicks(8805), "https://www.nolimit.lk/storage/products/135.jpg", 1800f, "Basic Polo T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountPrecentage", "ImgUrl", "Price", "Title", "Type" },
                values: new object[] { new DateTime(2021, 4, 17, 16, 15, 52, 499, DateTimeKind.Local).AddTicks(9438), 1.5f, "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg", 2800f, "GENTS CASUAL SHIRT", 1 });
        }
    }
}
