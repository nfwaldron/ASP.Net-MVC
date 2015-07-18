using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MinimumBid { get; set; }
        
        // The class item has a property Bids which is a list of bids
        // Every bid placed on an item gets added to the List
        // List of bids retains the bid information for each items
        public List<Bid> Bids { get; set; }

        public Item()
        {
            this.Bids = new List<Bid>();
        }

        // The Item method NumberOfBids returns the number of bid object in the list of bids
        public int NumberOfBids         
        {
            get { return this.Bids.Count(); }
        }
        

    }
}