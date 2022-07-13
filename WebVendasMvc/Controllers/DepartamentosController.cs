using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebVendasMvc.Models;

namespace WebVendasMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Nome = "Esportes" });

            return View(list);
        }
    }
}
