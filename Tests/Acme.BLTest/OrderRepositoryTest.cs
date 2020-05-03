using System;
using Acme.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 23, 12, 23, 45,
                                                       new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
