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
                int NumeroTelefone = Convert.ToInt32(NumeroRecebido.Substring(posicao));
                
                bool PrefixoValido = false;

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
                    throw new Exception("Prefixo inválido ou começo inválido! Use 244 9... ou +244 9... ou 9...");
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
