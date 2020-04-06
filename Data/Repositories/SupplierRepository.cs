using ContactManager.Domain.Entities;
using ContactManager.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace ContactManager.Data.Repositories
{
    public class MockSupplierRepository : ISupplierRepository
    {
        public IEnumerable<Supplier> Suppliers => throw new NotImplementedException();

        public int DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public int UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
