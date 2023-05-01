using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using Cinema.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class MoviesController: Controller
    {
        private readonly IAllMovies _allMovies;
        private readonly IMoviesGenre _allGenres;

        public MoviesController(IAllMovies iAllMovies, IMoviesGenre iMoviesGen)
        {
            _allMovies = iAllMovies;
            _allGenres = iMoviesGen;
        }

        [Route("Movies/List")]
        [Route("Movies/List/{genre}")]
        public ViewResult List(string genre)
        {
            string _genre = genre;
            IEnumerable<Movie> movies = null;
            string currGenre = "";
            if (string.IsNullOrEmpty(genre))
            {
                movies = _allMovies.Movies.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Horror", genre, StringComparison.OrdinalIgnoreCase))
                {
                    movies = _allMovies.Movies.Where(i => i.Genre.genreName.Equals("Ужасы")).OrderBy(i => i.id);
                    currGenre = "Ужасы";
                }
                if (string.Equals("Comedy", genre, StringComparison.OrdinalIgnoreCase))
                {
                    movies = _allMovies.Movies.Where(i => i.Genre.genreName.Equals("Комедия")).OrderBy(i => i.id);
                    currGenre = "Комедия";
                }
                if (string.Equals("Thriller", genre, StringComparison.OrdinalIgnoreCase))
                {
                    movies = _allMovies.Movies.Where(i => i.Genre.genreName.Equals("Триллер")).OrderBy(i => i.id);
                    currGenre = "Триллер";
                }
                if (string.Equals("Fantasy", genre, StringComparison.OrdinalIgnoreCase))
                {
                    movies = _allMovies.Movies.Where(i => i.Genre.genreName.Equals("Фэнтези")).OrderBy(i => i.id);
                    currGenre = "Фэнтези";
                }
                else if (string.Equals("Drama", genre, StringComparison.OrdinalIgnoreCase))
                {
                    movies = _allMovies.Movies.Where(i => i.Genre.genreName.Equals("Драма")).OrderBy(i => i.id);
                    currGenre = "Драма";
                }
            }

            var movieObj = new MoviesListViewModel
            {
                allMovies = movies,
                currGenre = currGenre
            };

            ViewBag.Title = "АнтиКинотеатр";

            return View(movieObj);
        }
    }
}
