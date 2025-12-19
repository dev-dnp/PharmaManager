using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharmaManagerAppDesktop.BD
{
    //public class FuncionarioBD
    //{
    //    public Dictionary<string, object> BuscarFuncionarioPorIdUsuario(string idUsuario)
    //    {
    //        string query = "SELECT * FROM TB_FUNCIONARIO WHERE ID_USUARIO = @idUsuario";

    //        using (SqlConnection conn = ConexaoBD.Conectar())
    //        {
    //            using (SqlCommand cmd = new SqlCommand(query, conn))
    //            {
    //                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

    //                using (SqlDataReader reader = cmd.ExecuteReader())
    //                {
    //                    if (reader.Read())
    //                    {
    //                        var funcionario = new Dictionary<string, object>();

    //                        for (int i = 0; i < reader.FieldCount; i++)
    //                        {
    //                            funcionario[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
    //                        }

    //                        return funcionario; // retorna os dados
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
