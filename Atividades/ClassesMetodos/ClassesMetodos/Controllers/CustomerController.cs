using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;

namespace ClassesMetodos.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerRepository _customerRepository;

        public CustomerController()
        { 
            _customerRepository = new CustomerRepository();
        }

        public IActionResult Index()
        {

            Object objeto = new Object();
            var customer = _customerRepository.GetById(1);
            var customers = _customerRepository.GetByName("Zé");

            customers.Add(customer);
            //customers.Add((Customer)objeto);

            return View(customers);
        }
    }
}
