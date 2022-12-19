using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> popMovies { get; set; }
    }
}
