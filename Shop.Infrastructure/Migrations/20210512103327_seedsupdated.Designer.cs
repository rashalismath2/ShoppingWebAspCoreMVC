﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Infrastructure.Repository;

namespace Shop.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210512103327_seedsupdated")]
    partial class seedsupdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Core.Models.Cart", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Shop.Core.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Shop.Core.Models.Checkout", b =>
                {
                    b.Property<int>("CheckoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CheckoutId");

                    b.HasIndex("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("Shop.Core.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DiscountPrecentage")
                        .HasColumnType("real");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 750, DateTimeKind.Local).AddTicks(7807),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                            Price = 1501f,
                            Title = "Long Sleeve T-Shirt 1",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 2,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6017),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                            Price = 1502f,
                            Title = "Long Sleeve T-Shirt 2",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 3,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6253),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                            Price = 1503f,
                            Title = "Long Sleeve T-Shirt 3",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 4,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6335),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg",
                            Price = 1504f,
                            Title = "Long Sleeve T-Shirt 4",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 5,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6485),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1505f,
                            Title = "Long Sleeve T-Shirt 5",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 6,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6572),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg",
                            Price = 1506f,
                            Title = "Long Sleeve T-Shirt 6",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 7,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6639),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                            Price = 1507f,
                            Title = "Long Sleeve T-Shirt 7",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 8,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6705),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1508f,
                            Title = "Long Sleeve T-Shirt 8",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 9,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(6772),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1509f,
                            Title = "Long Sleeve T-Shirt 9",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 10,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7008),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1510f,
                            Title = "Long Sleeve T-Shirt 10",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 11,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7090),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1511f,
                            Title = "Long Sleeve T-Shirt 11",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 12,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7157),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1512f,
                            Title = "Long Sleeve T-Shirt 12",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 13,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7224),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                            Price = 1513f,
                            Title = "Long Sleeve T-Shirt 13",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 14,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7285),
                            Description = "",
                            DiscountPrecentage = 2f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                            Price = 1514f,
                            Title = "Long Sleeve T-Shirt 14",
                            Type = 0
                        },
                        new
                        {
                            ProductId = 20,
                            CreatedDate = new DateTime(2021, 5, 12, 16, 3, 26, 754, DateTimeKind.Local).AddTicks(7352),
                            Description = "",
                            DiscountPrecentage = 1.5f,
                            ImgUrl = "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg",
                            Price = 2800f,
                            Title = "GENTS CASUAL SHIRT",
                            Type = 1
                        });
                });

            modelBuilder.Entity("Shop.Core.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "Address one",
                            ContactNumber = "0750000000",
                            Email = "UserOne@gmail.com",
                            FirstName = "User",
                            LastName = "One"
                        },
                        new
                        {
                            UserId = 2,
                            Address = "Address one",
                            ContactNumber = "0750000000",
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "One",
                            Password = "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S"
                        });
                });

            modelBuilder.Entity("Shop.Core.Models.CartItem", b =>
                {
                    b.HasOne("Shop.Core.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("Shop.Core.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Core.Models.Checkout", b =>
                {
                    b.HasOne("Shop.Core.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");

                    b.HasOne("Shop.Core.Models.User", "User")
                        .WithMany("Checkouts")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
