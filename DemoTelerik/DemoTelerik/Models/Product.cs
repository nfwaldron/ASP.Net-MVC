using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoTelerik.Models
{
    public class Product
    {
        public string Name { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }



    }
}