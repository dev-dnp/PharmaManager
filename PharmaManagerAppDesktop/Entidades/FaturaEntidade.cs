using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class FaturaEntidade
    {
        public int IdFatura { get; set; }
        public int? IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public int IdEstadoFatura { get; set; }
        public int IdMetodoPagamento { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal TotalPagamento { get; set; }
    }
}
