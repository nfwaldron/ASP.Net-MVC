using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageContacts.Models
{
    static public class ContactsGenerator
    {
        static public Contact[] Generate()
        {
            var contactList = new Contact[100];

            for (int i = 0; i < 100; i++)
            {
                contactList[i] = new Contact
                 {
                     FirstName = "Nathan" + i.ToString(),
                     LastName = "Waldron" + i.ToString(),
                     Birthday = "11/28/1988",
                     PhoneNumber = "617-" + i.ToString() + "-1800",
                 };
            }

            return contactList; 
        }
    }
}