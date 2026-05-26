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

        public IActionResult Index(string search)
        {
            List<Product> products = [];

            if (!string.IsNullOrEmpty(search))
            {
                products = _productRepository.GetByName(search);
            }
            else
            { 
                products = _productRepository.GetAll();
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product is null) return View(product);

            foreach (var a in product.Products) _productRepository.Create(a);

            _productRepository.Create(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);
            if (product is null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        { 
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);
            if (product is null)
                return NotFound();

            _productRepository.Delete(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
            if (id <= 0)
                return BadRequest();

            var product = _productRepository.GetById(id);

            if (product is null)
                return NotFound();

            if (id != product.Id)
                return BadRequest();

            return View(product);
        }

        [HttpPost]
        public IActionResult Update(int id, Product product)
        { 
            if (id <= 0)
                return BadRequest();

            if (product is null)
                return NotFound();

            _productRepository.Update(product);

            return RedirectToAction(nameof(Index));
        }
    }
}
