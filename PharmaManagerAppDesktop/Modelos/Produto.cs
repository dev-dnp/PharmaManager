using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Modelos
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public decimal PrecoVenda { get; set; }
        public int IdCategoria { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
