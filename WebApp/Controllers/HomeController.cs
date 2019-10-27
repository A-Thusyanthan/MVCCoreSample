using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ViewResult Index()
        {
            IEnumerable<Customer> model = _customerRepository.GetCustomerAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            Customer model = _customerRepository.GetCustomer(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer = _customerRepository.Save(customer);

                return RedirectToAction("details", new { id = customer.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
