using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
        {
            FilmManager filmManager = new FilmManager();
            public IActionResult Index()
            {
                var list = filmManager.GetFilms();
                return View(list);
            }

            [HttpGet]
            public IActionResult Add()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Add(FilmModel filmModel)
            {
                filmManager.AddFilm(filmModel);
                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Remove(int id)
            {
                var film = filmManager.GetFilm(id);
                return View(film);
            }

            [HttpPost]
            public IActionResult RemoveConfirm(int id)
            {
                filmManager.RemoveFilm(id);
                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Edit(int id)
            {
                var film = filmManager.GetFilm(id);
                return View(film);
            }

            [HttpPost]
            public IActionResult Edit(FilmModel film)
            {
                filmManager.UpdateFilm(film);
                return RedirectToAction("Index");
            }
        }
    }
