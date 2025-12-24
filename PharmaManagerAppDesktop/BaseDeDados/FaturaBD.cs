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

        public class DetalhesFatura
        {
            public FaturaEntidade Fatura { get; set; } = new FaturaEntidade();
            public FuncionarioEntidade Funcionario { get; set; } = new FuncionarioEntidade();
            public ClienteEntidade Cliente { get; set; } = new ClienteEntidade();
            public EstadoFaturaEntidade EstadoFatura { get; set; } = new EstadoFaturaEntidade();
            public MetodoPagamentoEntidade MetodoPagamento { get; set; } = new MetodoPagamentoEntidade();
            public CargoEntidade Cargo {  get; set; } = new CargoEntidade();
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
                            (ID_FATURA, ID_PRODUTO, QUANTIDADE, PRECO_VENDA, DESCONTO)
                        VALUES
                            (@IDFatura, @IDProduto, @Quantidade, @PrecoVenda, @Desconto);
                        ";

                    using (SqlCommand cmd = new SqlCommand(queryInserirItens, conexao, transacao))
                    {
                        foreach (var item in dadosFatura.ItemFaturaEntidade)
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@IDFatura", idFatura);
                            cmd.Parameters.AddWithValue("@IDProduto", item.IdProduto);
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

        public List<DetalhesFatura> BuscarTodasFaturas()
        {

            var TodasFaturas = new List<DetalhesFatura>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT 
                                        fat.ID_FATURA,
                                        fat.DATA_VENDA,
                                        fat.ID_CLIENTE,
                                        fat.ID_ESTADO_FATURA, 
                                        fat.ID_FUNCIONARIO,
                                        fat.ID_METODO_PAGAMENTO, 
  
                                        cli.NOME AS CLIENTE_NOME,
                                        cli.TELEFONE AS CLIENTE_TELEFONE,

                                        fun.NOME AS FUNCIONARIO_NOME,
                                        fun.ID_CARGO,
                                        fun.BILHETE_IDENTIDADE AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                        fun.EMAIL AS FUNCIONARIO_EMAIL,
                                        fun.TELEFONE AS FUNCIONARIO_TELEFONE,

                                        crg.NOME AS CARGO_NOME,
  
                                        e_fat.NOME AS ESTADO_FATURA_NOME,
                                        m_pag.NOME AS METODO_PAGAMENTO_NOME,
                                        SUM((i_fat.QUANTIDADE * i_fat.PRECO_VENDA) + (i_fat.QUANTIDADE * i_fat.PRECO_VENDA)*(i_fat.TAXA_IMPOSTO/100)  - i_fat.DESCONTO) AS TOTAL_PAGAR

                                    FROM TB_FATURA fat
                                    JOIN TB_CLIENTE cli
                                        ON fat.ID_CLIENTE = cli.ID_CLIENTE
                                    JOIN TB_FUNCIONARIO fun
                                        ON fat.ID_FUNCIONARIO = fun.ID_FUNCIONARIO
                                    JOIN TB_CARGO crg
                                        ON fun.ID_CARGO = crg.ID_CARGO
                                    JOIN TB_ESTADO_FATURA e_fat
                                        ON fat.ID_ESTADO_FATURA = e_fat.ID_ESTADO_FATURA
                                    JOIN TB_METODO_PAGAMENTO m_pag 
                                        ON fat.ID_METODO_PAGAMENTO = m_pag.ID_METODO_PAGAMENTO
                                    JOIN TB_ITEM_FATURA i_fat
                                        ON i_fat.ID_FATURA = fat.ID_FATURA

  
                                    GROUP BY 
                                        fat.ID_FATURA,
                                        fat.DATA_VENDA,
                                        fat.ID_CLIENTE,
                                        fat.ID_ESTADO_FATURA, 
                                        fat.ID_FUNCIONARIO,
                                        fat.ID_METODO_PAGAMENTO, 
                                        cli.NOME,
                                        cli.TELEFONE,
                                        fun.NOME,
                                        fun.ID_CARGO,
                                        fun.BILHETE_IDENTIDADE,
                                        fun.EMAIL,
                                        fun.TELEFONE,
                                        crg.NOME,
                                        e_fat.NOME,
                                        m_pag.NOME

                                    ORDER BY fat.DATA_VENDA DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {

                                TodasFaturas.Add(new DetalhesFatura
                                {
                                    Cliente =
                                {
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("CLIENTE_NOME")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_TELEFONE")) ? "-" : leitor.GetString(leitor.GetOrdinal("CLIENTE_TELEFONE")),
                                },
                                    Fatura =
                                {
                                    IdFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FATURA")),
                                    TotalPagamento = leitor.IsDBNull(leitor.GetOrdinal("TOTAL_PAGAR")) ? 0 : leitor.GetDecimal(leitor.GetOrdinal("TOTAL_PAGAR")),
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    DataVenda = leitor.IsDBNull(leitor.GetOrdinal("DATA_VENDA")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VENDA")),
                                },
                                    EstadoFatura =
                                {
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("ESTADO_FATURA_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("ESTADO_FATURA_NOME")),
                                },
                                    MetodoPagamento =
                                {
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("METODO_PAGAMENTO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("METODO_PAGAMENTO_NOME"))
                                },
                                    Funcionario =
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                },
                                    Cargo =
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                }

                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro ao acessar o banco: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            return TodasFaturas;

        }


        public List<DetalhesFatura> BuscarTodasFaturasPorTextoDePesquisa(string textoDePesquisa)
        {

            var TodasFaturas = new List<DetalhesFatura>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT 
  
                                      fat.ID_FATURA,
                                      fat.DATA_VENDA,
                                      fat.ID_CLIENTE,
                                      fat.ID_ESTADO_FATURA, 
                                      fat.ID_FUNCIONARIO,
                                      fat.ID_METODO_PAGAMENTO, 
  
                                      cli.NOME AS CLIENTE_NOME,
                                      cli.TELEFONE AS CLIENTE_TELEFONE,

                                      fun.NOME AS FUNCIONARIO_NOME,
                                      fun.ID_CARGO,
                                      fun.BILHETE_IDENTIDADE AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                      fun.EMAIL AS FUNCIONARIO_EMAIL,
                                      fun.TELEFONE AS FUNCIONARIO_TELEFONE,

                                      crg.NOME AS CARGO_NOME,
  
                                      e_fat.NOME AS ESTADO_FATURA_NOME,
                                      m_pag.NOME AS METODO_PAGAMENTO_NOME,
                                      SUM((i_fat.QUANTIDADE * i_fat.PRECO_VENDA) + (i_fat.QUANTIDADE * i_fat.PRECO_VENDA)*(i_fat.TAXA_IMPOSTO/100)  - i_fat.DESCONTO) AS TOTAL_PAGAR

                                    FROM TB_FATURA fat
                                    JOIN TB_CLIENTE cli
                                      ON fat.ID_CLIENTE = cli.ID_CLIENTE
                                    JOIN TB_FUNCIONARIO fun
                                      ON fat.ID_FUNCIONARIO = fun.ID_FUNCIONARIO
                                    JOIN TB_CARGO crg
                                      ON fun.ID_CARGO = crg.ID_CARGO
                                    JOIN TB_ESTADO_FATURA e_fat
                                      ON fat.ID_ESTADO_FATURA = e_fat.ID_ESTADO_FATURA
                                    JOIN TB_METODO_PAGAMENTO m_pag 
                                      ON fat.ID_METODO_PAGAMENTO = m_pag.ID_METODO_PAGAMENTO
                                    JOIN TB_ITEM_FATURA i_fat
                                      ON i_fat.ID_FATURA = fat.ID_FATURA
                                    WHERE (fat.ID_FATURA LIKE @idFatura OR fun.NOME LIKE @nomeFuncionario OR fun.ID_FUNCIONARIO LIKE @idFuncionario OR cli.NOME LIKE @nomeCliente OR e_fat.NOME LIKE @estadoFatura)
  
                                    GROUP BY 
                                      fat.ID_FATURA,
                                      fat.DATA_VENDA,
                                      fat.ID_CLIENTE,
                                      fat.ID_ESTADO_FATURA, 
                                      fat.ID_FUNCIONARIO,
                                      fat.ID_METODO_PAGAMENTO, 
                                      cli.NOME,
                                      cli.TELEFONE,
                                      fun.NOME,
                                      fun.ID_CARGO,
                                      fun.BILHETE_IDENTIDADE,
                                      fun.EMAIL,
                                      fun.TELEFONE,
                                      crg.NOME,
                                      e_fat.NOME,
                                      m_pag.NOME

                                    ORDER BY fat.DATA_VENDA DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idFatura", "%" + textoDePesquisa + "%");
                        cmd.Parameters.AddWithValue("@nomeFuncionario", "%" + textoDePesquisa + "%");
                        cmd.Parameters.AddWithValue("@idFuncionario", "%" + textoDePesquisa + "%");
                        cmd.Parameters.AddWithValue("@nomeCliente", "%" + textoDePesquisa + "%");
                        cmd.Parameters.AddWithValue("@estadoFatura", "%" + textoDePesquisa + "%");
                        
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {

                                TodasFaturas.Add(new DetalhesFatura
                                {
                                    Cliente =
                                {
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("CLIENTE_NOME")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_TELEFONE")) ? "-" : leitor.GetString(leitor.GetOrdinal("CLIENTE_TELEFONE")),
                                },
                                    Fatura =
                                {
                                    IdFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FATURA")),
                                    TotalPagamento = leitor.IsDBNull(leitor.GetOrdinal("TOTAL_PAGAR")) ? 0 : leitor.GetDecimal(leitor.GetOrdinal("TOTAL_PAGAR")),
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    DataVenda = leitor.IsDBNull(leitor.GetOrdinal("DATA_VENDA")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VENDA")),
                                },
                                    EstadoFatura =
                                {
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("ESTADO_FATURA_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("ESTADO_FATURA_NOME")),
                                },
                                    MetodoPagamento =
                                {
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("METODO_PAGAMENTO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("METODO_PAGAMENTO_NOME"))
                                },
                                    Funcionario =
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? "-" : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                },
                                    Cargo =
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                }

                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro ao acessar o banco: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            return TodasFaturas;

        }

    }
}
