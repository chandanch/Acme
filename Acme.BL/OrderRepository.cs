using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves Order by Order ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order(1);
            
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 23, 12, 23, 45,
                                                       new TimeSpan(7, 0, 0));
            }
            return order;
           
        }

        /// <summary>
        /// Saves order data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
