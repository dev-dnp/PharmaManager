using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PharmaManagerAppDesktop.BaseDeDados.EstoqueBD;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class CategoriaProdutoBD
    {

        public List<CategoriaEntidade> BuscarTodas()
        {
            List<CategoriaEntidade> CategoriasProduto = new List<CategoriaEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_CATEGORIA, NOME FROM TB_CATEGORIA WHERE ATIVO = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                CategoriasProduto.Add(new CategoriaEntidade
                                {
                                    IdCategoria = leitor.IsDBNull(leitor.GetOrdinal("ID_CATEGORIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CATEGORIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                });
                            }
                        }
                    }
                }

                return CategoriasProduto;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falha ao retonar todas categorias de produto.");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }
      
        public string Adicionar(string nomeCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"INSERT INTO TB_CATEGORIA (NOME) VALUES (@nome)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeCategoria);
                        cmd.ExecuteNonQuery();
                    }

                    return "Categoria adicionada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao adicionar nova categoria de produto!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }

        public string Eliminar(int idCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE TB_CATEGORIA SET ATIVO = 0 WHERE ID_CATEGORIA = @idCategoria";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.ExecuteNonQuery();
                    }

                    return "Categoria eliminada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao eliminar categoria de produto!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }
    }
}
