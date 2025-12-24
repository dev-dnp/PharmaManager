using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    internal class EstoqueBD
    {

        public class DetalhesLotesDisponiveis
        {
            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public int IdLote { get; set; }
            public decimal PrecoVenda { get; set; }
            public int Quantidade { get; set; }
            public DateTime DataValidade { get; set; }
        }



        public List<DetalhesLotesDisponiveis> BuscarTodosLotesDisponiveis()
        {

            var listaEncontrada = new List<DetalhesLotesDisponiveis>();

            string query = @"SELECT 
                                p.ID_PRODUTO,
                                p.NOME AS PRODUTO_NOME,
                                l.ID_LOTE,
                                p.PRECO_VENDA,
                                e.QUANTIDADE,
                                l.DATA_VALIDADE
  
                            FROM TB_PRODUTO p
                            JOIN TB_LOTE l ON l.ID_PRODUTO = p.ID_PRODUTO
                            JOIN TB_ESTOQUE e ON e.ID_LOTE = l.ID_LOTE

                                WHERE e.QUANTIDADE > 0 AND l.DATA_VALIDADE >= GETDATE()

                            ORDER BY l.DATA_VALIDADE ASC;";

            using(SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                using(SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using(SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            listaEncontrada.Add(new DetalhesLotesDisponiveis
                            {
                                IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                DataValidade = leitor.IsDBNull(leitor.GetOrdinal("DATA_VALIDADE")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VALIDADE")),
                                IdLote = leitor.IsDBNull(leitor.GetOrdinal("ID_LOTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_LOTE")),
                                NomeProduto = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_NOME")) ? string.Empty : leitor.GetString(leitor.GetOrdinal("PRODUTO_NOME")),
                                PrecoVenda = leitor.IsDBNull(leitor.GetOrdinal("PRECO_VENDA")) ? 0m : leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                Quantidade = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE")),

                            });
                        }
                    }

                    return listaEncontrada;
                }
            }
        }
    
        public bool DiminuirEstoque(FaturaBD.DadosFatura dados)
        {

            var LotesDisponiveis = BuscarTodosLotesDisponiveis();
            var ModificarQuantidade = new List<(int IdLote, int Quantidade)>();

            foreach (var Item in dados.ItemFaturaEntidade)
            {
                var Lotes = LotesDisponiveis.FindAll(lote => lote.IdProduto == Item.IdProduto);
                var Quantidade = Item.Quantidade;

                foreach(var lote in Lotes)
                {
                    Quantidade = Quantidade - lote.Quantidade;

                    if(Quantidade <= 0)
                    {
                        ModificarQuantidade.Add((IdLote: lote.IdLote, Quantidade: Math.Abs(Quantidade)));
                        break;
                    } 
                    else
                    {
                        ModificarQuantidade.Add((IdLote: lote.IdLote, Quantidade: 0));
                    }
                }
            }

            using(SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = @"UPDATE TB_ESTOQUE
                                 SET QUANTIDADE = @quantidade
                                 WHERE ID_LOTE = @idLote";

                using(SqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        foreach(var item in ModificarQuantidade)
                        {
                            using(SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                            {
                                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                                cmd.Parameters.AddWithValue("@idLote", item.IdLote);

                                cmd.ExecuteNonQuery();
                            }

                        }

                        transacao.Commit();
                        return true;
                    } 
                    catch(Exception ex)
                    {
                        transacao.Rollback();
                        Console.WriteLine("Erro ao diminuir a quantidade na base de dados: " + ex.Message);
                        return false;
                    }
                }
            }

        }
    
    
    }
}
