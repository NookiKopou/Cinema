using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Interfaces
{
    public interface IAllMovies
    {
        IEnumerable<Movie> Movies { get; }
        IEnumerable<Movie> getPopMovies { get; }
        Movie getObjectMovie(int movieId);
    }
}
