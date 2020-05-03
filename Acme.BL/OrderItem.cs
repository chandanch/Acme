using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {

        }
        
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates Order Item data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) return false;
            if (ProductId <= 0) return false;
            if (PurchasePrice == null) return false;

            return isValid;
        }

        /// <summary>
        /// Retrieves one order Item
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderItemId)
        {
            return new Order();
        }

        /// <summary>
        /// Saves current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

    }
}
