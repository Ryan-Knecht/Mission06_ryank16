using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovies()
        {
            return View("NewMovies");
        }

        [HttpPost]
        public IActionResult NewMovies(Movie m)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(m);
                blahContext.SaveChanges();
                return View("Confirmation", m);
            }
            else
            {
                return View(m);
            }
        }
        public IActionResult Privacy()
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
