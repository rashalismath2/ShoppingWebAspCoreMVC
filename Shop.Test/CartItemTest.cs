using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using System;

namespace Shop.Test
{
    [TestClass]
    public class CartItemTest
    {
        private Product product;

        [TestInitialize]
        public void TestInitialize() {
            product = new Product() { 
                Title="Shirt",
                Type=ProductType.Shirt,
                ProductId=1,
                Price=1500,
                DiscountPrecentage=5
            };
        }

        [TestMethod]
        public void GetTotal_WithoutProduct_ShouldReturnZero()
        {
            CartItem cartItem = new CartItem();
            product = null;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void GetTotal_WithZeroProductPrice_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 0.0f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0.0f* 5 - product.DiscountPrecentage * 0*5 / 100;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WithLowFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 10.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 10.50f* 5 - product.DiscountPrecentage * 10.50f*5 / 100;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WithHighFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 1005.50f*5 - product.DiscountPrecentage*1005.50f *5/ 100;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WithZeroQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;
            cartItem.Qty = 0;

            var expected =0;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WithNoQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;

            var expected =0;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetTotal_WithNoProductDiscountPrecentage_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            product.DiscountPrecentage = 0;
            cartItem.Qty =5;
            cartItem.Product = product;

            var expected =5* 1005.50f;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetTotal_WithProductDiscountPrecentage_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = product.Price * 5-product.DiscountPrecentage* product.Price*5 / 100;

            var result = cartItem.GetTotal();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSubTotal_WithoutProduct_ShouldReturnZero()
        {
            CartItem cartItem = new CartItem();
            product = null;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSubTotal_WithZeroProductPrice_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 0.0f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSubTotal_WithLowFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 10.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 10.50f*5;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSubTotal_WithHighFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 1005.50f*5;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSubTotal_WithZeroQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;
            cartItem.Qty = 0;

            var expected = 0;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSubTotal_WithNoQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;

            var expected = 0;

            var result = cartItem.GetSubTotal();

            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void GetDiscount_WithoutProduct_ShouldReturnZero()
        {
            CartItem cartItem = new CartItem();
            product = null;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetDiscount_WithZeroProductPrice_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 0.0f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = 0;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetDiscount_WithLowFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 10.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = product.DiscountPrecentage * 5 * product.Price / 100;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetDiscount_WithHighFloatProductPrice_ReturnsValid()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;
            cartItem.Qty = 5;

            var expected = product.DiscountPrecentage * 5 * product.Price / 100;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetDiscount_WithZeroQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            cartItem.Product = product;
            cartItem.Qty = 0;

            var expected = product.DiscountPrecentage * 0 * product.Price / 100;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetDiscount_WithNoQty_ReturnsZero()
        {
            CartItem cartItem = new CartItem();
            product.Price = 1005.50f;
            cartItem.Product = product;

            var expected = product.DiscountPrecentage * 0 * product.Price / 100;

            var result = cartItem.GetDiscount();

            Assert.AreEqual(expected, result);
        }
    }
}
