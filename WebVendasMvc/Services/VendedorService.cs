using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebVendasMvc.Data;
using WebVendasMvc.Models;
using WebVendasMvc.Services.Exceptions;

namespace WebVendasMvc.Services
{
    public class VendedorService
    {
        private readonly WebVendasMvcContext _context;

        public VendedorService(WebVendasMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
        public Vendedor FindById(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Vendedor obj)
        {
            if (!_context.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("ID nao encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
