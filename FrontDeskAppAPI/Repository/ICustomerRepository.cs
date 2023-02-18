using FrontDeskAppAPI.Model;

namespace FrontDeskAppAPI.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void DeleteCustomer(int id);
        Customer Update(Customer customer);
    }
}
