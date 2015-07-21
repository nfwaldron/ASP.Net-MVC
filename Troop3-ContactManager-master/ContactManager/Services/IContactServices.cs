using System;
namespace ContactManager.Services
{
    public interface IContactServices
    {
        ContactManager.Models.Contact Find(int id);
        System.Collections.Generic.IList<ContactManager.Models.Contact> List();
        ContactManager.Views.Contacts.ContactVM Pages(int pageIndex);
    }
}
