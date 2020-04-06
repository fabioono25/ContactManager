using ContactManager.Domain.Entities;
using ContactManager.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace ContactManager.Data.Repositories
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> Customers => throw new NotImplementedException();

        public int DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
