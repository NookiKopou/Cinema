using Cinema.Data.Interfaces;
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

        //[Route("Games/List")]
        //[Route("Games/List/{category}")]
        public ViewResult List(string category)
        {
            //string _category = category;
            //IEnumerable<Game> games = null;
            //string currCategory = "";
            //if (string.IsNullOrEmpty(category))
            //{
            //    games = _allGames.Games.OrderBy(i => i.id);
            //}
            //else
            //{
            //    if (string.Equals("multi", category, StringComparison.OrdinalIgnoreCase))
            //    {
            //        games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Мультиплеер")).OrderBy(i => i.id);
            //        currCategory = "Мультиплеер";
            //    }
            //    else if (string.Equals("single", category, StringComparison.OrdinalIgnoreCase))
            //    {
            //        games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Сингплеер")).OrderBy(i => i.id);
            //        currCategory = "Сингплеер";
            //    }
            //}

            //var gameObj = new GamesListViewModel
            //{
            //    allGames = games,
            //    currCategory = currCategory
            //};

            MoviesListViewModel obj = new MoviesListViewModel();
            obj.allMovies = _allMovies.Movies;
            obj.currGenre = "";

            ViewBag.Title = "АнтиКинотеатр";

            return View(obj);
        }
    }
}
