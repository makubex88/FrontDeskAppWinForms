using FrontDeskAppAPI.Context;
using FrontDeskAppAPI.Model;

namespace FrontDeskAppAPI.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {
            
        }
        public List<Customer> GetAll()
        {
            return new APIDbContext().Customers.ToList();
        }

        public Customer Get(int id)
        {
            return new Customer();
        }

        public void DeleteCustomer(int id)
        {

        }

        public Customer Update(Customer customer)
        {
            return new Customer();
        }
    }
}
