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
             new MovieViewModel { Id = 1, Name = "Titanic", Rating = "10", ReleaseYear = 1997, Genre = "Romance/Drama", Imgg = "/images/titanic.png", Vidd = "https://youtu.be/I7c1etV7D7g?si=cIFyAuraKypWF15b" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "9", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Imgg = "/images/inception.jpg", Vidd = "https://youtu.be/Jvurpf91omw?si=6cue194iYRHzCN1j" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "10", ReleaseYear = 1994, Genre = "Drama", Imgg = "/images/shawshanks.jpg", Vidd = "https://youtu.be/PLl99DlL6b4?si=8-N7AI7z0TsGuwDL" },
            new MovieViewModel { Id = 4, Name = "Scream", Rating = "6", ReleaseYear = 2022, Genre = "Horror", Imgg = "/images/scream.jpg", Vidd =  "https://www.youtube.com/watch?v=beToTslH17s" },
            new MovieViewModel { Id = 5, Name = "Talk to Me", Rating = "7", ReleaseYear = 2022, Genre = "Horror", Imgg = "/images/talktome.jpg", Vidd =  "https://www.youtube.com/watch?v=aLAKJu9aJys" },
            new MovieViewModel { Id = 6, Name = "The Batman", Rating = "7", ReleaseYear = 2022, Genre = "Action/Drama", Imgg = "/images/thebatman.jpg", Vidd =  "https://youtu.be/mqqft2x_Aa4?si=dtu10ZqRWB8S8G67" },
            new MovieViewModel { Id = 7, Name = "Babylon", Rating = "7", ReleaseYear = 2022, Genre = "Comedy/Drama", Imgg = "/images/babylon.jpg", Vidd =  "https://youtu.be/5muQK7CuFtY?si=7V8V4GWMK9x6FcBV" },
            new MovieViewModel { Id = 8, Name = "Don't Worry Darling", Rating = "6", ReleaseYear = 2022, Genre = "Drama", Imgg = "/images/dontworrydarling.jpg", Vidd =  "https://youtu.be/bW9aRVXIwaY?si=5iPGjSfhGR0KdegG" },
            new MovieViewModel { Id = 9, Name = "The Menu", Rating = "7", ReleaseYear = 2022, Genre = "Comedy/Horror", Imgg = "/images/themenu.jpg", Vidd =  "hhttps://youtu.be/Kx55Rkynhtk?si=Q5EMu6BBIC7JgR2g" },
            new MovieViewModel { Id = 10, Name = "Pearl", Rating = "7", ReleaseYear = 2022, Genre = "Drama/Horror",Imgg = "/images/pearl.jpg", Vidd =  "https://youtu.be/CA7nwu5ZwLE?si=UFO0COxdtDyuakAK" },
            new MovieViewModel { Id = 11, Name = "Forrest Gump", Rating = "8", ReleaseYear = 1994, Genre = "Drama/Romance", Imgg = "/images/forrestgump.jpg", Vidd =  "https://youtu.be/bLvqoHBptjg?si=1nXXzQVZ3UEOfn0b" },
            new MovieViewModel { Id = 12, Name = "The Matrix", Rating = "8", ReleaseYear = 1999, Genre = "Action", Imgg = "/images/thematrix.jpg", Vidd =  "https://youtu.be/nNpvWBuTfrc?si=foCuhSrP2QcaIQxc" },
            new MovieViewModel { Id = 13, Name = "The Silence of the Lambs", Rating = "8", ReleaseYear = 1991, Genre = "Drama/Thriller", Imgg = "/images/thesilentlambs.jpg", Vidd =  "https://youtu.be/W6Mm8Sbe__o?si=wjghvAioyNxDizVC" },
            new MovieViewModel { Id = 14, Name = "Gladiator", Rating = "8", ReleaseYear = 2000, Genre = "Drama/Fantasy", Imgg = "/images/gladiator.jpg", Vidd =  "https://youtu.be/TcYIqlBihW4?si=QfdkNG9oNVfhjH8u" },
            new MovieViewModel { Id = 15, Name = "The Departed", Rating = "8", ReleaseYear = 2006, Genre = "Drama", Imgg = "/images/thedeparted.jpg", Vidd =  "https://youtu.be/iojhqm0JTW4?si=iUaMeLDk8-GEVG1r" },
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

