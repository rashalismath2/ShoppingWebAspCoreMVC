using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Core.Models;
using System;

namespace Shop.Test
{
    [TestClass]
    public class UserTest
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
            string expected = "razzaq ismathulla";

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
    }
}
