using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageContacts.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
    }
}