using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class MotherboardController : Controller
    {
        private readonly IMotherboardService _service;

        public MotherboardController(IMotherboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllMotherboards = _service.GetAll();
            return View(AllMotherboards);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Motherboard motherboard)
        {
            if (!ModelState.IsValid)
            {
                return View(motherboard);
            }
            _service.Add(motherboard);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var motherboardDetails = _service.GetByID(id);
            if (motherboardDetails == null) return View("Empty");
            return View(motherboardDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var motherboardDetails = _service.GetByID(id);
            if (motherboardDetails == null) return View("Empty");
            return View(motherboardDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, Motherboard motherboard)
        {
            if (!ModelState.IsValid)
            {
                return View(motherboard);
            }
            _service.Update(id, motherboard);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var motherboardDetails = _service.GetByID(id);
            if (motherboardDetails == null) return View("Empty");
            return View(motherboardDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var motherboarddetails = _service.GetByID(id);
            if (motherboarddetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
