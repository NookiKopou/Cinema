using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Models
{
    public class Genre
    {
        public int id { set; get; }

        public string genreName { set; get; }

        public List<Movie> movies { set; get; }
    }
}
