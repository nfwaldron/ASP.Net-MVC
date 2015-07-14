using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplexObjectMVC.Models
{
    public class Customer
    {
        // Class Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }

        // Class Methods

        public Customer()
        {
            // In order for the class Customer to have access to the address object,
            // the constructor must create a new instance of the 'Address' class every
            // time an object of the customer class is created.
            this.BillingAddress = new Address();
            this.ShippingAddress = new Address();
        }


    }
}