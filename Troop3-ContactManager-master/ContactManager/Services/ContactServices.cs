using CoderCamps;
using ContactManager.Models;
using ContactManager.Views.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Services
{
    public class ContactServices : ContactManager.Services.IContactServices
    {
        private IGenericRepository _repo;

        // List of all the dependencies that this class needs.
        // Passed in as an argument.
        public ContactServices(IGenericRepository repo) 
        {
            _repo = repo;
        }

        public IList<Contact> List()
        {
            return _repo.Query<Contact>().ToList();
        }

        public ContactVM Pages(int pageIndex)
        {
            const int ITEMS_PER_PAGE = 10;
            var pages = ((from c in _repo.Query<Contact>() select c).OrderBy(p => p.Id).Skip(pageIndex * ITEMS_PER_PAGE).Take(ITEMS_PER_PAGE).ToList());
            var numContacts = (from c in _repo.Query<Contact>() select c).Count();
            return new ContactVM
            {
                Contacts = pages, ContactCount = numContacts
            };

        }



        public Contact Find(int id)
        {
            return _repo.Find<Contact>(id);
        }
       

        

    }
}