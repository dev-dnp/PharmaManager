using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class MovimentoEstoque
    {
        public int IdMovimento { get; set; }
        public int IdLote { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Motivo { get; set; }
        public DateTime DataMovimento { get; set; }
        public int IdFuncionario { get; set; }
    }
}
