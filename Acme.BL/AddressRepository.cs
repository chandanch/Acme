using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieves a single customer address
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.City = "Saheer";
                address.Country = "Somers";
                address.PostalCode = "1232";
                address.State = "Saphire";
                address.StreetLine1 = "wiki 4, new avenue";
                address.StreetLine2 = "dom 4 chlester";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            // first address
            Address address = new Address(1);
            address.AddressType = 1;
            address.City = "Saheer";
            address.Country = "Somers";
            address.PostalCode = "1232";
            address.State = "Saphire";
            address.StreetLine1 = "wiki 4, new avenue";
            address.StreetLine2 = "dom 4 chlester";
            addressList.Add(address);

            // second address
            address = new Address(2)
            {
                AddressType = 2,
                City = "Saheer",
                Country = "Somers",
                PostalCode = "1232",
                State = "Saphire",
                StreetLine1 = "wiki 10, post venue",
                StreetLine2 = "dom 6 hiors"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Save current address
        /// </summary>
        /// <param name="address" type="Address"></param>
        /// <returns name="state"></returns>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
