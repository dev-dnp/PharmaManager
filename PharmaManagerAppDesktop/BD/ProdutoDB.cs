using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BD
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public string CodigoBarras;
        public decimal PrecoVenda;
        public int IdCategoria;
    }

    public class Estoque
    {
        public int Id;
        public int IdLote;
        public int Quantidade;
    }

    public class Lote
    {
        public int Id;
        public int IdProduto;
        public int IdFornecedor;
        public decimal PrecoCompra;
    }

    public class ProdutoInfo
    {
        public Produto Produto;
        public Estoque Estoque;
        public Lote Lote;
    }

    internal class ProdutoDB
    {

        public List<Produto> BuscarProdutoDisponiveis()
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                string query = "SELECT DISTINCT  p.ID_PRODUTO,  p.NOME, p.PRECO_VENDA, p.CODIGO_BARRAS, p.ID_CATEGORIA  FROM TB_PRODUTO p INNER JOIN TB_LOTE l ON l.ID_PRODUTO = p.ID_PRODUTO INNER JOIN TB_ESTOQUE es ON es.ID_LOTE = l.ID_LOTE WHERE es.QUANTIDADE > 0 ORDER BY p.NOME";

                using (SqlConnection conn = ConexaoBD.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Produto produtoEncontrado = new Produto
                                {
                                    Id = leitor.GetInt32(leitor.GetOrdinal("ID_PRODUTO")),
                                    Nome = leitor.GetString(leitor.GetOrdinal("NOME")),
                                    PrecoVenda = leitor.GetDecimal(leitor.GetOrdinal("PRECO_VENDA")),
                                    CodigoBarras = leitor.GetString(leitor.GetOrdinal("CODIGO_BARRAS")),
                                    IdCategoria = leitor.GetInt32(leitor.GetOrdinal("ID_CATEGORIA")),
                                };
                                
                                produtos.Add(produtoEncontrado);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return produtos;
        }


    }
}
