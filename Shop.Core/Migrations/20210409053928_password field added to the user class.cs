using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Core.Migrations
{
    public partial class passwordfieldaddedtotheuserclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "DiscountPrecentage",
                table: "Products",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 9, 11, 9, 26, 745, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 9, 11, 9, 26, 755, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 9, 11, 9, 26, 755, DateTimeKind.Local).AddTicks(2384));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<float>(
                name: "DiscountPrecentage",
                table: "Products",
                type: "real",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 8, 11, 54, 32, 398, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 8, 11, 54, 32, 403, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 8, 11, 54, 32, 403, DateTimeKind.Local).AddTicks(3515));
        }
    }
}
