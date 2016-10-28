using RepositoryDemo.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryDemo.Repository
{
    public class CustomerRepository : IRepository<Customer, string>
    {
        public Northwind _context;

        public CustomerRepository(Northwind context)
        {
            _context = context;
        }

        public Customer Add(Customer item)
        {
            _context.Customers.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Customer Get(string id)
        {
            return _context.Customers.FirstOrDefault(i => i.CustomerID == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public void Remove(string id)
        {
            Customer item = _context.Customers.Find(id);
            _context.Customers.Remove(item);
            _context.SaveChanges();
        }

        public bool Update(Customer item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
