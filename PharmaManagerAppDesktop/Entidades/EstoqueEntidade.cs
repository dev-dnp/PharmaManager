using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class EstoqueEntidade
    {
        public int IdEstoque { get; set; }
        public int IdLote { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
