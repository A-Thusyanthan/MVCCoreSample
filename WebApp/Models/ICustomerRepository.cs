using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomerAll();
        Customer Save(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
