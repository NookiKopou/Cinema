using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class CinemaCart
    {
        private readonly ApplicationDbContext appDBContent;

        public CinemaCart(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string CinemaCartId { get; set; }

        public List<CinemaCartItem> listCinemaItems { get; set; }

        public static CinemaCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();
            string cinemaCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cinemaCartId);

            return new CinemaCart(context) { CinemaCartId = cinemaCartId };
        }

        public void AddToCart(Movie movie)
        {
            appDBContent.CinemaCartItem.Add(new CinemaCartItem
            {
                CinemaCartId = CinemaCartId,
                movie = movie,
                price = movie.price
            });

            appDBContent.SaveChanges();
        }

        //public void RemoveFromCart(CinemaCartItem cinemaCartItem)
        //{
        //    appDBContent.CinemaCartItem.Remove(cinemaCartItem);
        //    appDBContent.SaveChanges();
        //}

        public void RemoveFromCart(int removeProductID)
        {
            using (var _db = new ApplicationDbContext())
            {
                try
                {
                    var myItem = (from c in appDBContent.CinemaCartItem where c.movie.id == removeProductID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        appDBContent.CinemaCartItem.Remove(myItem);
                        appDBContent.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ОШИБКА: невозможно удалить товар из корзины - " + exp.Message.ToString(), exp);
                }
            }
        }

        public List<CinemaCartItem> getCinemaItems()
        {
            return appDBContent.CinemaCartItem.Where(c => c.CinemaCartId == CinemaCartId).Include(s => s.movie).ToList();
        }
    }
}
