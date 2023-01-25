using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class StorageController : Controller
    {
        private readonly IStorageService _service;

        public StorageController(IStorageService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllStorages = _service.GetAll();
            return View(AllStorages);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Storage storage)
        {
            if (!ModelState.IsValid)
            {
                return View(storage);
            }
            _service.Add(storage);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var storageDetails = _service.GetByID(id);
            if (storageDetails == null) return View("Empty");
            return View(storageDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var storageDetails = _service.GetByID(id);
            if (storageDetails == null) return View("Empty");
            return View(storageDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, Storage storage)
        {
            if (!ModelState.IsValid)
            {
                return View(storage);
            }
            _service.Update(id, storage);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var storageDetails = _service.GetByID(id);
            if (storageDetails == null) return View("Empty");
            return View(storageDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var storageDetails = _service.GetByID(id);
            if (storageDetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
