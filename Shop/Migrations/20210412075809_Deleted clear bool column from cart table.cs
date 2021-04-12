using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Deletedclearboolcolumnfromcarttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cleared",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 28, 7, 296, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 28, 7, 305, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 28, 7, 305, DateTimeKind.Local).AddTicks(9386));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cleared",
                table: "Carts",
                type: "bit",
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
    }
}
