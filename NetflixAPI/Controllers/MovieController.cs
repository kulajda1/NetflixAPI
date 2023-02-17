using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixAPI.Models;

namespace NetflixAPI.Controllers
{
    [Route("api/GetMovies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1, Title="Vakáció", Description="Ez egy fogyatékos vígjáték.", Length=100, Rating=5, Category="Vígjáték" },
                new Movie{Id=2, Title="Jelek", Description="Ez a film egy nagyon durván komoly ufós thriller. Be fogtok fosni. Az fix.", Length=120, Rating=5, Category="Thriller" },
                new Movie{Id=3, Title="Horrorra akadva 2", Description="Horror házba zárta a főhöseinket a pedofil és a kerekes.", Length=110, Rating=4, Category="Horrorvígjáték" },
                new Movie{Id=4, Title="Szerelmünk lapjai", Description="Csöpögős szar.", Length=120, Rating=2, Category="Romantikus dráma" }
            };
        }
    }
}
