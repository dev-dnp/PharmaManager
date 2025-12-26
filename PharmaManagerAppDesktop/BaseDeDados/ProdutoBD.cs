using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PharmaManagerAppDesktop.Entidades;
using System.Web.Management;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class ProdutoBD
    {
        public class DetalhesProduto
        {
            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public int QuantidadeProduto { get; set; }
            public decimal PrecoUnitario { get; set; }
        }

        public class ProdutoResposta
        {
            public ProdutoEntidade Produto { get; set; } = new ProdutoEntidade();
            public CategoriaEntidade Categoria { get; set; } = new CategoriaEntidade();
            public int QuantidadeTotal { get; set; }
        }


        public List<DetalhesProduto> BuscarProdutosDisponiveis()
        {
            List <DetalhesProduto> produtosEncontrados = new List<DetalhesProduto>();

            string query = @"SELECT 
                                p.ID_PRODUTO,
                                p.NOME AS PRODUTO_NOME,
                                SUM(e.QUANTIDADE) AS QUANTIDADE_TOTAL,
                                p.PRECO_VENDA
                            FROM TB_PRODUTO p
  
                            JOIN TB_LOTE l ON l.ID_PRODUTO = p.ID_PRODUTO
                            JOIN TB_ESTOQUE e ON e.ID_LOTE = l.ID_LOTE

                                WHERE e.QUANTIDADE > 0 AND l.DATA_VALIDADE >= GETDATE()
                            GROUP BY 
                                p.ID_PRODUTO,
                                p.NOME,
                                p.PRECO_VENDA";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                using(SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using(SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while(leitor.Read())
                        {
                            produtosEncontrados.Add(new DetalhesProduto
                            {
                                IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                NomeProduto = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PRODUTO_NOME")),
                                PrecoUnitario = leitor.IsDBNull(leitor.GetOrdinal("PRECO_VENDA")) ? 0 : leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                QuantidadeProduto = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE_TOTAL")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE_TOTAL")),
                            });
                        }
                    }
                }
            }

            return produtosEncontrados;
        }

        public List<ProdutoResposta> BuscarProdutos()
        {
            var ListaProduto = new List<ProdutoResposta>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT 
                                  pdt.ID_PRODUTO,
                                  pdt.ID_CATEGORIA,
                                  pdt.NOME AS PRODUTO_NOME,
                                  pdt.PRECO_VENDA AS PRODUTO_PRECO_VENDA,
                                  pdt.CODIGO_BARRAS AS PRODUTO_CODIGO_BARRAS,
                                  pdt.DATA_CRIACAO AS PRODUTO_DATA_CRIACAO,

                                  cat.NOME AS CATEGORIA_NOME,

                                  SUM(est.QUANTIDADE) AS QUANTIDADE_TOTAL
  
                                FROM TB_PRODUTO pdt
                                  LEFT JOIN TB_CATEGORIA cat
                                    ON cat.ID_CATEGORIA = pdt.ID_CATEGORIA
                                  LEFT JOIN TB_LOTE lot
                                    ON lot.ID_PRODUTO = pdt.ID_PRODUTO
                                  LEFT JOIN TB_ESTOQUE est
                                    ON est.ID_LOTE = lot.ID_LOTE

                                GROUP BY 
                                  pdt.ID_PRODUTO,
                                  pdt.NOME,
                                  pdt.ID_CATEGORIA,
                                  pdt.PRECO_VENDA,
                                  pdt.CODIGO_BARRAS,
                                  pdt.DATA_CRIACAO,
                                  cat.NOME";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                ListaProduto.Add(new ProdutoResposta
                                {
                                    Produto =
                                {
                                    IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                    IdCategoria = leitor.IsDBNull(leitor.GetOrdinal("ID_CATEGORIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CATEGORIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("PRODUTO_NOME")),
                                    CodigoBarras = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_CODIGO_BARRAS")) ? "-" : leitor.GetString(leitor.GetOrdinal("PRODUTO_CODIGO_BARRAS")),
                                    PrecoVenda = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_PRECO_VENDA")) ? 0 : leitor.GetDecimal(leitor.GetOrdinal("PRODUTO_PRECO_VENDA")),
                                    DataCriacao = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_DATA_CRIACAO")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("PRODUTO_DATA_CRIACAO")),
                                },
                                    Categoria =
                                {
                                    IdCategoria = leitor.IsDBNull(leitor.GetOrdinal("ID_CATEGORIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CATEGORIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CATEGORIA_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("CATEGORIA_NOME")),
                                },
                                    QuantidadeTotal = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE_TOTAL")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE_TOTAL")),
                                });
                            }
                        }
                    }
                }

                return ListaProduto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao pegar os produtos: " +  ex.Message);
                return null;
            }
        }
    
        public void AdicionarProduto(ProdutoEntidade produto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"INSERT INTO TB_PRODUTO
                                        (NOME, CODIGO_BARRAS, ID_CATEGORIA,  PRECO_VENDA)
                                    VALUES
                                        (@nome, @codigoBarras, @idCategoria, @precoVenda)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.Nome);
                        cmd.Parameters.AddWithValue("@codigoBarras", produto.CodigoBarras);
                        cmd.Parameters.AddWithValue("@idCategoria", produto.IdCategoria);
                        cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar produto: " + ex.Message);
            }
        }
    
        public bool EditarProduto(ProdutoEntidade produto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE
                                        TB_PRODUTO
                                    SET
                                        NOME = @nome, 
                                        CODIGO_BARRAS = @codigoBarras, 
                                        PRECO_VENDA = @precoVenda, 
                                        ID_CATEGORIA = @idCategoria
                                    WHERE
                                        ID_PRODUTO = @idProduto
                                    ";


                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.Nome);
                        cmd.Parameters.AddWithValue("@codigoBarras", produto.CodigoBarras);
                        cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
                        cmd.Parameters.AddWithValue("@idCategoria", produto.IdCategoria);
                        cmd.Parameters.AddWithValue("@idProduto", produto.IdProduto);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao editar o produto: " + ex.Message);
            }
        }
    
        public bool EliminarProduto(List<int> idProduto)
        {
            try
            {
                using (SqlTransaction conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    SqlTransaction transacao = conexao.BeginTransaction()

                    string query = @"DELETE FROM
                                        TB_PRODUTO
                                    WHERE
                                        ID_PRODUTO = @idProduto
                    ";


                    foreach (int id in idProduto)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idProduto", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao eliminar o produto: " + ex.Message);

                if(ex.Number == 547) return false;
            }
        }


    }
}
