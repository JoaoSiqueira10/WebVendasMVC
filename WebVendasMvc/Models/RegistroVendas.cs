using System;
using WebVendasMvc.Models.Enums;

namespace WebVendasMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public EstatusVendas status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantidade, EstatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            this.status = status;
            Vendedor = vendedor;
        }
    }
}
