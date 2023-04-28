using Cinema.Data;
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

        public OrderController(IAllOrders allOrders)
        {
            this.allOrders = allOrders;
        }

        public IActionResult Checkout()
        {
            ViewBag.Title = "АнтиКинотеатр";
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Payment");             
            }
            
            ViewBag.Title = "АнтиКинотеатр";
            return View(order);
        }

        ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Payment(Order order)
        {
            ViewBag.Title = "АнтиКинотеатр";
            return View(order);
        }
        public IActionResult Complete(Order order)
        {
            ViewBag.Title = "АнтиКинотеатр";
            return View(order);
        }
    }
}
