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
        public ProductRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public List<Product> NewProducts()
        {
            return DbContext.Products.OrderBy(p=>p.CreatedDate).Take(4).ToList();
        }

        public Product GetById(int id) {

            return  DbContext.Products.Where(p=>p.ProductId==id).FirstOrDefault();
        }

        public List<Product> ByCatergory(
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
                        if (pageNumber!=null && pageNumber>1) {
                            return DbContext.Products
                               .Where(p => p.Type == category)
                               .Skip(productsPerPage * ((int)pageNumber - 1)).Take(productsPerPage)
                               .OrderByDescending(p => p.Price)
                               .ToList();
                        }
                        return DbContext.Products
                            .Where(p => p.Type == category)
                            .Take(productsPerPage)
                            .OrderByDescending(p=>p.Price)
                            .ToList();
                    default:
                        break;
                }
            }

            if (pageNumber != null && pageNumber > 1)
            {
                return DbContext.Products.Where(p => p.Type == category)
                   .Skip(productsPerPage * ((int)pageNumber - 1)).Take(productsPerPage)
                   .ToList();
            }

            return DbContext.Products.Where(p=>p.Type==category)
                .Take(productsPerPage)
                .ToList();
        }

        public int ProductByCategoryLength(ProductType category)
        {
            return DbContext.Products.Where(p => p.Type == category).Count();
        }
    }
}
