using FrontDeskApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomer()
        {
            return new List<Customer>();
        }
    }
}
