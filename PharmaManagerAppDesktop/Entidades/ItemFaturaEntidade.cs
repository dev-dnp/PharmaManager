using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class ItemFaturaEntidade
    {
        public int IdItemFatura { get; set; }
        public int IdFatura { get; set; }
        public int IdLote { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Desconto { get; set; }
    }
}
