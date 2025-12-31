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

                                WHERE e.QUANTIDADE > 0 AND l.DATA_VALIDADE >= GETDATE() AND p.ATIVO = 1

                            ORDER BY l.DATA_VALIDADE ASC;";

            using(SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
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
                                IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                DataValidade = leitor.IsDBNull(leitor.GetOrdinal("DATA_VALIDADE")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VALIDADE")),
                                IdLote = leitor.IsDBNull(leitor.GetOrdinal("ID_LOTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_LOTE")),
                                NomeProduto = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_NOME")) ? string.Empty : leitor.GetString(leitor.GetOrdinal("PRODUTO_NOME")),
                                PrecoVenda = leitor.IsDBNull(leitor.GetOrdinal("PRECO_VENDA")) ? 0m : leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                Quantidade = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE")),

                            });
                        }
                    }

                    return listaEncontrada;
                }
            }
        }
    
        public bool DiminuirEstoque(FaturaBD.DadosFatura dados, int idFatura)
        {

            var LotesDisponiveis = BuscarTodosLotesDisponiveis();
            var ModificarQuantidade = new List<(int IdLote, int QuantidadeAnterior, int QuantidadeAtual)>();

            foreach (var Item in dados.ItemFaturaEntidade)
            {
                var Lotes = LotesDisponiveis.FindAll(lote => lote.IdProduto == Item.IdProduto);
                var Quantidade = Item.Quantidade;

                foreach(var lote in Lotes)
                {
                    Quantidade = Quantidade - lote.Quantidade;

                    if(Quantidade <= 0)
                    {
                        ModificarQuantidade.Add((IdLote: lote.IdLote, QuantidadeAnterior: lote.Quantidade, QuantidadeAtual: Math.Abs(Quantidade)));
                        break;
                    } 
                    else
                    {
                        ModificarQuantidade.Add((IdLote: lote.IdLote, QuantidadeAnterior: lote.Quantidade, QuantidadeAtual: 0));
                    }
                }
            }

            using(SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
            {
                conexao.Open();

                int IdMovimento = 0;

                using (SqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {

                        string queryAtualizarQuantidade = @"UPDATE TB_ESTOQUE
                                 SET QUANTIDADE = @quantidade
                                 WHERE ID_LOTE = @idLote";


                        foreach (var item in ModificarQuantidade)
                        {
                            using(SqlCommand cmd = new SqlCommand(queryAtualizarQuantidade, conexao, transacao))
                            {
                                cmd.Parameters.AddWithValue("@quantidade", item.QuantidadeAtual);
                                cmd.Parameters.AddWithValue("@idLote", item.IdLote);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        string QueryAssinarMovimento = @"INSERT INTO TB_MOVIMENTO_ESTOQUE
                                                            (ID_FUNCIONARIO, TIPO, ID_FATURA, MOTIVO)
                                                         VALUES
                                                             (@idFuncionario, @tipo, @idFatura, @motivo);
                                                         SELECT SCOPE_IDENTITY();
                                                        ";

                        using (SqlCommand cmd2 = new SqlCommand(QueryAssinarMovimento, conexao, transacao))
                        {
                            cmd2.Parameters.AddWithValue("@idFuncionario", SessaoUsuario.Funcionario.IdFuncionario);
                            cmd2.Parameters.AddWithValue("@tipo", "SAÍDA");
                            cmd2.Parameters.AddWithValue("@idFatura", idFatura);
                            cmd2.Parameters.AddWithValue("@motivo", $"Venda realizada");

                            IdMovimento = Convert.ToInt32(cmd2.ExecuteScalar());
                        }

                        string QueryAssinarDetalhesMovimento = @"INSERT INTO TB_DETALHES_MOVIMENTO_ESTOQUE
                                                            (ID_LOTE, ID_MOVIMENTO, QUANTIDADE_ANTERIOR, QUANTIDADE_ATUAL)
                                                        VALUES
                                                            (@idLote, @idMovimento, @quantidadeAnterior, @quantidadeAtual)
                                                        ";

                        foreach (var item in ModificarQuantidade)
                        {
                            using (SqlCommand cmd3 = new SqlCommand(QueryAssinarDetalhesMovimento, conexao, transacao))
                            {
                                cmd3.Parameters.AddWithValue("@idLote", item.IdLote);
                                cmd3.Parameters.AddWithValue("@idMovimento", IdMovimento);
                                cmd3.Parameters.AddWithValue("@quantidadeAnterior", item.QuantidadeAnterior);
                                cmd3.Parameters.AddWithValue("@quantidadeAtual", item.QuantidadeAtual);

                                cmd3.ExecuteNonQuery();
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

        public bool Devolucao(int idFatura, string motivo)
        {

            var Lotes = new List<(int IdLote, int QuantidadeAnterior, int QuantidadeAtual)>();

            string query = @"SELECT
                              det_mov_e.ID_LOTE,
                              det_mov_e.QUANTIDADE_ANTERIOR,
                              det_mov_e.QUANTIDADE_ATUAL,
                              mov_e.ID_FATURA
                            FROM TB_MOVIMENTO_ESTOQUE mov_e 
                            JOIN TB_DETALHES_MOVIMENTO_ESTOQUE det_mov_e 
                              ON mov_e.ID_MOVIMENTO = det_mov_e.ID_MOVIMENTO
                            WHERE mov_e.ID_FATURA = @idFatura";

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idFatura", idFatura);

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Lotes.Add
                                    ((
                                        IdLote: leitor.IsDBNull(leitor.GetOrdinal("ID_LOTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_LOTE")),
                                        QuantidadeAnterior: leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE_ANTERIOR")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE_ANTERIOR")),
                                        QuantidadeAtual: leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE_ATUAL")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE_ATUAL"))
                                    ));
                            }
                        }
                    }

                    string queryAtualizarLote = @"UPDATE  TB_ESTOQUE
                                                    SET QUANTIDADE = @quantidadeDevolvida
                                                    WHERE ID_LOTE = @idLote
                                                 ";
                    string queryBuscarLote = @"SELECT TOP 1 QUANTIDADE FROM TB_ESTOQUE WHERE ID_LOTE = @idLote;";

                    foreach (var Lote in Lotes)
                    {
                        int QuantidadeAtualEstoque = 0;

                        using (SqlCommand cmd = new SqlCommand(queryBuscarLote, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idLote", Lote.IdLote);

                            using(SqlDataReader leitor = cmd.ExecuteReader())
                            {
                                while (leitor.Read())
                                {
                                    QuantidadeAtualEstoque = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE"));
                                }
                            }
                        }

                        int QuantidadeADevolver = QuantidadeAtualEstoque + Lote.QuantidadeAnterior - Lote.QuantidadeAtual;

                        using (SqlCommand cmd2 = new SqlCommand(queryAtualizarLote, conexao))
                        {
                            cmd2.Parameters.AddWithValue("@quantidadeDevolvida", QuantidadeADevolver);
                            cmd2.Parameters.AddWithValue("@idLote", Lote.IdLote);

                            cmd2.ExecuteNonQuery();
                        }
                    }

                    string QueryAssinarMovimento = @"INSERT INTO TB_MOVIMENTO_ESTOQUE
                                                        (ID_FUNCIONARIO, TIPO, ID_FATURA, MOTIVO)
                                                     VALUES
                                                         (@idFuncionario, @tipo, @idFatura, @motivo)
                                                ";

                    using (SqlCommand cmd3 = new SqlCommand(QueryAssinarMovimento, conexao))
                    {
                        cmd3.Parameters.AddWithValue("@idFuncionario", SessaoUsuario.Funcionario.IdFuncionario);
                        cmd3.Parameters.AddWithValue("@tipo", "DEVOLUÇÃO");
                        cmd3.Parameters.AddWithValue("@idFatura", idFatura);
                        cmd3.Parameters.AddWithValue("@motivo", motivo);

                        cmd3.ExecuteNonQuery();
                    }

                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao devolver a quantidade no estoque: " + ex.Message);
                return false;
            }
        }
    }
}
