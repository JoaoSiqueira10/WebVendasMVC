﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendasMvc.Models;

namespace WebVendasMvc.Data
{
    public class WebVendasMvcContext : DbContext
    {
        public WebVendasMvcContext (DbContextOptions<WebVendasMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }

    }
}
