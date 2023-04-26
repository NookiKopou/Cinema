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
        private int sum = 0;

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
                return RedirectToAction("Payment");

            }

            ViewBag.Title = "АнтиКинотеатр";
            return View(order);
        }

        public IActionResult Payment()
        {
            ViewBag.Title = "АнтиКинотеатр";
            return View();
        }

        [HttpPost("Summ")]
        public async Task<JsonResult> Summ(string people, string hours)
        {
            try
            {
                var peopleJS = Convert.ToInt32(people);
                var hoursJS = Convert.ToInt32(hours);
                return Json(people, hours);
            }
            catch
            {
                return null;
            }
        }
    }
}
