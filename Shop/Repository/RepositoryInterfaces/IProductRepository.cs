using Shop.Models;
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
    }
}
