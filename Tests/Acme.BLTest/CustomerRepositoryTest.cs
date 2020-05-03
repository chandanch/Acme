using System;
using Acme.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "John.Doe@acme.com",
                FirstName = "John",
                LastName = "Doe"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual("Doe, John", actual.FullName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
        }
    }
}
