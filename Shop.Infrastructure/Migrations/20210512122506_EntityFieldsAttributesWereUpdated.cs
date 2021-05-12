using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class EntityFieldsAttributesWereUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Users_UserId",
                table: "Checkouts");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "Checkouts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "CartItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 944, DateTimeKind.Local).AddTicks(8406), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(8835), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9004), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9153), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9312), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9579), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9712), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9856), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 952, DateTimeKind.Local).AddTicks(9984), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(246), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(374), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(769), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(903), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1087), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1215), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1600), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1846), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 17, 55, 4, 953, DateTimeKind.Local).AddTicks(2765), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Users_UserId",
                table: "Checkouts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Users_UserId",
                table: "Checkouts");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Checkouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "Checkouts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 627, DateTimeKind.Local).AddTicks(5219), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 634, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(557), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(732), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(870), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(1035), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(1414), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(1758), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(1984), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(2128), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(2394), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(2836), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(3826), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(3954), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4093), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4221), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4586), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4832), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 12, 16, 9, 46, 635, DateTimeKind.Local).AddTicks(5607), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Users_UserId",
                table: "Checkouts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
