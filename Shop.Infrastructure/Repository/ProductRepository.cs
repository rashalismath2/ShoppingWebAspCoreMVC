using Microsoft.EntityFrameworkCore;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> NewProducts()
        {
            return await _dbContext.Products.OrderBy(p => p.CreatedDate).Take(4).ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _dbContext.Products.Where(p => p.ProductId == id).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> ByCatergory(
                            ProductType category,
                            string filter,
                            int? pageNumber,
                            int productsPerPage
        )
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                switch (filter)
                {
                    case "high-t-low":
                        if (pageNumber != null && pageNumber > 1)
                        {
                            return await _dbContext.Products
                               .Where(p => p.Type == category)
                               .Skip(productsPerPage * ((int)pageNumber - 1)).Take(productsPerPage)
                               .OrderByDescending(p => p.Price)
                               .ToListAsync();
                        }
                        return await _dbContext.Products
                            .Where(p => p.Type == category)
                            .Take(productsPerPage)
                            .OrderByDescending(p => p.Price)
                            .ToListAsync();
                    default:
                        break;
                }
            }

            if (pageNumber != null && pageNumber > 1)
            {
                return await _dbContext.Products.Where(p => p.Type == category)
                   .Skip(productsPerPage * ((int)pageNumber - 1)).Take(productsPerPage)
                   .ToListAsync();
            }

            return await _dbContext.Products.Where(p => p.Type == category)
                .Take(productsPerPage)
                .ToListAsync();
        }

        public int ProductByCategoryLength(ProductType category)
        {
            return _dbContext.Products.Where(p => p.Type == category).Count();
        }
    }
}
