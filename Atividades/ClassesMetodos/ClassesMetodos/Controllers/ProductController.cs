using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;


namespace ClassesMetodos.Controllers
{
    public class ProductController : Controller
    {

        private ProductRepository _productRepository;

        public ProductController()
        { 
            _productRepository = new ProductRepository();
        }

        public IActionResult Index()
        {
            Object objeto = new Object();
            var product = _productRepository.GetById(1);
            var products = _productRepository.GetByName("Maconha");

            products.Add(product);
            //products.Add((Product)objeto);

            return View(products);
        }
    }
}
