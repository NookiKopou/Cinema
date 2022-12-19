using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class CinemaCartItem
    {
        public int Id { get; set; }

        public Movie movie { get; set; }

        public int price { get; set; }

        public string CinemaCartId { get; set; }
    }
}
