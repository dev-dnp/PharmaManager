using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Entidades
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public string Nome { get; set; }
        public int IdProvincia { get; set; }
        // public Provincia Provincia { get; set; } // opcional
    }
}
