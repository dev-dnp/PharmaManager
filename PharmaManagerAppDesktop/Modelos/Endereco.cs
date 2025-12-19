using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Modelos
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Casa { get; set; }
        public int IdMunicipio { get; set; }
        // public Municipio Municipio { get; set; } // opcional
    }
}
