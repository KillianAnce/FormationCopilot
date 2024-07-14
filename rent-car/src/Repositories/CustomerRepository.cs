using System;
using System.Collections.Generic;
using Entities;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(CustomerEntity customer)
        {
            // Implement the logic to add a customer to the repository
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int customerId)
        {
            // Implement the logic to delete a customer from the repository
            throw new NotImplementedException();
        }

        public CustomerEntity GetCustomerById(int customerId)
        {
            // Implement the logic to get a customer by their ID from the repository
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerEntity> GetAllCustomers()
        {
            // Implement the logic to get all customers from the repository
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerEntity customer)
        {
            // Implement the logic to update a customer in the repository
            throw new NotImplementedException();
        }
    }
}