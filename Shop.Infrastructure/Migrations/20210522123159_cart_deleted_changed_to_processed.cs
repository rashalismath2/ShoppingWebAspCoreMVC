using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class cart_deleted_changed_to_processed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Carts");

            migrationBuilder.AddColumn<bool>(
                name: "processed",
                table: "Carts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 721, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7202), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7289), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7361), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7761), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7833), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(7977), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8044), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8110), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8239), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8305), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8372), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8577), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8644), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8711), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8839), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8906), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(8972), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(9034), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(9101), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 22, 18, 1, 57, 724, DateTimeKind.Local).AddTicks(9162), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "processed",
                table: "Carts");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 718, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5470), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5547), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5614), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5886), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5958), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6194), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6261), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6322), "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6451), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6512), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6574), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6692), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6753), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6815), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7000), "https://www.nolimit.lk/storage/1-358.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7071), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7133), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7220), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7282), "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ImgUrl" },
                values: new object[] { new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7344), "https://www.nolimit.lk/storage/1-358.jpg" });
        }
    }
}
