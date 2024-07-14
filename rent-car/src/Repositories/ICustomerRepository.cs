using Entities;

namespace Repositories
{
    public interface ICustomerRepository
    {
        void AddCustomer(CustomerEntity customer);
        void UpdateCustomer(CustomerEntity customer);
        void DeleteCustomer(int customerId);
        CustomerEntity GetCustomerById(int customerId);
        IEnumerable<CustomerEntity> GetAllCustomers();
    }
}