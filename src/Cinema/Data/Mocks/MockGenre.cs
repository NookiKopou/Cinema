using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Mocks
{
    public class MockGenre : IMoviesGenre
    {
        public IEnumerable<Genre> AllGenres
        {
            get
            {
                return new List<Genre>
                {
                    new Genre{genreName = "Ужасы"},
                    new Genre{genreName = "Комедия"},
                    new Genre{genreName = "Триллер"},
                    new Genre{genreName = "Фэнтези"},
                    new Genre{genreName = "Драма"}
                };
            }
        }
    }
}
