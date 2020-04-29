using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return true;
        }

        /// <summary>
        /// Retrieves one order by order Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Saves the Order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
