using System;
using Acme.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Spock Box",
                ProductDescription = "Spock Box tool set 3 packs",
                CurrentPrice = 34
            };

            //-- Act
            var actual = productRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
