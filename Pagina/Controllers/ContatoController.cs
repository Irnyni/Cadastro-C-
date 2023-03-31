using Microsoft.AspNetCore.Mvc;

namespace Pagina.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
