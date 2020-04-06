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

        /// <summary>
        /// We can divide into two different methods, getCustomers() and getSuppliers()
        /// Using Entity Framework, we can potentially use the union clause to joint the two results into one aggregation.
        /// Using this strategy, we could have two different repositories (for customer and supplier)
        /// </summary>
        /// <returns></returns>
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
