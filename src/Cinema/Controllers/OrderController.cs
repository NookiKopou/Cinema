using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly CinemaCart cinemaCart;

        public OrderController(IAllOrders allOrders, CinemaCart cinemaCart)
        {
            this.allOrders = allOrders;
            this.cinemaCart = cinemaCart;
        }

        public IActionResult Checkout()
        {
            ViewBag.Title = "АнтиКинотеатр";
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cinemaCart.listCinemaItems = cinemaCart.getCinemaItems();

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");

            }

            ViewBag.Title = "АнтиКинотеатр";
            return View(order);
        }

        public IActionResult Complete()
        {           
            ViewBag.Title = "АнтиКинотеатр";
            return View();
        }
    }
}
