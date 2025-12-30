using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.Utilitarios
{
    public static class ValidarNumeroTelefone
    {

        public static string Validar(string numero)
        {
            string[] PossiveisComecos = {"244", "+244", ""};

            string NumeroRecebido = numero.Trim().Replace(" ", "");

            try
            {
                int posicao = NumeroRecebido.Length - 9;
                string PrefixoNumeroTelefone = NumeroRecebido.Substring(0, posicao);
                bool PrefixoValido = false;

                int NumeroTelefone = Convert.ToInt32(NumeroRecebido.Substring(posicao));

                foreach (string PossivelComeco in PossiveisComecos)
                {
                    if (PrefixoNumeroTelefone == PossivelComeco)
                    {
                        PrefixoValido = true;
                        break;
                    }
                }

                if (PrefixoValido && NumeroTelefone.ToString().StartsWith("9"))
                {
                    return "+244" + NumeroTelefone.ToString();
                }
                else
                {
                    throw new Exception("Prefixo inválido, use +244 ou 244, a seguir o seu número de telemóvel");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Número de telefone inválido para Angola");
                Console.WriteLine("Informação do erro: " + ex.Message);
                return null;
            }
        }

    }
}
