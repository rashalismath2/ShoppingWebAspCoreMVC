using Microsoft.AspNetCore.Mvc;
using Shop.Core.Repository.RepositoryInterfaces;
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

        public IActionResult Index([FromQuery] string success)
        {
            if (success!=null) {
                TempData["SuccessMessage"] = success;
            }
            return View(Products.NewProducts());
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
