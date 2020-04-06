using ContactManager.Domain.Entities;
using ContactManager.Domain.RepositoryInterfaces;
using ContactManager.Dtos;
using ContactManager.Services.Extensions;
using System;
using System.Collections.Generic;

namespace ContactManager.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository<Contact> _contactRepository;

        public ContactService(IContactRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        /// <summary>
        /// I used simple mappers to map the registers here
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns> 
        public void AddContact(ContactDto contactDto) //divide Dtos
        {
            Contact contact;

            if (contactDto.IsCustomer)
            {
                contact = contactDto.ToCustomerEntity();
            }else
            {
                contact = contactDto.ToSupplierEntity();
            }
            
            //_customerRepository.InsertContact(customer);
            _contactRepository.InsertContact(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public IEnumerable<ContactDto> GetContacts()
        {
            var contacts = _contactRepository.Contacts;

            return contacts.ToDto();
        }

        public void UpdateContact(ContactDto contactDto)
        {
            throw new NotImplementedException();
        }
    }
}
