using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using SklepInternetowy.Services;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class CPUController : Controller
    {
        private readonly ICPUService _service;

        public CPUController(ICPUService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var AllCPUs = _service.GetAll();
            return View(AllCPUs);
        }
        [HttpGet]
        public IActionResult Add()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Add(CPU cpu)
        {
            if(!ModelState.IsValid)
            {
                return View(cpu);
            }
            _service.Add(cpu);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var cpuDetails = _service.GetByID(id);
            if (cpuDetails == null) return View("Empty");
            return View(cpuDetails);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cpuDetails = _service.GetByID(id);
            if (cpuDetails == null) return View("Empty");
            return View(cpuDetails);
        }
        [HttpPost]
        public IActionResult Edit(int id, CPU cpu)
        {
            if (!ModelState.IsValid)
            {
                return View(cpu);
            }
            _service.Update(id, cpu);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cpuDetails = _service.GetByID(id);
            if (cpuDetails == null) return View("Empty");
            return View(cpuDetails);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var cpudetails = _service.GetByID(id);
            if (cpudetails == null) return View("Empty");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
