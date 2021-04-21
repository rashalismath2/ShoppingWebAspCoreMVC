using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class cartidfieldaddedtothecartitemtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 14, 17, 31, 341, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 14, 17, 31, 350, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 14, 17, 31, 350, DateTimeKind.Local).AddTicks(7621));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 44, 21, 936, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 44, 21, 943, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 13, 44, 21, 943, DateTimeKind.Local).AddTicks(859));
        }
    }
}
