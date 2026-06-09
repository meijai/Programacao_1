using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;
using System.Globalization;

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
            var houses = string.IsNullOrEmpty(search) ? _houseRepository.GetAll() : _houseRepository.GetByFederalState(search);
            return View(houses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadViewData();
            return View(new House());
        }

        private void LoadViewData()
        { 
            var houses = _houseRepository.GetAll();
            ViewData["HouseId"] = new SelectList(houses, "Id", "Title");
        }
    }
}
