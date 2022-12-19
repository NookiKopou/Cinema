using Cinema.Data.Interfaces;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllMovies _movieRep;

        public HomeController(IAllMovies movieRep)
        {
            _movieRep = movieRep;
        }

        public ViewResult Index()
        {
            var homeMovies = new HomeViewModel
            {
                popMovies = _movieRep.getPopMovies
            };
            ViewBag.Title = "notSteam";
            return View(homeMovies);
        }
    }
}
