using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlEstoque : UserControl
    {

        public class VisualizacaoTabela
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Lote { get; set; }
            public DateTime Validade { get; set; }  
            public int Quantidade { get; set; }
            public string Fornecedor { get; set; }

        }

        public List<VisualizacaoTabela> DadosTabela = new List<VisualizacaoTabela>();
        public UserControlEstoque()
        {
            InitializeComponent();
        }

        

        private void UserControlEstoque_Load(object sender, EventArgs e)
        {
            var ProdutoDisponiveis = new EstoqueBD().BuscarProdutosDisponiveis();

            foreach(var ProdutoDisponivel in ProdutoDisponiveis)
            {
                DadosTabela.Add(new VisualizacaoTabela
                {
                    Id = ProdutoDisponivel.Estoque.IdEstoque,
                    Lote = ProdutoDisponivel.Lote.IdLote,
                    Nome = ProdutoDisponivel.Produto.Nome,
                    Quantidade = ProdutoDisponivel.Estoque.Quantidade,
                    Validade = ProdutoDisponivel.Lote.DataValidade,
                    Fornecedor = ProdutoDisponivel.Fornecedor.Nome
                });
            }

            dgvListaEstoque.AutoGenerateColumns = false;

            colId.DataPropertyName = "Id";
            colProduto.DataPropertyName = "Nome";
            colLote.DataPropertyName = "Lote";
            colQuantidade.DataPropertyName = "Quantidade";
            colValidade.DataPropertyName = "Validade";
            colFornecedor.DataPropertyName = "Fornecedor";

            dgvListaEstoque.DataSource = null;
            dgvListaEstoque.DataSource = DadosTabela;

        }

        private void Atualizar()
        {
            var Pesquisa = txtCampoPesquisa.Text.Trim();
            
            DadosTabela.Clear();

            var ProdutoDisponiveis = new EstoqueBD().BuscarProdutosDisponiveis(Pesquisa);

            foreach (var ProdutoDisponivel in ProdutoDisponiveis)
            {
                DadosTabela.Add(new VisualizacaoTabela
                {
                    Id = ProdutoDisponivel.Estoque.IdEstoque,
                    Lote = ProdutoDisponivel.Lote.IdLote,
                    Nome = ProdutoDisponivel.Produto.Nome,
                    Quantidade = ProdutoDisponivel.Estoque.Quantidade,
                    Validade = ProdutoDisponivel.Lote.DataValidade,
                    Fornecedor = ProdutoDisponivel.Fornecedor.Nome
                });
            }

            dgvListaEstoque.DataSource = null;
            dgvListaEstoque.DataSource = DadosTabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtCampoPesquisa.Clear();
            Atualizar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmEstoqueAdicionarQuantidade frm = new frmEstoqueAdicionarQuantidade();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Adicionado com sucesso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Atualizar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<int> Ids = new List<int>();

            foreach (DataGridViewRow linha in dgvListaEstoque.Rows)
            {
                if (Convert.ToBoolean(linha.Cells["check"].Value))
                {
                    Ids.Add(Convert.ToInt32(linha.Cells["colId"].Value));
                }
            }

            if (Ids.Count == 1)
            {
                var ProdutoDisponiveis = new EstoqueBD().BuscarProdutosDisponiveis();

                var Detalhes = ProdutoDisponiveis.Find(e => e.Estoque.IdEstoque == Ids.First());

                frmEstoqueEditar frm = new frmEstoqueEditar(Detalhes);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Atualizar();
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item por vez",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
