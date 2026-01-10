using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class UsuarioBD
    {

        public string CadastrarUsuario(string email, string senha)
        {
            int IdInserido = 0;

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"INSERT INTO TB_USUARIO (EMAIL, SENHA) VALUES (@email, @senha); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        IdInserido = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                return IdInserido.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar com a base de dados! Verifique a ligação.");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }

        public UsuarioEntidade AutenticarUsuario(string email, string senha)
        {
            List<UsuarioEntidade> usuarios = new List<UsuarioEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT TOP 1 tb_u.ID_USUARIO, tb_u.EMAIL, tb_u.SENHA, tb_u.ATIVO
                                    FROM TB_USUARIO tb_u
                                    JOIN TB_FUNCIONARIO tb_f ON tb_f.ID_USUARIO = tb_u.ID_USUARIO
                                    WHERE  
                                        tb_u.EMAIL = @email AND tb_u.SENHA = @senha AND tb_f.ATIVO = 1
";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                usuarios.Add(new UsuarioEntidade
                                {
                                    IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("EMAIL")),
                                    Senha = leitor.IsDBNull(leitor.GetOrdinal("SENHA")) ? null : leitor.GetString(leitor.GetOrdinal("SENHA")),
                                    Ativo = leitor.IsDBNull(leitor.GetOrdinal("ATIVO")) ? false : leitor.GetBoolean(leitor.GetOrdinal("ATIVO"))
                                });
                            }
                        }
                    }

                    if (usuarios.Count == 0) return null;
                    return usuarios.First();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar com a base de dados! Verifique a ligação.");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }

        }
    
        public string AlterarSenha(string email, string senhaAtual, string senhaNova)
        {
            var Autenticar = this.AutenticarUsuario(email, senhaAtual);

            if(Autenticar == null) return null;

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE TB_USUARIO
                                     SET
                                        SENHA = @novaSenha
                                    WHERE 
                                        ID_USUARIO = @idUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@novaSenha", senhaNova);
                        cmd.Parameters.AddWithValue("@idUsuario", Autenticar.IdUsuario);
                        cmd.ExecuteNonQuery();
                    }

                    return "Senha alterada com sucesso!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar com a base de dados! Verifique a ligação.");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }
    
        public string AtribuirUsuario(string email, string senha, int idFuncionario)
        {
            var IdUsuario = this.CadastrarUsuario(email, senha);

            if(IdUsuario == null)  return null;

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE TB_FUNCIONARIO 
                                        SET
                                            ID_USUARIO = @idUsuario
                                        WHERE
                                            ID_FUNCIONARIO = @idFuncionario";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(IdUsuario));
                        cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Usuario atribuido com sucesso!";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atribuir o usuário!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }

        }

        public string AtivarDesativarUsuario(int idUsuario, int estado)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE TB_USUARIO
                                     SET
                                        ATIVO = @ativo
                                     WHERE 
                                        ID_USUARIO = @idUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@ativo", estado);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Estado de usuário alterado com sucesso!";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao alterar o estado de usuário");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }
    }
}
