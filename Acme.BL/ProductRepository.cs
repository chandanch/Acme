using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves Product by Product ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(1);

            if (productId == 1)
            {
                product.CurrentPrice = 13;
                product.ProductName = "Canned Jam";
                product.ProductDescription = "Canned Jams 200g sealed can";
            }
            return product;
        }

        /// <summary>
        /// Saves product data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
