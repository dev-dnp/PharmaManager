using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

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

        public class ItemFatura
        {
            public ItemFaturaEntidade Item { get; set; } = new ItemFaturaEntidade();
            public ProdutoEntidade Produto { get; set; }= new ProdutoEntidade();
            public decimal Subtotal;
            public decimal ValorImposto;
            public decimal TaxaImposto;
        }

        

        public int CriarFatura(DadosFatura dadosFatura)
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
                    return idFatura;
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    Console.WriteLine("Erro ao criar fatura: " + ex.Message);
                    return 0;
                }
            }
        }

        public bool CancelarFatura(int idFatura)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string queryAtualizarLote = @"UPDATE  TB_FATURA
                                                SET ID_ESTADO_FATURA = @idEstado
                                                WHERE ID_FATURA = @idFatura
                                            ";

                    using (SqlCommand cmd = new SqlCommand(queryAtualizarLote, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idEstado", 3);
                        cmd.Parameters.AddWithValue("@idFatura", idFatura);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao editar estado da fatura: " + ex.Message);
                return false;
            }
        }
        public List<DetalhesFatura> BuscarTodasFaturas(string? pesquisa = "")
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
                                    WHERE 
                                        (
                                            fat.ID_FATURA LIKE @pesquisa OR 
                                            fun.NOME LIKE @pesquisa OR 
                                            fun.ID_FUNCIONARIO LIKE @pesquisa OR 
                                            cli.NOME LIKE @pesquisa OR
                                            e_fat.NOME LIKE @pesquisa 
                                        )
  
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
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {

                                TodasFaturas.Add(new DetalhesFatura
                                {
                                    Cliente =
                                {
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CLIENTE_NOME")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("CLIENTE_TELEFONE")),
                                },
                                    Fatura =
                                {
                                    IdFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FATURA")),
                                    TotalPagamento = leitor.IsDBNull(leitor.GetOrdinal("TOTAL_PAGAR")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("TOTAL_PAGAR")),
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    DataVenda = leitor.IsDBNull(leitor.GetOrdinal("DATA_VENDA")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VENDA")),
                                },
                                    EstadoFatura =
                                {
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("ESTADO_FATURA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("ESTADO_FATURA_NOME")),
                                },
                                    MetodoPagamento =
                                {
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("METODO_PAGAMENTO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("METODO_PAGAMENTO_NOME"))
                                },
                                    Funcionario =
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                },
                                    Cargo =
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
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

        public List<ItemFatura> BuscarItensFaturas(int idFatura)
        {
            List<ItemFatura> TodosItens = new List<ItemFatura>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT 
                                  item_f.ID_PRODUTO,
                                  item_f.QUANTIDADE,
                                  item_f.PRECO_VENDA,
                                  item_f.DESCONTO,
                                  item_f.TAXA_IMPOSTO,
                                  ((item_f.QUANTIDADE * item_f.PRECO_VENDA) * (item_f.TAXA_IMPOSTO/100)) AS VALOR_IMPOSTO,
                                  (item_f.QUANTIDADE * item_f.PRECO_VENDA + (item_f.QUANTIDADE * item_f.PRECO_VENDA) * (item_f.TAXA_IMPOSTO/100) - item_f.DESCONTO) AS SUBTOTAL,
  
                                  pdt.NOME AS PRODUTO_NOME,
                                  pdt.PRECO_VENDA AS PRODUTO_PRECO_VENDA,
                                  pdt.CODIGO_BARRAS AS PRODUTO_CODIGO_BARRAS,
                                  pdt.ID_CATEGORIA AS PRODUTO_ID_CATEGORIA,
                                  pdt.DATA_CRIACAO AS PRODUTO_DATA_CRIACAO
  
                                FROM TB_ITEM_FATURA item_f
                                  JOIN TB_PRODUTO pdt 
                                    ON item_f.ID_PRODUTO = pdt.ID_PRODUTO
  
                                WHERE ID_FATURA = @idFatura";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idFatura", idFatura);

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                TodosItens.Add(new ItemFatura
                                {
                                    Item =
                                {
                                    IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                    IdFatura = idFatura,
                                    Quantidade = leitor.IsDBNull(leitor.GetOrdinal("QUANTIDADE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("QUANTIDADE")),
                                    PrecoVenda = leitor.IsDBNull(leitor.GetOrdinal("PRECO_VENDA")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                    Desconto = leitor.IsDBNull(leitor.GetOrdinal("DESCONTO")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("DESCONTO")),
                                },

                                    Produto =
                                {
                                    IdProduto = leitor.IsDBNull(leitor.GetOrdinal("ID_PRODUTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                    IdCategoria = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_ID_CATEGORIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("PRODUTO_ID_CATEGORIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PRODUTO_NOME")),
                                    CodigoBarras = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_CODIGO_BARRAS")) ? null : leitor.GetString(leitor.GetOrdinal("PRODUTO_CODIGO_BARRAS")),
                                    PrecoVenda = leitor.IsDBNull(leitor.GetOrdinal("PRECO_VENDA")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                    DataCriacao = leitor.IsDBNull(leitor.GetOrdinal("PRODUTO_DATA_CRIACAO")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("PRODUTO_DATA_CRIACAO")),
                                },
                                    Subtotal = leitor.IsDBNull(leitor.GetOrdinal("SUBTOTAL")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("SUBTOTAL")),
                                    ValorImposto = leitor.IsDBNull(leitor.GetOrdinal("VALOR_IMPOSTO")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("VALOR_IMPOSTO")),
                                    TaxaImposto = leitor.IsDBNull(leitor.GetOrdinal("TAXA_IMPOSTO")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("TAXA_IMPOSTO")),
                                });

                            }
                        }
                    }
                }

                return TodosItens;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar os itens da fatura: " + ex.Message);
                return null;
            }
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
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CLIENTE_NOME")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("CLIENTE_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("CLIENTE_TELEFONE")),
                                },
                                    Fatura =
                                {
                                    IdFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FATURA")),
                                    TotalPagamento = leitor.IsDBNull(leitor.GetOrdinal("TOTAL_PAGAR")) ? -1 : leitor.GetDecimal(leitor.GetOrdinal("TOTAL_PAGAR")),
                                    IdCliente = leitor.IsDBNull(leitor.GetOrdinal("ID_CLIENTE")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CLIENTE")),
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    DataVenda = leitor.IsDBNull(leitor.GetOrdinal("DATA_VENDA")) ? DateTime.Now : leitor.GetDateTime(leitor.GetOrdinal("DATA_VENDA")),
                                },
                                    EstadoFatura =
                                {
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("ESTADO_FATURA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("ESTADO_FATURA_NOME")),
                                },
                                    MetodoPagamento =
                                {
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("METODO_PAGAMENTO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("METODO_PAGAMENTO_NOME"))
                                },
                                    Funcionario =
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                },
                                    Cargo =
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
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
