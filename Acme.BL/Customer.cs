﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BL
{
    public class Customer : EntityBase
    {
        // constructor chaining - a constructor calling another constructor
        public Customer(): this(0) 
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }

        public List<Address> AddressList { get; set; }

        // Auto-Implemented property - In the backing field is automatically created
        public string FirstName { get; set; }
        // backing field
        private string _lastName;
        // full property syntax
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName 
        { 
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates customer data
        /// </summary>
        /// <returns>
        /// True or false
        /// </returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public override string ToString() => FullName;
    }
}
