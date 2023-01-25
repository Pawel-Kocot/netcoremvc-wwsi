using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class RAMController : Controller
    {
        private readonly IRAMService _service;

        public RAMController(IRAMService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllRAMs = _service.GetAll();
            return View(AllRAMs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(RAM ram)
        {
            if (!ModelState.IsValid)
            {
                return View(ram);
            }
            _service.Add(ram);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var ramDetails = _service.GetByID(id);
            if (ramDetails == null) return View("Empty");
            return View(ramDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ramDetails = _service.GetByID(id);
            if (ramDetails == null) return View("Empty");
            return View(ramDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, RAM ram)
        {
            if (!ModelState.IsValid)
            {
                return View(ram);
            }
            _service.Update(id, ram);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var ramDetails = _service.GetByID(id);
            if (ramDetails == null) return View("Empty");
            return View(ramDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var ramDetails = _service.GetByID(id);
            if (ramDetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
