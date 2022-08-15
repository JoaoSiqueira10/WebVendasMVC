using Microsoft.AspNetCore.Mvc;

namespace WebVendasMvc.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
