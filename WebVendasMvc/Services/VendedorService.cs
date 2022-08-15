﻿using System.Collections.Generic;
using System.Linq;
using WebVendasMvc.Data;
using WebVendasMvc.Models;

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
    }
}
