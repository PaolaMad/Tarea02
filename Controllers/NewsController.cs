using Microsoft.AspNetCore.Mvc;
using Tarea02.Services;

namespace Tarea02.Controllers
{
    public class NewsController : Controller
    {
        private readonly IRepositorioNews repositorioNews;

        public NewsController(ILogger<NewsController> logger,
            IRepositorioNews repositorioNews)
        {
            this.repositorioNews = repositorioNews;
        }

        public IActionResult Politica()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

        public IActionResult Deportes()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

        public IActionResult Economia()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

        public IActionResult Internacionales()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

        public IActionResult Salud()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

        public IActionResult Entretenimiento()
        {

            var New = repositorioNews.GetNews();

            return View(New);
        }

    }
}
