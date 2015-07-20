using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Strongly_Typed_Views.Models
{
    public class DataContext : DbContext
    {
        // Notice that the DataContext class inherits from the DbContext class. 
        // You should think of the DataContext class as acting like a list of the model 
        // classes that the Entity Framework should track. The DataContext class in the 
        // code above will track any changes made to movies.
        public IDbSet<Product> Product { get; set; }
        
        public DataContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
    }
}
