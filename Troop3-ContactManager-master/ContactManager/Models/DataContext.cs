using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class DataContext: DbContext
    {
        public DataContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Contact> Contacts { get; set; }

    }
}