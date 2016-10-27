using RepositoryDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDemo.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private Northwind context;

        public CustomerRepository(Northwind context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
