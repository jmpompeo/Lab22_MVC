using Lab22.Models;
using Lab22.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string movieGenre, string search)
        {
            IEnumerable<string> genreList = from m in _repository.Get()
                                           orderby m.Genre
                                           select m.Genre;

            var movies = from m in _repository.Get()
                         select m;

            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(s => s.Title.Contains(search));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var genreModel = new MovieGenreModel
            {
                Genres = new SelectList(genreList.Distinct().ToList()),
                Movies = movies.ToList()
            };

            return View(genreModel);
        }

        public IActionResult SearchTitle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchTitle(MovieModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model.Genre);
            }

            _repository.Save(model);
            return RedirectToAction("Index");
        }

        public IActionResult SearchGenre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchGenre(MovieModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model.Title);
            }

            _repository.Save(model);
            return RedirectToAction("Index");
        }

    }
}
