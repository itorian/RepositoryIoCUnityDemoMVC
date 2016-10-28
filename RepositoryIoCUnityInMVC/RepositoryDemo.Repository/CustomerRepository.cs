using RepositoryDemo.Data;
using RepositoryDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDemo.Repository
{
    public class CustomerRepository : IRepository<CustomerModel>
    {
        private Northwind context;

        public CustomerRepository(Northwind context)
        {
            this.context = context;
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            // dto
            throw new NotImplementedException();
        }

        public CustomerModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Add(CustomerModel item)
        {
            throw new NotImplementedException();
        }

        public bool Update(CustomerModel item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
