namespace ContactManager.Migrations
{
    using ContactManager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.DataContext context)
        {
            var contacts = RandomContactGenerator.ContactGenerator();

            context.Contacts.AddOrUpdate(m => m.FirstName, contacts);
        }
        
    }
}
