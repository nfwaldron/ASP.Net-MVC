using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.Sevices
{
    public class ShoppingListService
    {
        IGenericRepository _repo;

        public ShoppingListService(IGenericRepository repo)
        {
            _repo = repo;
        }




    }
}