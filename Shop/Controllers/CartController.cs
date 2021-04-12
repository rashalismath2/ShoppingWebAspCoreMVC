﻿using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        public CartController(ICartRepository CartRepository, ICartItemRepository CartItempRepository)
        {
            this.CartRepository = CartRepository;
            this.CartItempRepository = CartItempRepository;
        }

        public ICartRepository CartRepository { get; }
        public ICartItemRepository CartItempRepository { get; }

        public async Task<IActionResult> Index()
        {
            Cart cart = await CartRepository.GetCart();

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int deleteCartItemId)
        {
            await CartItempRepository.DeleteById(deleteCartItemId);
            TempData["CartItemRemoved"] = "Cart Item Removed";
            return RedirectToAction("Index");
        }
    }
}
