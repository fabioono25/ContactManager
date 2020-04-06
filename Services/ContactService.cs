using ContactManager.Domain.RepositoryInterfaces;
using ContactManager.Dtos;
using ContactManager.Services.Extensions;
using System;
using System.Collections.Generic;

namespace ContactManager.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;
        private ICustomerRepository _customerRepository;
        private ISupplierRepository _supplierRepository;

        public ContactService(IContactRepository contactRepository, ICustomerRepository customerRepository, ISupplierRepository supplierRepository)
        {
            _contactRepository = contactRepository;
            _customerRepository = customerRepository;
            _supplierRepository = supplierRepository;
        }

        /// <summary>
        /// I used simple mappers to map the registers here
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns> 
        public bool AddContact(ContactDto contactDto)
        {
            if (contactDto.IsCustomer)
            {
                var customer = contactDto.ToCustomerEntity();
                return _customerRepository.InsertCustomer(customer) != 0;
            }

            var supplier = contactDto.ToSupplierEntity();
            return _supplierRepository.InsertSupplier(supplier) != -1;
        }

        public bool DeleteContact(int id)
        {
            return _contactRepository.DeleteContact(id) != 0;
        }

        public IEnumerable<ContactDto> GetContacts()
        {
            var contacts = _contactRepository.Contacts;

            return contacts.ToDto();
        }

        public bool UpdateContact(ContactDto contactDto)
        {
            throw new NotImplementedException();
        }
    }
}
