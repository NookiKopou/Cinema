using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ApplicationDbContext appDBContent;
        private readonly CinemaCart cinemaCart;

        public OrdersRepository(ApplicationDbContext appDBContent, CinemaCart cinemaCart)
        {
            this.appDBContent = appDBContent;
            this.cinemaCart = cinemaCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = cinemaCart.listCinemaItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    MovieID = el.movie.id,
                    orderID = order.id,
                    price = el.movie.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
