using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using System.Diagnostics;
using Library;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RealEstate()
        {

            Library.Property h1 = new Library.Property();
            h1.Id = 1;
            h1.PropertyType = "House";
            h1.SellOrRent = "Sell";
            h1.SellValue = 100000;
            h1.Address = "Rua dos bobos, numero 2411";

            Library.Property h2 = new Library.Property();
            h2.Id = 2;
            h2.PropertyType = "Apartment";
            h2.SellOrRent = "Rent";
            h2.RentValue = 1500;
            h2.Address = "Avenida dos patetas, numero 2411";

            Library.Property h3 = new Library.Property();
            h3.Id = 3;
            h3.PropertyType = "House";
            h3.SellOrRent = "Rent";
            h3.RentValue = 3000;
            h3.Address = "Bairro Batata voadora, rua Jose das Alfaces numero 1233321";

            Library.Property h4 = new Library.Property();
            h4.Id = 4;
            h4.PropertyType = "Apartment";
            h4.SellOrRent = "Sell";
            h4.SellValue = 130000;
            h4.Address = "Rua dos bobos, numero 11241";

            Library.Property h5 = new Library.Property();
            h5.Id = 5;
            h5.PropertyType = "House";
            h5.SellOrRent = "Sell";
            h5.SellValue = 200000;
            h5.Address = "Rua dos bobos, numero 2411";

            //criando lista de imoveis

            List<Property> properties = new List<Property>();
            properties.Add(h1);
            properties.Add(h2);
            properties.Add(h3);
            properties.Add(h4);
            properties.Add(h5);



            return View(properties);
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
