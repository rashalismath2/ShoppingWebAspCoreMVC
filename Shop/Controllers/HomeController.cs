using Microsoft.AspNetCore.Mvc;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IProductRepository products)
        {
            Products = products;
        }

        public IProductRepository Products { get; }

        public IActionResult Index()
        {
          
            return View(Products.NewProducts());
        }
    }
}
