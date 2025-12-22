using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class ProdutoDB
    {
        public class DetalhesProduto
        {
            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public int IdLote { get; set; }
            public DateTime DataValidadeProduto { get; set; }
            public int QuantidadeProduto { get; set; }
            public decimal PrecoUnitario { get; set; }
        }


        public List<DetalhesProduto> BuscarProdutosDisponiveis()
        {
            List <DetalhesProduto> produtosEncontrados = new List<DetalhesProduto>();

            string query = @"SELECT 
                                p.ID_PRODUTO,
                                p.NOME AS PRODUTO_NOME,
                                l.ID_LOTE,
                                l.DATA_VALIDADE,
                                e.QUANTIDADE,
                                p.PRECO_VENDA
                            FROM TB_PRODUTO p
                            JOIN TB_LOTE l ON l.ID_PRODUTO = p.ID_PRODUTO
                            JOIN TB_ESTOQUE e ON e.ID_LOTE = l.ID_LOTE
                            JOIN (
                                SELECT ID_PRODUTO, MIN(DATA_VALIDADE) AS DATA_VENCIMENTO_MIN
                                FROM TB_LOTE l
                                JOIN TB_ESTOQUE e ON e.ID_LOTE = l.ID_LOTE
                                WHERE e.QUANTIDADE > 0
                                  AND l.DATA_VALIDADE >= GETDATE()
                                GROUP BY ID_PRODUTO
                            ) lv ON lv.ID_PRODUTO = l.ID_PRODUTO AND lv.DATA_VENCIMENTO_MIN = l.DATA_VALIDADE
                            ORDER BY p.NOME";

            using(SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
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
                                DataValidadeProduto = leitor.IsDBNull(leitor.GetOrdinal("DATA_VALIDADE")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VALIDADE")),
                                QuantidadeProduto = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE")),
                                IdLote = leitor.IsDBNull(leitor.GetOrdinal("ID_LOTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_LOTE")),
                            });
                        }
                    }
                }
            }

            return produtosEncontrados;
        }

    }
}
