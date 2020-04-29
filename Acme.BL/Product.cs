using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;

        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Validate product Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Save product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
