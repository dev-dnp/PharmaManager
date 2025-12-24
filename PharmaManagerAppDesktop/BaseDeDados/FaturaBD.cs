using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class FaturaBD
    {

        public class DadosFatura
        {
            public ClienteEntidade ClienteEntidade;
            public FaturaEntidade FaturaEntidade;
            public List<ItemFaturaEntidade> ItemFaturaEntidade;
        }
        public Boolean CriarFatura(DadosFatura dadosFatura)
        {

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    // 1️⃣ Inserir cliente
                    string queryInserirCliente = @"
                        INSERT INTO TB_CLIENTE (NOME, TELEFONE)
                        VALUES (@Nome, @Telefone);
                        SELECT SCOPE_IDENTITY();
                        ";

                    int idCliente;

                    using (SqlCommand cmd = new SqlCommand(queryInserirCliente, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", dadosFatura.ClienteEntidade.Nome);
                        cmd.Parameters.AddWithValue("@Telefone", dadosFatura.ClienteEntidade.Telefone);

                        idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2️⃣ Inserir fatura
                    string queryInserirFatura = @"
                        INSERT INTO TB_FATURA
                            (ID_CLIENTE, ID_FUNCIONARIO, ID_ESTADO_FATURA, ID_METODO_PAGAMENTO)
                        VALUES
                            (@IDCliente, @IDFuncionario, @IDEstadoFatura, @IDMetodoPagamento);
                        SELECT SCOPE_IDENTITY();
                        ";

                    int idFatura;
                   
                    using (SqlCommand cmd = new SqlCommand(queryInserirFatura, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", idCliente);
                        cmd.Parameters.AddWithValue("@IDFuncionario", dadosFatura.FaturaEntidade.IdFuncionario);   // ID do funcionário existente
                        cmd.Parameters.AddWithValue("@IDEstadoFatura", dadosFatura.FaturaEntidade.IdEstadoFatura); // Ex: "Aberta"
                        cmd.Parameters.AddWithValue("@IDMetodoPagamento", dadosFatura.FaturaEntidade.IdMetodoPagamento); // Ex: "Dinheiro"

                        idFatura = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 3️⃣ Inserir itens da fatura
                    string queryInserirItens = @"
                        INSERT INTO TB_ITEM_FATURA
                            (ID_FATURA, ID_LOTE, QUANTIDADE, PRECO_VENDA, DESCONTO)
                        VALUES
                            (@IDFatura, @IDLote, @Quantidade, @PrecoVenda, @Desconto);
                        ";

                    using (SqlCommand cmd = new SqlCommand(queryInserirItens, conexao, transacao))
                    {
                        foreach (var item in dadosFatura.ItemFaturaEntidade)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@IDFatura", idFatura);
                            cmd.Parameters.AddWithValue("@IDLote", item.IdLote);
                            cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@PrecoVenda", item.PrecoVenda);
                            cmd.Parameters.AddWithValue("@Desconto", item.Desconto);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Confirma a transação
                    transacao.Commit();
                    Console.WriteLine("Fatura criada com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    Console.WriteLine("Erro ao criar fatura: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
