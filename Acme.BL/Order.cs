using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }


        /// <summary>
        /// Validates order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return true;
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
    }
}
