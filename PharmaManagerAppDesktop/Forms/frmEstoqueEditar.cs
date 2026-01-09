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
using static PharmaManagerAppDesktop.Forms.frmEstoqueAdicionarQuantidade;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmEstoqueEditar : Form
    {
        class ComboBoxValor
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        DetalheProdutoDisponivel DadosEstoque;

        List<ComboBoxValor> FornecedoresRegistados = new List<ComboBoxValor>();
        public frmEstoqueEditar(EstoqueBD.DetalheProdutoDisponivel dados)
        {
            InitializeComponent();

            DadosEstoque = dados;

            var Fornecedores = new FornecedorBD().BuscarTodosFornecedores();


            foreach (var Fornecedor in Fornecedores)
            {
                FornecedoresRegistados.Add(new ComboBoxValor
                {
                    Id = Fornecedor.Fornecedor.IdFornecedor,
                    Nome = Fornecedor.Fornecedor.Nome
                });
            }
        }

        private void frmEstoqueEditar_Load(object sender, EventArgs e)
        {
            txtLote.Text = DadosEstoque.Lote.IdLote.ToString();
            txtNomeProduto.Text = DadosEstoque.Produto.Nome;
            dtpDataValidade.Value = DadosEstoque.Lote.DataValidade;
            txtQuantidade.Text = DadosEstoque.Estoque.Quantidade.ToString();

            cmbFornecedor.ValueMember = "Id";
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.DataSource = FornecedoresRegistados;

            cmbFornecedor.SelectedValue = DadosEstoque.Lote.IdFornecedor;

        }

        private void btnVendaExecutarEditarItemProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int IdProduto = DadosEstoque.Produto.IdProduto;
                int Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                DateTime DataValidade = dtpDataValidade.Value;
                int IdFornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);
                int IdLote = Convert.ToInt32(txtLote.Text.Trim());


                if (cmbFornecedor.SelectedValue == null || string.IsNullOrWhiteSpace(txtQuantidade.Text) || string.IsNullOrWhiteSpace(txtLote.Text) || Quantidade <= 0)
                {
                    MessageBox.Show(
                        "Preencha corretamente todos os campos!",
                        "Mensagem de alerta",
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
