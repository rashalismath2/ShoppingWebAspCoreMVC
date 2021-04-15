using Shop.Models;
using Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository.RepositoryInterfaces
{
    public interface IProductRepository
    {
        List<Product> NewProducts();
        Product GetById(int id);
        List<Product> ByCatergory(ProductType category, string filter);
    }
}
