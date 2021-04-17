using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Core.Models;
using System;

namespace Shop.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void GetPrice_Valid()
        {
            Product product = new Product();
            product.Price = 1500.05f;

            var expected = "LKR." + product.Price;
            var result = product.GetPrice;

            Assert.AreEqual(expected,result);
        }
    }
}
