using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    Cleared = table.Column<bool>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    SubTotal = table.Column<float>(nullable: false),
                    Discount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DiscountPrecentage = table.Column<float>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    SubTotal = table.Column<float>(nullable: false),
                    Discount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: true),
                    Total = table.Column<float>(nullable: false),
                    SubTotal = table.Column<float>(nullable: false),
                    DiscountPrecentage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CreatedDate", "Description", "DiscountPrecentage", "ImgUrl", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 8, 11, 54, 32, 398, DateTimeKind.Local).AddTicks(2758), "", 2f, "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg", 1500f, "Long Sleeve T-Shirt", 0 },
                    { 2, new DateTime(2021, 4, 8, 11, 54, 32, 403, DateTimeKind.Local).AddTicks(3212), "", 2f, "https://www.nolimit.lk/storage/products/135.jpg", 1800f, "Basic Polo T-Shirt", 0 },
                    { 3, new DateTime(2021, 4, 8, 11, 54, 32, 403, DateTimeKind.Local).AddTicks(3515), "", 1.5f, "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg", 2800f, "GENTS CASUAL SHIRT", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "ContactNumber", "Email", "FirstName", "FullName", "LastName" },
                values: new object[] { 1, "Address one", "0750000000", "UserOne@gmail.com", "User", null, "One" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
