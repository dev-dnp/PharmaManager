using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class PermissaoBD
    {

        public bool AtualizarPermissao(int idUsuario, int idPermissao)
        {
            try
            {
                int LinhasAfetadasNoBanco = 0;

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();
                    
                    int Id = 0;


                    string consultar = "SELECT COUNT(*) FROM TB_USUARIO_PERMISSAO WHERE ID_USUARIO = @idUsuario";

                    using (SqlCommand cmd = new SqlCommand(consultar, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if(Id > 0)
                    {
                        string query = "UPDATE TB_USUARIO_PERMISSAO SET ID_PERMISSAO = @idPermissao WHERE ID_USUARIO = @idUsuario";

                        using (SqlCommand cmd = new SqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmd.Parameters.AddWithValue("@idPermissao", idPermissao);
                            cmd.ExecuteNonQuery();
                        }
                    } else
                    {

                        string query = "INSERT INTO TB_USUARIO_PERMISSAO (ID_USUARIO, ID_PERMISSAO) VALUES (@idUsuario, @idPermissao)";

                        using (SqlCommand cmd = new SqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmd.Parameters.AddWithValue("@idPermissao", idPermissao);
                            LinhasAfetadasNoBanco = cmd.ExecuteNonQuery();
                        }
                    }

                    
                }

                if (LinhasAfetadasNoBanco > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha atualizar a permissao!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return false;
            }
        }
    }
}
