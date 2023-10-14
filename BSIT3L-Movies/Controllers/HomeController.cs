using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "10", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "9", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "10", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "Scream", Rating = "6", ReleaseYear = 2022, Genre = "Horror" },
            new MovieViewModel { Id = 5, Name = "Talk to Me", Rating = "7", ReleaseYear = 2022, Genre = "Horror"},
            new MovieViewModel { Id = 6, Name = "The Batman", Rating = "7", ReleaseYear = 2022, Genre = "Action/Drama"},
            new MovieViewModel { Id = 7, Name = "Babylon", Rating = "7", ReleaseYear = 2022, Genre = "Comedy/Drama"},
            new MovieViewModel { Id = 8, Name = "Don't Worry Darling", Rating = "6", ReleaseYear = 2022, Genre = "Drama"},
            new MovieViewModel { Id = 9, Name = "The Menu", Rating = "7", ReleaseYear = 2022, Genre = "Comedy/Horror"},
            new MovieViewModel { Id = 10, Name = "Pearl", Rating = "7", ReleaseYear = 2022, Genre = "Drama/Horror"},
            new MovieViewModel { Id = 11, Name = "Forrest Gump", Rating = "8", ReleaseYear = 1994, Genre = "Drama/Romance" },
            new MovieViewModel { Id = 12, Name = "The Matrix", Rating = "8", ReleaseYear = 1999, Genre = "Action"},
            new MovieViewModel { Id = 13, Name = "The Silence of the Lambs", Rating = "8", ReleaseYear = 1991, Genre = "Drama/Thriller"},
            new MovieViewModel { Id = 14, Name = "Gladiator", Rating = "8", ReleaseYear = 2000, Genre = "Drama/Fantasy" },
            new MovieViewModel { Id = 15, Name = "The Departed", Rating = "8", ReleaseYear = 2006, Genre = "Drama"},
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

