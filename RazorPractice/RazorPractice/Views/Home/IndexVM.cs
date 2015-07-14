using RazorPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorPractice.Views.Home
{
    public class IndexVM
    {
        // When creating view models, just take the name of the view, and stick VM on the end.
        // Always create view models in the Views section of your project
            public IList<Product> Products { get; set; }
        
    }
}