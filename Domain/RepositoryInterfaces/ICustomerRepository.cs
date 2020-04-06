using ContactManager.Domain.Entities;
using System.Collections.Generic;

namespace ContactManager.Domain.RepositoryInterfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers { get; }
        int InsertCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int id);
    }
}
