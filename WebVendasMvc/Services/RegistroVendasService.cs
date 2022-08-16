using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendasMvc.Data;
using WebVendasMvc.Models;
using Microsoft.EntityFrameworkCore;


namespace WebVendasMvc.Services
{
    public class RegistroVendasService
    {
        private readonly WebVendasMvcContext _context;

        public RegistroVendasService(WebVendasMvcContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroVendas>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.RegistroVendas select obj;
            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate.Value);
            }
            return await resultado.Include(x => x.Vendedor).Include(x => x.Vendedor.Departamento).OrderByDescending(x => x.Data).ToListAsync();
        }
    }
}
