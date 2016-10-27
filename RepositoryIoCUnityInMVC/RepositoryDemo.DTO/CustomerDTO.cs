using RepositoryDemo.Model;
using RepositoryDemo.Data;

namespace RepositoryDemo.DTO
{
    public class CustomerDTO
    {
        // convert into data source format
        public Customer ToData(CustomerModel customer)
        {
            return new Customer
            {
                CustomerID = customer.Id,
                ContactName = customer.Name,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                PostalCode = customer.Pin,
                Country = customer.Country,
                Phone = customer.Phone
            };
        }

        // convert into view mode or model format
        public CustomerModel ToData(Customer customer)
        {
            return new CustomerModel
            {
                Id = customer.CustomerID,
                Name = customer.ContactName,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                Pin = customer.PostalCode,
                Country = customer.Country,
                Phone = customer.Phone
            };
        }
    }
}
