using System;
using Acme.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer testCustomer = new Customer
            {
                FirstName = "John",
                LastName = "Doe"
            };
            string expected = "Doe, John";

            //-- Act
            string actual = testCustomer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer testCustomer = new Customer
            {
                LastName = "Doe"
            };
            string expected = "Doe";

            //-- Act
            string actual = testCustomer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer testCustomer = new Customer
            {
                FirstName = "John"
            };
            string expected = "John";

            //-- Act
            string actual = testCustomer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var joe = new Customer();
            joe.FirstName = "Joe";
            Customer.InstanceCount += 1;

            var mike = new Customer();
            joe.FirstName = "Mike";
            Customer.InstanceCount += 1;

            var jane = new Customer();
            joe.FirstName = "Jane";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateMethodNullLastName()
        {
            //-- Arrange
            var joe = new Customer();
            joe.EmailAddress = "joe@ee.com";

            //-- Act
            var actual = joe.Validate();

            //-- Assert
            Assert.AreEqual(actual, false);

        }

        [TestMethod]
        public void ValidateMethodNullEmailAddress()
        {
            //-- Arrange
            var sam = new Customer();
            sam.LastName = "Deer";

            //-- Act
            var actual = sam.Validate();

            //-- Assert
            Assert.AreEqual(actual, false);
        }

        [TestMethod]
        public void ValidateMethodValidLastNameEmailAddress()
        {
            //-- Arrange
            var sam = new Customer();
            sam.LastName = "Deer";
            sam.EmailAddress = "sam.deer@ef.com";
            var expected = true;

            //-- Act
            var actual = sam.Validate();

            //-- Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
