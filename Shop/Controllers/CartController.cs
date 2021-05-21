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
        public CartController(ICartRepository cartRepository, ICartItemRepository cartItempRepository, ICartService cartService)
        {
            this._cartRepository = cartRepository;
            this._cartItempRepository = cartItempRepository;
            this._cartService = cartService;
        }

        public ICartRepository _cartRepository { get; }
        public ICartItemRepository _cartItempRepository { get; }
        public ICartService _cartService { get; }

        public async Task<IActionResult> Index()
        {
            string cartId = _cartService.GetCartId();
            Cart cart = await _cartRepository.GetCart(cartId);
            cart.ProcessCart();
            return View(cart);
        }


    }

}
