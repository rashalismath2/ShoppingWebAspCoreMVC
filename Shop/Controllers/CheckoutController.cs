using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CheckoutController : Controller
    {
        public CheckoutController(ICartRepository CartRepository)
        {
            this.CartRepository = CartRepository;
        }

        public ICartRepository CartRepository { get; }

        public async Task<IActionResult> Index()
        {
            Cart cart =await CartRepository.GetCart();
            
            return View(cart);
        }
    }
}
