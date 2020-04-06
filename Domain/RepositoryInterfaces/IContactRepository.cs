using ContactManager.Domain.Entities;
using System.Collections.Generic;

namespace ContactManager.Domain.RepositoryInterfaces
{
    public interface IContactRepository<T> where T : Contact
    {
        IEnumerable<Contact> Contacts { get; }
        void InsertContact(T contact);
        void UpdateContact(T contact);
        void DeleteContact(int id);
    }
}
