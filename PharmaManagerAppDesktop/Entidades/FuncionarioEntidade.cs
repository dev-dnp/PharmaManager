using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class FuncionarioEntidade
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string BilheteIdentidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? IdUsuario { get; set; }
        public int IdCargo { get; set; }
        public int? IdEndereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
