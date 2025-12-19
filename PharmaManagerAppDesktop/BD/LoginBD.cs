using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BD
{
    //public class LoginBD
    //{
    //    string email;
    //    string senha;

    //    public Dictionary<string, object> Autenticacao(string email, string senha)
    //    {
    //        using (SqlConnection conn = ConexaoBD.Conectar())
    //        {
    //            string query = "SELECT * FROM TB_USUARIO WHERE EMAIL = @email AND SENHA = @senha";

    //            using (SqlCommand cmd = new SqlCommand(query, conn))
    //            {
    //                cmd.Parameters.AddWithValue("@email", email);
    //                cmd.Parameters.AddWithValue("@senha", senha);

    //                using (SqlDataReader reader = cmd.ExecuteReader())
    //                {
    //                    if (reader.Read())
    //                    {
    //                        // Cria dicionário do usuário
    //                        var usuario = new Dictionary<string, object>();
    //                        for (int i = 0; i < reader.FieldCount; i++)
    //                        {
    //                            usuario[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
    //                        }

    //                        // Busca funcionário relacionado
    //                        FuncionarioBD funcionarioBD = new FuncionarioBD();
    //                        var funcionario = funcionarioBD.BuscarFuncionarioPorIdUsuario(usuario["ID_USUARIO"].ToString());

    //                        // Retorna um dicionário com ambos
    //                        var resultado = new Dictionary<string, object>
    //                        {
    //                            { "usuario", usuario },
    //                            { "funcionario", funcionario }
    //                        };

    //                        return resultado;
    //                    }
    //                    else
    //                    {
    //                        return null; // usuário não encontrado
    //                    }
    //                }
    //            }
    //        }
    //    }

    //}
}
