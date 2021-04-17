using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Core.Migrations
{
    public partial class cartidfieldupdatedincheckouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Carts_CartId1",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_CartId1",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "Checkouts");

            migrationBuilder.AlterColumn<string>(
                name: "CartId",
                table: "Checkouts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CartId",
                table: "Checkouts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Carts_CartId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_CartId",
                table: "Checkouts");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Checkouts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CartId1",
                table: "Checkouts",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CartId1",
                table: "Checkouts",
                column: "CartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Carts_CartId1",
                table: "Checkouts",
                column: "CartId1",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
