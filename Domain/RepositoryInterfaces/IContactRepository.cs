using ContactManager.Domain.Entities;
using System.Collections.Generic;

namespace ContactManager.Domain.RepositoryInterfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> Contacts { get; }
        int InsertContact(Contact contact);
        int UpdateContact(Contact contact);
        int DeleteContact(int id);
    }
}
