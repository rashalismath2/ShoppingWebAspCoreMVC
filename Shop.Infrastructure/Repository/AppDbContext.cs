using Microsoft.EntityFrameworkCore;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] listOfTShirts = {
                "https://www.nolimit.lk/storage/baseball-web2-recovered2-0043-0t3a9660.jpg",
                "https://www.nolimit.lk/storage/baseball-web2-recovered2-0064-0t3a9626.jpg",
                "https://www.nolimit.lk/storage/products/Gents-1-2020_0032__W0A8616.jpg",
                "https://www.nolimit.lk/storage/1-343.jpg"
            };

            string[] listOfShirts = {
                "https://www.nolimit.lk/storage/baseball-web2-recovered2-0004-0t3a9733.jpg",
                "https://www.nolimit.lk/storage/1-358.jpg",
                "https://www.nolimit.lk/storage/baseball-web2-recovered2-0112-0t3a9535.jpg",
                "https://www.nolimit.lk/storage/1-357.jpg"
            };

            for (int i = 1; i < 15; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product()
                {
                    ProductId = i,
                    Title = "Long Sleeve T-Shirt " + i,
                    ImgUrl = listOfTShirts[new Random().Next(0, 3)],
                    Type = ProductType.TShirt,
                    DiscountPrecentage = 2,
                    Price = 1500 + i,
                    Description = "",
                    CreatedDate = DateTime.Now
                });


            
            }

            for (int i = 15; i < 30; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product()
                {
                    ProductId =i,
                    Title = "GENTS CASUAL SHIRT",
                    ImgUrl = listOfShirts[new Random().Next(0, 3)],
                    Type = ProductType.Shirt,
                    DiscountPrecentage = (float)1.5,
                    Price = 2800,
                    Description = "",
                    CreatedDate = DateTime.Now
                });
            }

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                FirstName = "User",
                LastName = "One",
                Email = "UserOne@gmail.com",
                Address = "Address one",
                ContactNumber = "0750000000",
                Password = "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 2,
                FirstName = "Admin",
                LastName = "One",
                Email = "admin@admin.com",
                Address = "Address one",
                ContactNumber = "0750000000",
                Password = "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S"
            });

        }
    }
}
