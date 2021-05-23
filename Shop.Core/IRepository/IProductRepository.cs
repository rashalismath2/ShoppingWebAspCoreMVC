using Shop.Core.Models;
using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Repository.RepositoryInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> NewProducts();
        Task<Product> GetById(int id);
        Task<List<Product>> ByCatergory(ProductType category, string filter, int? pageNumber, int ProductsPerPage);

        int ProductByCategoryLength(ProductType category);
    }
}
