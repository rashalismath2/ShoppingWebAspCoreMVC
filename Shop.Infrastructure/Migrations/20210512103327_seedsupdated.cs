using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class seedsupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Checkouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Checkouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Checkouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Checkouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 928, DateTimeKind.Local).AddTicks(2478), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4262), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4595), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4662), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4718), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4790), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4842), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4893), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(4949), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5006), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5057), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5108), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5160), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5211), "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 4, 20, 12, 10, 3, 933, DateTimeKind.Local).AddTicks(5257), "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg" });
        }
    }
}
