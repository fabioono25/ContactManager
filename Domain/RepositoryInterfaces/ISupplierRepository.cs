using ContactManager.Domain.Entities;
using System.Collections.Generic;

namespace ContactManager.Domain.RepositoryInterfaces
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> Suppliers { get; }
        int InsertSupplier(Supplier supplier);
        int UpdateSupplier(Supplier supplier);
        int DeleteSupplier(int id);
    }
}
