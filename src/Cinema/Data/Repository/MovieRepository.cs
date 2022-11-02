using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Repository
{
    public class MovieRepository : IAllMovies
    {
        private readonly ApplicationDbContext appDBContent;

        public MovieRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Movie> Movies => appDBContent.Movie.Include(c => c.Genre);

        public IEnumerable<Movie> getPopMovies => appDBContent.Movie.Where(p => p.isPopular).Include(c => c.Genre);

        public Movie getObjectMovie(int movieId) => appDBContent.Movie.FirstOrDefault(p => p.id == movieId);
    }
}
