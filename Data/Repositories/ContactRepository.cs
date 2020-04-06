using ContactManager.Domain.Entities;
using ContactManager.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace ContactManager.Data.Repositories
{
    /// <summary>
    /// I'm trying to figure out a way to use this contact repository, and then verify if it's a supplier or a customer based on some property, so I could return a flag
    /// This flag can be used when I add a new registry, like acheck to expose if it's a supplier or customer
    /// </summary>
    public class MockContactRepository<T> : IContactRepository<T> where T : Contact
    {
        private List<Contact> db = new List<Contact>
                {
                    new Customer { Id = 1, Name = "John", Birthday = DateTime.Now, Email = "mail@mail.com" },
                    new Supplier { Id = 2, Name = "SupplierTest", PhoneNumber = "123123" }
                };

        public IEnumerable<Contact> Contacts
        {
            get
            {
                return db;
            }
        }

        public void InsertContact(T contact)
        {
            db.Add(contact);
        }

        public void UpdateContact(T contact)
        {
            db.RemoveAll(x => x.Id == contact.Id);
            db.Add(contact);
        }

        public void DeleteContact(int id)
        {
            db.RemoveAll(x => x.Id == id);
        }
    }
}
