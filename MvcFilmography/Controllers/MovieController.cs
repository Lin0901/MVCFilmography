using Microsoft.AspNetCore.Mvc;
using MvcFilmography.Models;
using System.Linq;

namespace MvcFilmography.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> Movies { get; set; }

        public MovieController()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie("夏洛特烦恼", "喜剧片", "3000万", new DateTime(2010,09,01)));
            Movies.Add(new Movie("西虹市首富", "喜剧片", "5000万", new DateTime(2012,08,01)));
            Movies.Add(new Movie("猩球崛起", "科幻片", "1亿", new DateTime(2015,10,01)));
            Movies.Add(new Movie("甲方乙方", "剧情片", "600万", new DateTime(1999,07,01)));
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "All Movies";
            return View(Movies);
        }
        public IActionResult AllComedyMovies()
        {
            ViewData["Title"] = "All Comedy Movies";
            return View("Index", Movies.Where(m => m.Category.Contains("喜剧片")).ToList());
        }
    }
}
