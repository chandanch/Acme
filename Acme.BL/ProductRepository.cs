using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BL;

namespace Acme.BLTest
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve a single product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Spock Box";
                product.ProductDescription = "Spock Box tool set 3 packs";
                product.CurrentPrice = 34;
            }

            Object myobj = new Object();
            Console.WriteLine($"Object: {myobj.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;

        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}
