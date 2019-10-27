using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        private AppDbContext _appDbContext;

        public SqlCustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Customer Delete(int id)
        {
            Customer customer = _appDbContext.Customers.Find(id);

            if (customer != null)
            {
                _appDbContext.Remove(customer);
                _appDbContext.SaveChanges();
            }

            return customer;
        }

        public Customer GetCustomer(int id)
        {
            return _appDbContext.Customers.Find(id);
        }

        public IEnumerable<Customer> GetCustomerAll()
        {
            return _appDbContext.Customers;
        }

        public Customer Save(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            //Customer customerChange = _appDbContext.Customers.Find(customer.Id);

            //if (customerChange != null)
            //{
            //    customerChange.Name = customer.Name;
            //    customerChange.Gender = customer.Gender;
            //    customerChange.Day1 = customer.Day1;
            //    customerChange.Day2 = customer.Day2;
            //    customerChange.Day3 = customer.Day3;
            //    customerChange.Email = customer.Email;
            //    customerChange.DateRegistered = customer.DateRegistered;
            //    customerChange.AdditionalRequest = customer.AdditionalRequest;

            //    _appDbContext.SaveChanges();
            //}

            var customerChange = _appDbContext.Customers.Attach(customer);
            customerChange.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();

            return customer;
        }
    }
}
