using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Deletedboolcolumnaddedtothecarttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Carts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 4, 30, 238, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 4, 30, 246, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 4, 30, 246, DateTimeKind.Local).AddTicks(471));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 12, 48, 22, 609, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 12, 48, 22, 618, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 12, 48, 22, 618, DateTimeKind.Local).AddTicks(3588));
        }
    }
}
