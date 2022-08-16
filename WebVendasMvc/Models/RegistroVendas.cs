using System;
using System.ComponentModel.DataAnnotations;
using WebVendasMvc.Models.Enums;

namespace WebVendasMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Quantidade { get; set; }
        public EstatusVendas Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantidade, EstatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
