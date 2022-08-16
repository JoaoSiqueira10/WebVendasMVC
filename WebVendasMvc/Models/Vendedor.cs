using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebVendasMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }
        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
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
