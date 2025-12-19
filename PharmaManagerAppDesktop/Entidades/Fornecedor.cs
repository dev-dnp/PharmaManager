using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public int? IdEndereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
