using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class seedsupdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 681, DateTimeKind.Local).AddTicks(819), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(5755), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6201), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6289), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6355), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6432), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6504), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6571), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6638), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6709), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6776), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6843), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(6909), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(7038), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 5, 54, 684, DateTimeKind.Local).AddTicks(7110), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 750, DateTimeKind.Local).AddTicks(7807), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6017), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6253), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6335), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6485), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6572), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6639), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6705), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6772), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7008), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7090), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7157), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7224), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7285), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7352), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });
        }
    }
}
