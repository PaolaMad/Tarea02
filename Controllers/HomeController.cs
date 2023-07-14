using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tarea02.Models;
using Tarea02.Services;

namespace Tarea02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioNews repositorioNews;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioNews repositorioNews,
            IConfiguration configuration)
        {
            _logger = logger;
            this.repositorioNews = repositorioNews;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {

            var elementNumber = configuration.GetValue<int>("elements");

            var news = repositorioNews.GetNews().Take(elementNumber).ToList();

            var model = new NewsIndexModel
            {

                News = news

            };

            return View(model);
        }

        public IActionResult VerNoticias()
        {
            var New = repositorioNews.GetNews();
            return View(New);
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(NewsIndexModel model)
        //{

        //    await List<New> news.add

        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}