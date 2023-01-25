using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class PSUController : Controller
    {
        private readonly IPSUService _service;

        public PSUController(IPSUService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllPSUs = _service.GetAll();
            return View(AllPSUs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PSU psu)
        {
            if (!ModelState.IsValid)
            {
                return View(psu);
            }
            _service.Add(psu);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var psuDetails = _service.GetByID(id);
            if (psuDetails == null) return View("Empty");
            return View(psuDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var psuDetails = _service.GetByID(id);
            if (psuDetails == null) return View("Empty");
            return View(psuDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, PSU psu)
        {
            if (!ModelState.IsValid)
            {
                return View(psu);
            }
            _service.Update(id, psu);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var psuDetails = _service.GetByID(id);
            if (psuDetails == null) return View("Empty");
            return View(psuDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var psuDetails = _service.GetByID(id);
            if (psuDetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
