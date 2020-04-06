using ContactManager.Dtos;
using System.Collections.Generic;

namespace ContactManager.Services
{
    public interface IContactService
    {
        bool AddContact(ContactDto contactDto);
        IEnumerable<ContactDto> GetContacts();
        bool UpdateContact(ContactDto contactDto);
        bool DeleteContact(int id);
    }
}