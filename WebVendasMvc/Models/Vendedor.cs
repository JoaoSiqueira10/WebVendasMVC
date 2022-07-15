using System;
using System.Collections.Generic;
using System.Linq;

namespace WebVendasMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string name, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RegistroVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double VendasTotais(DateTime inicio, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Quantidade); //expressao lambda
        }
    }
}
