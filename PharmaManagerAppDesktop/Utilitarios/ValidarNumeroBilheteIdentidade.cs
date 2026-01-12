using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Utilitarios
{
    public static class ValidarNumeroBilheteIdentidade
    {

        public class ValidarBilheteResposta
        {
            public bool Valido = false;
            public string? NumeroBilheteIdentidade;
            public string? MsgErro = null;
        }

        public static ValidarBilheteResposta Validar(string codigoBilheteIdentidade)
        {


            const string baseTextoAceito = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const string baseNumeroAceito = "0123456789";


            var Texto = codigoBilheteIdentidade.Trim().Replace(" ", "");
            var TamanhoTexto = Texto.Length;

            if (String.IsNullOrWhiteSpace(Texto) || TamanhoTexto != 14)
            {
                return new ValidarBilheteResposta()
                {
                    Valido = false,
                    NumeroBilheteIdentidade = null,
                    MsgErro = "O Número de Bilhete Informado é inválido. \n Deve ter 14 caracteres no formato: 000000000XX000"
                };
            }

            var ParteInicial = Texto.Substring(0, 9);
            var ParteCodigoProvincia = Texto.Substring(9, 2);
            var ParteFinal = Texto.Substring(11, 3);

            var FormatoCorreto = true;

            foreach (var Caractere in ParteInicial)
            {
                if (FormatoCorreto)
                    FormatoCorreto = baseNumeroAceito.Contains(Caractere);
                else
                    break;
            }

            foreach (var Caractere in ParteCodigoProvincia)
            {
                if (FormatoCorreto)
                    FormatoCorreto = baseTextoAceito.Contains(Caractere);
                else
                    break;
            }

            foreach (var Caractere in ParteFinal)
            {
                if (FormatoCorreto)
                    FormatoCorreto = baseNumeroAceito.Contains(Caractere);
                else
                    break;
            }

            if (FormatoCorreto)
            {
                return new ValidarBilheteResposta()
                {
                    Valido = true,
                    NumeroBilheteIdentidade = Texto.ToUpper(),
                };
            }
            else
            {
                return new ValidarBilheteResposta()
                {
                    Valido = false,
                    NumeroBilheteIdentidade = null,
                    MsgErro = "O Número de Bilhete Informado é inválido. \n Deve ter 14 caracteres no formato: 000000000XX000"
                };
            }

        }

    }
}
