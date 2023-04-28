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

        public OrdersRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var orderDetail = new OrderDetail()
            {
                hours = order.hours,
                orderID = order.id,
                people = order.people
            };
            appDBContent.OrderDetail.Add(orderDetail);
            appDBContent.SaveChanges();
        }
    }
}
