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
    public class MockContactRepository : IContactRepository
    {
        public IEnumerable<Contact> Contacts
        {
            get
            {
                return new List<Contact>
                {
                    new Contact { Id = 1, Name = "John Nash" },
                    new Contact { Id = 2, Name = "Rocky Balboa" }
                };
            }
        }

        public int InsertContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int DeleteContact(int id)
        {
            throw new NotImplementedException();
        }
    }
}
