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
                    Total = table.Column<float>(nullable: false),
                    SubTotal = table.Column<float>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
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
                    Title = table.Column<string>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DiscountPrecentage = table.Column<float>(nullable: false),
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
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
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
                    CartId = table.Column<string>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    CheckoutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.CheckoutId);
                    table.ForeignKey(
                        name: "FK_Checkouts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkouts_Users_UserId",
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
                    { 1, new DateTime(2021, 5, 21, 15, 22, 49, 718, DateTimeKind.Local).AddTicks(7666), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1501f, "Long Sleeve T-Shirt 1", 0 },
                    { 29, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7344), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 28, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7282), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 27, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7220), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 26, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7133), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 25, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7071), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 24, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(7000), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 23, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6871), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 22, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6815), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 21, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6753), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 20, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6692), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 19, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6630), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 18, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6574), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 17, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6512), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 16, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6451), "", 1.5f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg", 2800f, "GENTS CASUAL SHIRT", 1 },
                    { 14, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6322), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1514f, "Long Sleeve T-Shirt 14", 0 },
                    { 13, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6261), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1513f, "Long Sleeve T-Shirt 13", 0 },
                    { 12, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6194), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1512f, "Long Sleeve T-Shirt 12", 0 },
                    { 11, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6117), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1511f, "Long Sleeve T-Shirt 11", 0 },
                    { 10, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5958), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1510f, "Long Sleeve T-Shirt 10", 0 },
                    { 9, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5886), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1509f, "Long Sleeve T-Shirt 9", 0 },
                    { 8, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5824), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg", 1508f, "Long Sleeve T-Shirt 8", 0 },
                    { 7, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5758), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1507f, "Long Sleeve T-Shirt 7", 0 },
                    { 6, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5691), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1506f, "Long Sleeve T-Shirt 6", 0 },
                    { 5, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5614), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1505f, "Long Sleeve T-Shirt 5", 0 },
                    { 4, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5547), "", 2f, "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg", 1504f, "Long Sleeve T-Shirt 4", 0 },
                    { 3, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5470), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1503f, "Long Sleeve T-Shirt 3", 0 },
                    { 2, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(5219), "", 2f, "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg", 1502f, "Long Sleeve T-Shirt 2", 0 },
                    { 15, new DateTime(2021, 5, 21, 15, 22, 49, 722, DateTimeKind.Local).AddTicks(6389), "", 1.5f, "https://www.nolimit.lk/storage/1-358.jpg", 2800f, "GENTS CASUAL SHIRT", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "ContactNumber", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "Address one", "0750000000", "UserOne@gmail.com", "User", "One", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S" },
                    { 2, "Address one", "0750000000", "admin@admin.com", "Admin", "One", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CartId",
                table: "Checkouts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_UserId",
                table: "Checkouts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
