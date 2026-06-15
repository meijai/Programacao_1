using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Imobiliaria.Controllers
{
    public class HouseController : Controller
    {
        private HouseRepository _houseRepository;
        public HouseController()
        {
            _houseRepository = new HouseRepository();
        }

        [HttpGet]
        public IActionResult Index(string search)
        {
            var houses = string.IsNullOrEmpty(search)
                ? _houseRepository.GetAll()
                : _houseRepository.GetByName(search);
            return View(houses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            LoadViewData();
            return View(new House());
        }
        [HttpPost]
        public IActionResult Create(House house)
        {
            if (house is null) return View(house);
            foreach (var h in house.Houses) _houseRepository.Create(h);
            _houseRepository.Create(house);
            LoadViewData();
            return RedirectToAction(nameof(Index));
        }
        private void LoadViewData()
        { 
            var houses = _houseRepository.GetAll();
            ViewData["HouseId"] = new SelectList(houses, "Id", "Title");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var house = _houseRepository.GetById(id);
            if (house is null)
                return NotFound();

            return View(house);
        }
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var house = _houseRepository.GetById(id);
            if (house is null)
                return NotFound();

            _houseRepository.Delete(house);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id <= 0)
                return BadRequest();

            var house = _houseRepository.GetById(id);

            if (house is null)
                return NotFound();

            if (id != house.Id)
                return BadRequest();
            return View(house);
        }

        [HttpPost]
        public IActionResult Update(int id, House house)
        {
            if (id <= 0)
                return BadRequest();

            if (house is null)
                return NotFound();

            _houseRepository.Update(house);
            return RedirectToAction(nameof(Index));
        }
    }
}
