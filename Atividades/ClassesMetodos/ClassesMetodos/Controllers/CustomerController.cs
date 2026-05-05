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

        [HttpGet]
        public IActionResult Index()
        {

            var customers = _customerRepository.GetAll();

            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Customer());
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (customer is null)
                return View(customer);

            _customerRepository.Create(customer);

            return RedirectToAction(nameof(Index));
        }
    }
}
