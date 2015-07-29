using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string ItemName { get; set; }
        public Customer Customer { get; set; }
    }

}