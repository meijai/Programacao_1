using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Imobiliaria.Controllers
{
    public class ApartmentController : Controller
    {
        private ApartmentRepository _apartmentRepository;

        public ApartmentController()
        { 
            _apartmentRepository = new ApartmentRepository();
        }
        public IActionResult Index(string search)
        {
            var apartments = string.IsNullOrEmpty(search)
                ? _apartmentRepository.GetAll()
                : _apartmentRepository.GetByCity(search);

            return View(apartments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadViewData();
            return View(new Apartment());
        }

        [HttpPost]
        public IActionResult Create(Apartment apartment)
        {
            if (apartment is null) return View(apartment);

            _apartmentRepository.Create(apartment);

            foreach (var a in apartment.Apartments) _apartmentRepository.Create(a);

            _apartmentRepository.Create(apartment);

            LoadViewData();
            return RedirectToAction(nameof(Index));
        }

        private void LoadViewData()
        {
            var apartments = _apartmentRepository.GetAll();
            ViewData["ApartmentId"] = new SelectList(apartments, "Id", "Title");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var apartment = _apartmentRepository.GetById(id);
            if (apartment is null)
                return NotFound();

            return View(apartment);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var apartment = _apartmentRepository.GetById(id);
            if (apartment is null)
                return NotFound();

            _apartmentRepository.Delete(apartment);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id <= 0)
                return BadRequest();

            var apartment = _apartmentRepository.GetById(id);

            if (apartment is null)
                return NotFound();

            if (id != apartment.Id)
                return BadRequest();
            LoadViewData();
            return View(apartment);
        }

        [HttpPost]
        public IActionResult Update(int id, Apartment apartment)
        {
            if (id <= 0)
                return BadRequest();

            if (apartment is null)
                return NotFound();

            _apartmentRepository.Update(apartment);
            LoadViewData();
            return RedirectToAction(nameof(Index));
        }
    }
}