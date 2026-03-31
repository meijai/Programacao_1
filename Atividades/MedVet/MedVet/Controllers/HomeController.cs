using MedVet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SaleOrder;

namespace MedVet.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            SaleOrder.Customer c1 = new SaleOrder.Customer();

            c1.Id = 1;
            c1.Name = "Frodo";
            c1.BirthDate = new DateTime(1996, 1, 19);

            Console.WriteLine(c1.ToString());

            Console.WriteLine(SaleOrder.Customer.InstanceCount);

            SaleOrder.Customer c2 = new SaleOrder.Customer()
            {
                Id = 2,
                Name = "Aragorn",
                BirthDate = new DateTime(1624, 1, 2)
            };

            Console.WriteLine(c2.ToString());

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
