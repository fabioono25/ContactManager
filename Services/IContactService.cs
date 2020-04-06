using ContactManager.Dtos;
using System.Collections.Generic;

namespace ContactManager.Services
{
    public interface IContactService
    {
        void AddContact(ContactDto contactDto);
        IEnumerable<ContactDto> GetContacts();
        void UpdateContact(ContactDto contactDto);
        void DeleteContact(int id);
    }
}