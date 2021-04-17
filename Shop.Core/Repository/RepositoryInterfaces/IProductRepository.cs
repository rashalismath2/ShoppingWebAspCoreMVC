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
        List<Product> NewProducts();
        Product GetById(int id);
        List<Product> ByCatergory(ProductType category, string filter);
    }
}
