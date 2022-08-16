using Microsoft.AspNetCore.Mvc;

namespace WebVendasMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PesquisaSimples()
        {
            return View();
        }

        public IActionResult PesquisaGrupo()
        {
            return View();
        }
    }
}
