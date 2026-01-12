using PharmaManagerAppDesktop.BaseDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmEstoqueAdicionar : Form
    {
        public frmEstoqueAdicionar()
        {
            InitializeComponent();
        }

        public class ProdutoDetalhes
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        public class FornecedorDetalhes
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        public List<ProdutoDetalhes> ProdutosRegistados = new List<ProdutoDetalhes>();
        public List<FornecedorDetalhes> FornecedoresRegistados = new List<FornecedorDetalhes>();

        private void frmEstoqueAdicionar_Load(object sender, EventArgs e)
        {
            var Produtos = new ProdutoBD().BuscarProdutos();
            var Fornecedores = new FornecedorBD().BuscarTodosFornecedores();

            foreach (var Produto in Produtos)
            {
                ProdutosRegistados.Add(new ProdutoDetalhes
                {
                    Id = Produto.Produto.IdProduto,
                    Nome = Produto.Produto.Nome,
                });
            }

            foreach (var Fornecedor in Fornecedores)
            {
                FornecedoresRegistados.Add(new FornecedorDetalhes
                {
                    Id = Fornecedor.Fornecedor.IdFornecedor,
                    Nome = Fornecedor.Fornecedor.Nome,
                });
            }

            cmbProdutos.ValueMember = "Id";
            cmbProdutos.DisplayMember = "Nome";

            cmbFornecedor.ValueMember = "Id";
            cmbFornecedor.DisplayMember = "Nome";

            cmbProdutos.DataSource = ProdutosRegistados;
            cmbFornecedor.DataSource = FornecedoresRegistados;

            dtpDataValidade.MinDate = DateTime.Now.AddDays(1);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdProduto = cmbProdutos.SelectedValue != null ? Convert.ToInt32(cmbProdutos.SelectedValue) : 0;
                int IdFornecedor = cmbFornecedor.SelectedValue != null ? Convert.ToInt32(cmbFornecedor.SelectedValue) : 0;
                string QuantidadeTexto = txtQuantidade.Text.Trim();
                string LoteTexto = txtLote.Text.Trim();
                DateTime DataValidade = dtpDataValidade.Value.Date;

                List<string> erros = new List<string>();

                // Produto
                if (IdProduto <= 0)
                    erros.Add("Selecione um produto válido.");

                // Fornecedor
                if (IdFornecedor <= 0)
                    erros.Add("Selecione um fornecedor válido.");

                // Quantidade
                int Quantidade = 0;
                if (string.IsNullOrWhiteSpace(QuantidadeTexto))
                {
                    erros.Add("A quantidade é obrigatória.");
                }
                else if (!int.TryParse(QuantidadeTexto, out Quantidade) || Quantidade <= 0)
                {
                    erros.Add("Informe uma quantidade válida (maior que zero).");
                }

                // Lote
                int IdLote = 0;
                if (string.IsNullOrWhiteSpace(LoteTexto))
                {
                    erros.Add("O número do lote é obrigatório.");
                }
                else if (!int.TryParse(LoteTexto, out IdLote) || IdLote <= 0)
                {
                    erros.Add("Informe um número de lote válido.");
                }

                // Data de validade
                if (DataValidade == default)
                {
                    erros.Add("A data de validade é obrigatória.");
                }
                else if (DataValidade <= DateTime.Today)
                {
                    erros.Add("A data de validade deve ser maior que a data atual.");
                }

                if (erros.Count > 0)
                {
                    string msgErro = string.Join("\n", erros);
                    MessageBox.Show(
                        msgErro,
                        "Erro de validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }


                var AdicionarQuantidadeNoEstoque = new EstoqueBD().AdicionarQuantidadeEstoque(new EstoqueBD.DetalheProdutoDisponivel
                {
                    Produto = new Entidades.ProdutoEntidade
                    {
                        IdProduto = IdProduto
                    },
                    Estoque = new Entidades.EstoqueEntidade
                    {
                        Quantidade = Quantidade,
                    },
                    Lote = new Entidades.LoteEntidade
                    {
                        IdLote = IdLote,
                        DataValidade = DataValidade,
                        IdFornecedor = IdFornecedor,
                    },

                });

                if (AdicionarQuantidadeNoEstoque)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "A operação falhou! Verifique o número de lote, pois não pode ser duplicado. Tente novamente ou contacte o programador!",
                        "Mensagem de erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha corretamente todos os campos com valores válidos!");
                Console.WriteLine("Preenchimento inválido: " + ex.Message);
                return;
            }
        }
    }
}
