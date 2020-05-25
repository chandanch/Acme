using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retrieves Customer by customer ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "John";
                customer.LastName = "Doe";
                customer.EmailAddress = "John.Doe@acme.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves customer data
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }
    }


}
