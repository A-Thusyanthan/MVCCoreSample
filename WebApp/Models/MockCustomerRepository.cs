using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _CusotmerList;

        public MockCustomerRepository()
        {
            _CusotmerList = new List<Customer>()
            {
                new Customer(){Id=1,Name="Thus",Email="thus@gmail.com", Gender="M", DateRegistered=Convert.ToDateTime("01/Aug/2019"),  Day1=false,Day2=false,Day3=true, AdditionalRequest="Act" },
                new Customer(){Id=2,Name="Ram",Email="ram@gmail.com", Gender="M", DateRegistered=Convert.ToDateTime("01/Aug/2019"), Day1=true,Day2=true,Day3=false, AdditionalRequest="Act" }
            };
        }

        public Customer Delete(int id)
        {
            Customer customer = _CusotmerList.FirstOrDefault(cus => cus.Id == id);

            if (customer != null)
            {
                _CusotmerList.Remove(customer);
            }

            return customer;
        }

        public Customer GetCustomer(int id)
        {
            return _CusotmerList.FirstOrDefault(cus => cus.Id == id);
        }

        public IEnumerable<Customer> GetCustomerAll()
        {
            return _CusotmerList;
        }

        public Customer Save(Customer customer)
        {
            try
            {
                customer.Id = _CusotmerList.Max(cus => cus.Id) + 1;
                _CusotmerList.Add(customer);

                return customer;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public Customer Update(Customer customer)
        {
            Customer customerChange = _CusotmerList.FirstOrDefault(cus => cus.Id == customer.Id);

            if (customerChange != null)
            {
                customerChange.Name = customer.Name;
                customerChange.Gender = customer.Gender;
                customerChange.Day1 = customer.Day1;
                customerChange.Day2 = customer.Day2;
                customerChange.Day3 = customer.Day3;
                customerChange.Email = customer.Email;
                customerChange.DateRegistered = customer.DateRegistered;
                customerChange.AdditionalRequest = customer.AdditionalRequest;
            }

            return customer;
        }
    }
}
