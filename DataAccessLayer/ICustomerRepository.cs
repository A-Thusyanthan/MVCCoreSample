using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
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
