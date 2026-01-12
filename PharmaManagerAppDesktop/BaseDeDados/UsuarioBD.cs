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

        public int? CadastrarUsuario(string email, string senha)
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

                // APÓS O USUÁRIO SER CADASTRADO, O SEU ID É RETORNADO, CASO TENHA SIDO CADASTRADO COM SUCESSO!

                if (IdInserido > 0)
                    return IdInserido;
                else
                    return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar novo usuário");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }

        public UsuarioEntidade AutenticarUsuario(string email, string senha)
        {
            List<UsuarioEntidade> Usuarios = new List<UsuarioEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT TOP 1 tb_u.ID_USUARIO, tb_u.EMAIL, tb_u.SENHA, tb_u.ATIVO
                                        FROM TB_USUARIO tb_u
                                        JOIN TB_FUNCIONARIO tb_f ON tb_f.ID_USUARIO = tb_u.ID_USUARIO
                                        WHERE  
                                            tb_u.EMAIL = @email AND tb_u.SENHA = @senha AND tb_f.ATIVO = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Usuarios.Add(new UsuarioEntidade
                                {
                                    IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("EMAIL")),
                                    Senha = leitor.IsDBNull(leitor.GetOrdinal("SENHA")) ? null : leitor.GetString(leitor.GetOrdinal("SENHA")),
                                    Ativo = leitor.IsDBNull(leitor.GetOrdinal("ATIVO")) ? false : leitor.GetBoolean(leitor.GetOrdinal("ATIVO"))
                                });
                            }
                        }
                    }

                    // CASO NÃO ENCONTRE NENHUM USUÁRIO, ENTÃO A AUTENTICAÇÃO FALHA
                    if (Usuarios.Count == 0) return null;

                    // CASO ENCONTRE UM USUÁRIO, ENTÃO AS SUAS INFORMAÇÕES SÃO RETORNADAS
                    return Usuarios.First();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Autenticação do usuário falhou!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }

        }
    
        public bool AlterarSenha(string email, string senhaAtual, string senhaNova, int idUsuario)
        {
            // SE A SENHA ATUAL VIR NULL ENTÃO ELE PRECISA SIMPLESMENTE ALTERAR A SENHA SEM INFORMAR A ATUAL

            if(senhaAtual != null)
            {
                var Autenticar = this.AutenticarUsuario(email, senhaAtual);
                
                // SE A SENHA ANTIGA NÃO CONDIZER, ENTÃO NÃO É POSSÍVEL ALTERAR A SENHA
                if(Autenticar == null) return false;
            }

            try
            {
                int LinhasAfetadasNoBanco = 0;

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
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        LinhasAfetadasNoBanco = cmd.ExecuteNonQuery();
                    }

                    if (LinhasAfetadasNoBanco > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar a senha do usuário!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return false;
            }
        }
    
        public bool AtribuirUsuario(string email, string senha, int idFuncionario)
        {
            // CADASTRAR O USUÁRIO E RETORNAR O ID CADASTRADO
            var IdUsuario = this.CadastrarUsuario(email, senha);

            // CADASTRAR O USUARIO, CASO NÃO FUNCIONE, A OPERAÇÃO FALHA
            if (IdUsuario == null)  return false;
            
            int LinhasAfetadasNoBanco = 0;

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
                        LinhasAfetadasNoBanco = cmd.ExecuteNonQuery();
                    }
                }

                if(LinhasAfetadasNoBanco > 0) 
                    return true; 
                else 
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atribuir o usuário!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return false;
            }

        }

        public bool AtivarDesativarUsuario(int idUsuario, int estado)
        {
            try
            {
                int LinhasAfetadasNoBanco = 0;

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
                        LinhasAfetadasNoBanco = cmd.ExecuteNonQuery();
                    }
                }

                if (LinhasAfetadasNoBanco > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao alterar o estado de usuário");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return false;
            }
        }
    }
}
