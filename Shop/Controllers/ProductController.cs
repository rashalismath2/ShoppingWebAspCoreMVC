
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(IProductRepository products)
        {
            Products = products;
        }

        public IProductRepository Products { get; }

        public IActionResult Index() {
            return View("NotFound");
        }

        public IActionResult Details(int id) {
            Product product =Products.GetById(id);
            if (product==null) {
                return View("NotFound");
            }
            return View(product);
        }
    }
}
