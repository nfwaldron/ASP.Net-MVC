using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class ItemDataContext:DbContext
    {
        public ItemDataContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Item> Item { get; set; }
        public IDbSet<Bid> Bid { get; set; }
    }
}