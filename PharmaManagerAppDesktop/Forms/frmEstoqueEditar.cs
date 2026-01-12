using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PharmaManagerAppDesktop.BaseDeDados.EstoqueBD;
//using static PharmaManagerAppDesktop.Forms.btnAdicionar;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmEstoqueEditar : Form
    {
        class FornecedorCombobox
        {
            public int IdFornecedor { get; set; }
            public string Nome { get; set; }
        }

        DetalheProdutoDisponivel DadosEstoque;

        List<FornecedorCombobox> FornecedoresRegistados = new List<FornecedorCombobox>();
        public frmEstoqueEditar(EstoqueBD.DetalheProdutoDisponivel dados)
        {
            InitializeComponent();

            DadosEstoque = dados;

            cmbFornecedor.ValueMember = "IdFornecedor";
            cmbFornecedor.DisplayMember = "Nome";
        }

        private void frmEstoqueEditar_Load(object sender, EventArgs e)
        {
            var Fornecedores = new FornecedorBD().BuscarTodosFornecedores();

            foreach (var Fornecedor in Fornecedores)
            {
                FornecedoresRegistados.Add(new FornecedorCombobox
                {
                    IdFornecedor = Fornecedor.Fornecedor.IdFornecedor,
                    Nome = Fornecedor.Fornecedor.Nome
                });
            }

            txtLote.Text = DadosEstoque.Lote.IdLote.ToString();
            txtNomeProduto.Text = DadosEstoque.Produto.Nome;
            dtpDataValidade.Value = DadosEstoque.Lote.DataValidade;
            txtQuantidade.Text = DadosEstoque.Estoque.Quantidade.ToString();


            cmbFornecedor.DataSource = FornecedoresRegistados;
            cmbFornecedor.SelectedValue = DadosEstoque.Lote.IdFornecedor;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdProduto = DadosEstoque.Produto.IdProduto;
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


                var retorno = new EstoqueBD().AtualizarEstoque(new EstoqueBD.DetalheProdutoDisponivel
                {
                    Produto = new Entidades.ProdutoEntidade
                    {
                        IdProduto = IdProduto
                    },
                    Estoque = new Entidades.EstoqueEntidade
                    {
                        IdEstoque = DadosEstoque.Estoque.IdEstoque,
                        Quantidade = Quantidade,
                    },
                    Lote = new Entidades.LoteEntidade
                    {
                        IdLote = IdLote,
                        DataValidade = DataValidade,
                        IdFornecedor = IdFornecedor,
                    },
                    Fornecedor = new Entidades.FornecedorEntidade
                    {
                        Nome = cmbFornecedor.GetItemText(cmbFornecedor.SelectedItem)
                    }

                });

                if (retorno)
                {
                    MessageBox.Show(
                        "Operação realizada com sucesso!",
                        "Mensagem de sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

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
