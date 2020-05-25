using System.Collections.Generic;
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

        [TestMethod]
        public void RetrieveCustomerDetailsWithAddress()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "John.Doe@acme.com",
                FirstName = "John",
                LastName = "Doe",
                AddressList = new List<Address>()
                {
                   new Address()
                   {
                        AddressType = 1,
                        City = "Saheer",
                        Country = "Somers",
                        PostalCode = "1232",
                        State = "Saphire",
                        StreetLine1 = "wiki 4, new avenue",
                        StreetLine2 = "dom 4 chlester"
                   },
                   new Address()
                   {
                      AddressType = 2,
                      City = "Saheer",
                      Country = "Somers",
                      PostalCode = "1232",
                      State = "Saphire",
                      StreetLine1 = "wiki 10, post venue",
                      StreetLine2 = "dom 6 hiors"
                   }
                }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            }
        }
    }
}
