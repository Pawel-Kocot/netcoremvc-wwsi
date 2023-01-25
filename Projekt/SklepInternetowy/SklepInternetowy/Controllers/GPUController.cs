using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGPUService _service;

        public GPUController(IGPUService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllGPUs = _service.GetAll();
            return View(AllGPUs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(GPU gpu)
        {
            if (!ModelState.IsValid)
            {
                return View(gpu);
            }
            _service.Add(gpu);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var gpuDetails = _service.GetByID(id);
            if (gpuDetails == null) return View("Empty");
            return View(gpuDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var gpuDetails = _service.GetByID(id);
            if (gpuDetails == null) return View("Empty");
            return View(gpuDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, GPU gpu)
        {
            if (!ModelState.IsValid)
            {
                return View(gpu);
            }
            _service.Update(id, gpu);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var gpuDetails = _service.GetByID(id);
            if (gpuDetails == null) return View("Empty");
            return View(gpuDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var gpudetails = _service.GetByID(id);
            if (gpudetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
