using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SklepInternetowy.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
 
        private readonly AppDBContext _context;

        public HomeController(AppDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
