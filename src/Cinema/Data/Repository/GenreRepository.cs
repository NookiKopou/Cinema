using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Repository
{
    public class GenreRepository : IMoviesGenre
    {
        private readonly ApplicationDbContext appDBContent;

        public GenreRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Genre> AllGenres => appDBContent.Genre;
    }
}
