using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie> allMovies{ get; set; }

        public string currGenre { get; set; }
    }
}
