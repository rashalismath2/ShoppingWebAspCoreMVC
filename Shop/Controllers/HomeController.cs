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
        private readonly IProductRepository _productsRepository;
        public HomeController(IProductRepository products)
        {
            _productsRepository = products;
        }

        public async Task<IActionResult> Index([FromQuery] string success)
        {
            if (success!=null) {
                TempData["SuccessMessage"] = success;
            }
            return View(await _productsRepository.NewProducts());
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
