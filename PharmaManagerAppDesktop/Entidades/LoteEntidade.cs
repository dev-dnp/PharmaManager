using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class LoteEntidade
    {
        public int IdLote { get; set; }
        public int IdProduto { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal PrecoCompra { get; set; }
    }
}
