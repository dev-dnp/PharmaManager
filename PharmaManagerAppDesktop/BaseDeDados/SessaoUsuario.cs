using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaManagerAppDesktop.Entidades;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public static class SessaoUsuario
    {
        public static Usuario Usuario { get; set; }
        public static FuncionarioEntidade Funcionario { get; set; }
        public static Permissao Permissao { get; set; }
        public static CargoEntidade Cargo { get; set; }
        public static Municipio Municipio { get; set; }
        public static Provincia Provincia { get; set; }
        public static Endereco Endereco { get; set; }

    }
}
