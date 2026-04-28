using Exemplo_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_01.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            int id = 1;
            Customer cu = new Customer();
            cu.CustomerId = id;
            cu.EmailAdress = "meuemail@mail.com.br";
            cu.FirstName = "Fulano";
            cu.LastName = "de Tal";

            Customer cu1 = new Customer
            { 
                CustomerId = ++id,
                EmailAdress = "ciclano@email.com.br",
                FirstName = "Ciclano",
                LastName = "de Tal"
            };

            var cu2 = new Customer()
            {
                CustomerId = ++id,
                EmailAdress = "patricia@mail.com.br",
                FirstName = "Patricia",
                LastName = "de Tal"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(cu);
            customers.Add(cu1);
            customers.Add(cu2);

            return View(customers);
        }
    }
}
