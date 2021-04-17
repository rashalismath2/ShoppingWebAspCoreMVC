using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;

namespace Shop.Test
{
    [TestClass]
    public class CartTest
    {

        private List<CartItem> cartItems;
        private Cart cart;

        [TestInitialize]
        public void TestInitialize()
        {
            Product productOne = new Product()
            {
                Title = "Shirt",
                Type = ProductType.Shirt,
                ProductId = 1,
                Price = 1500,
                DiscountPrecentage = 10
            };
            Product productTwo = new Product()
            {
                Title = "T-Shirt",
                Type = ProductType.TShirt,
                ProductId = 2,
                Price = 1000,
                DiscountPrecentage = 5
            };

            cartItems = new List<CartItem>() {
                new CartItem(){ 
                    Product=productOne,
                    Qty=10
                },
                new CartItem(){
                    Product=productTwo,
                    Qty=5
                }
            };

            cart = new Cart()
            {
                CartItems = cartItems
            };
        }

        [TestMethod]
        public void GetDiscount_Valid()
        {
            var expected = 1750;
            var result = cart.GetDiscount();

            Assert.AreEqual(expected,result);

        }
        [TestMethod]
        public void GetDiscount_WhenCartItemsWereZero_ReturnsZero()
        {
            cart.CartItems = new List<CartItem>();
            var expected = 0;
            var result = cart.GetDiscount();

            Assert.AreEqual(expected, result);

        }



        [TestMethod]
        public void GetSubTotal_Valid()
        {
            var expected = 20000;
            var result = cart.GetSubTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSubTotal_WhenCartItemsWereZero_ReturnsZero()
        {
            cart.CartItems = new List<CartItem>();
            var expected = 0;
            var result = cart.GetSubTotal();

            Assert.AreEqual(expected, result);

        }



        [TestMethod]
        public void GetTotal_Valid()
        {
            var expected = 18250;
            var result = cart.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WhenCartItemsWereZero_ReturnsZero()
        {
            cart.CartItems = new List<CartItem>();
            var expected = 0;
            var result = cart.GetTotal();

            Assert.AreEqual(expected, result);

        }
    }
}
