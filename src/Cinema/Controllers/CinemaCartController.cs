using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class CinemaCartController : Controller
    {
        private readonly IAllMovies _movieRep;
        private readonly CinemaCart _cinemaCart;

        public CinemaCartController(IAllMovies movieRep, CinemaCart cinemaCart)
        {
            _movieRep = movieRep;
            _cinemaCart = cinemaCart;
        }

        public ViewResult Index()
        {
            var items = _cinemaCart.getCinemaItems();
            _cinemaCart.listCinemaItems = items;

            var obj = new CinemaCartViewModel
            {
                cinemaCart = _cinemaCart
            };

            ViewBag.Title = "АнтиКинотеатр";
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _movieRep.Movies.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _cinemaCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult removeFromCart(int id)
        {
            _cinemaCart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
