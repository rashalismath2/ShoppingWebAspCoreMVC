using Shop.Models;
using Shop.Models.Enums;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
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
            return DbContext.Products.OrderBy(p=>p.CreatedDate).ToList();
        }

        public Product GetById(int id) {

            return  DbContext.Products.Where(p=>p.ProductId==id).FirstOrDefault();
        }

        public List<Product> ByCatergory(ProductType category,string filter)
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                switch (filter)
                {
                    case "high-t-low":
                        return DbContext.Products.Where(p => p.Type == category).OrderByDescending(p=>p.Price).ToList();
                    default:
                        break;
                }
            }
            return DbContext.Products.Where(p=>p.Type==category).ToList();
        }
    }
}
