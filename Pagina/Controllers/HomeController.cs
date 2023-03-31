using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pagina.Models;

namespace Pagina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Homemodel home = new Homemodel();
            home.email = "felipemalengo1@hotmail.com";
            home.idade = 20;
            return View(home);
        }

        public IActionResult Referencias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}