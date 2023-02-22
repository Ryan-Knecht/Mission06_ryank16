using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext daContext { get; set; }

        //Constructor
        public HomeController(MovieContext someName)
        { 
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        // This is to call the Podcast
        public IActionResult MyPodcast()
        {
            return View();
        }


        //This is the get for NewMovies
        [HttpGet]
        public IActionResult NewMovies()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        //This is the post for NewMovies
        [HttpPost]
        public IActionResult NewMovies(Movie m)
        {
            //if valid
            if (ModelState.IsValid)
            {
                daContext.Add(m);
                daContext.SaveChanges();
                return View("Confirmation", m);
            }
            //if invalid
            else
            {
                return View(m);
            }
        }

        public IActionResult MovieList ()
        {
            var movies1 = daContext.movies
                .Include(x => x.Category)
                .ToList();

            return View(movies1);
        }


        /*Create the Edit functions for get/post */
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.movies.Single(x => x.MovieID == movieid);

            return View("NewMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            daContext.Update(m);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }


        /*Create the delete functions*/
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = daContext.movies.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie m)
        {
            daContext.movies.Remove(m);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
