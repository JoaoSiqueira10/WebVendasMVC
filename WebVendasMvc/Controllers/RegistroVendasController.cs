using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebVendasMvc.Services;

namespace WebVendasMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly RegistroVendasService _registroVendasService;
        public RegistroVendasController(RegistroVendasService registroVendasService)
        {
            _registroVendasService = registroVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PesquisaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year,1,1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var resultado = await _registroVendasService.FindByDateAsync(minDate, maxDate);
            return View(resultado);
        }

        public async Task<IActionResult> PesquisaGrupo(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var resultado = await _registroVendasService.FindByDateGrupoAsync(minDate, maxDate);
            return View(resultado);
        }
    }
}
