﻿using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        public CartController(ICartRepository CartRepository, ICartItemRepository CartItempRepository, ICartService CartService)
        {
            this.CartRepository = CartRepository;
            this.CartItempRepository = CartItempRepository;
            this.CartService = CartService;
        }

        public ICartRepository CartRepository { get; }
        public ICartItemRepository CartItempRepository { get; }
        public ICartService CartService { get; }

        public async Task<IActionResult> Index()
        {
            string cartId = CartService.GetCartIdFromSession();
            Cart cart = await CartRepository.GetCart(cartId);

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int deleteCartItemId)
        {
            CartItem cartItem = await CartItempRepository.DeleteById(deleteCartItemId);
            if (cartItem != null)
            {
                TempData["CartItemRemoved"] = "Cart Item Removed";
            }
            else
            {
                TempData["CartItemRemoved"] = "Cart Item Was Not Found";
            }
            return RedirectToAction("Index");
        }

    }

}
