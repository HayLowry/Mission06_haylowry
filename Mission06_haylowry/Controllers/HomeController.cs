using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_haylowry.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_haylowry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _moviesContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoviesContext moviesContext)
        {
            _logger = logger;
            _moviesContext = moviesContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Movie movie)
        {
            _moviesContext.Add(movie);
            _moviesContext.SaveChanges();
            return View("MovieReceived", movie); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
