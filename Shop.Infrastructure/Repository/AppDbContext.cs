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
            for (int i = 1; i < 15; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product()
                {
                    ProductId = i,
                    Title = "Long Sleeve T-Shirt "+i,
                    ImgUrl = "https://www.nolimit.lk/storage/products/NOLIMIT-Online_0114__W0A7136.jpg",
                    Type = ProductType.TShirt,
                    DiscountPrecentage = 2,
                    Price = 1500+i,
                    Description = "",
                    CreatedDate = DateTime.Now
                });
            }
      
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 20,
                Title = "GENTS CASUAL SHIRT",
                ImgUrl = "https://www.nolimit.lk/storage/online-shoot-0008-w0a8003-1.jpg",
                Type = ProductType.Shirt,
                DiscountPrecentage = (float)1.5,
                Price = 2800,
                Description = "",
                CreatedDate = DateTime.Now
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                FirstName = "User",
                LastName = "One",
                Email = "UserOne@gmail.com",
                Address = "Address one",
                ContactNumber = "0750000000"
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
