using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartService _cartService;

        public CartController(
            ICartRepository cartRepository,
            ICartService cartService
         )
        {
            _cartRepository = cartRepository;
            _cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                string cartId = _cartService.GetCartId();
                Cart cart = await _cartRepository.GetCart(cartId);
                cart.ProcessCart();
                return View(cart);
            }
            catch (Exception)
            {
                throw;
            }
           
        }


    }

}
