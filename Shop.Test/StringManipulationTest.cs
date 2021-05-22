using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using System;

namespace Shop.Test
{
    [TestClass]
    public class StringManipulationTest
    {
        [TestMethod]
        public void FullName_NullFIrstName_ReturnsLastName()
        {
            User user = new User()
            {
                LastName = " Ismathulla "
            };
            string expected = "Ismathulla";

            string result = user.FullName;

            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void FullName_NullLastName_ReturnsFirstName()
        {
            User user = new User()
            {
                FirstName = " Ismathulla "
            };
            string expected = "Ismathulla";

            string result = user.FullName;

            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void FullName_FirstNameAndLastName_WithSimpleLetters_Returns_FormatedFullName()
        {
            User user = new User()
            {
                FirstName = " razzaq ",
                LastName = " ismathulla "
            };
            string expected = "Razzaq Ismathulla";

            string result = user.FullName;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void FullName_FirstNameAndLastName_WithEmpty_ReturnsEmpty()
        {
            User user = new User()
            {
                FirstName = "  ",
                LastName = "  "
            };
            string expected = "";

            string result = user.FullName;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetPrice_with_PriceFiled_0()
        {
            Product product = new Product();
            string expected = Currencies.LKR.ToString() + " " + 0;
            string result = product.GetPrice;

            Assert.AreEqual(expected,result);
        }
    }
}
