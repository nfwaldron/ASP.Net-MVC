using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Views.Contacts
{
    public class ContactVM
    {
        public List<Contact> Contacts { get; set; }
        public int ContactCount { get; set; }
    }
}