using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class RandomContactGenerator
    {
       public static Contact[] ContactGenerator()
       {
        
           var contactArray = new Contact[100];
           
           for (int i = 0; i < 100; i++)
			{
                contactArray[i] = new Contact { FirstName = "John" + i.ToString(), LastName = "Doe" + i.ToString(), Phone = "425-245-3000" };
			}
      
          return contactArray; 
        }

    }
}