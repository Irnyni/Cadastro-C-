using Microsoft.AspNetCore.Mvc;

namespace Pagina.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
