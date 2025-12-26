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
    public partial class UserControlProdutos : UserControl
    {

        public class VisualizarProdutoTabela
        {
            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public string NomeCategoria { get; set; }
            public decimal PrecoProduto { get; set; }
            public string QuantidadeTotalProduto { get; set; }

        }

        public List<VisualizarProdutoTabela> DadosTabela = new List<VisualizarProdutoTabela>();
        public UserControlProdutos()
        {
            InitializeComponent();
        }

        private void btnProdutoNovo_Click(object sender, EventArgs e)
        {
            frmProdutoAdicionarProduto janela = new frmProdutoAdicionarProduto();
            var retorno = janela.ShowDialog();

            if(retorno == DialogResult.OK)
            {
                Atualizar();
            }
        }

        private void UserControlProdutos_Load(object sender, EventArgs e)
        {
            DadosReferencia.BuscarCategoriasProdutos();

            var Produtos = new ProdutoBD().BuscarProdutos();

            if( Produtos == null )
            {
                return;
            }

            foreach(var Produto in Produtos )
            {
                DadosTabela.Add(new VisualizarProdutoTabela
                {
                    IdProduto = Produto.Produto.IdProduto,
                    NomeProduto = Produto.Produto.Nome,
                    NomeCategoria = Produto.Categoria.Nome,
                    PrecoProduto = Produto.Produto.PrecoVenda,
                    QuantidadeTotalProduto = (Produto.QuantidadeTotal < 0 ? "-" : Produto.QuantidadeTotal.ToString()),
                });
            }

            dgvListaProdutos.Rows.Clear();
            dgvListaProdutos.AutoGenerateColumns = false;

            colIdProduto.DataPropertyName = "IdProduto";
            colNomeProduto.DataPropertyName = "NomeProduto";
            colCategoriaProduto.DataPropertyName = "NomeCategoria";
            colPrecoProduto.DataPropertyName = "PrecoProduto";
            colQuantidadeProduto.DataPropertyName = "QuantidadeTotalProduto";

            dgvListaProdutos.DataSource = DadosTabela;

        }

        private void Atualizar()
        {
            DadosTabela = new List<VisualizarProdutoTabela>();

            var Produtos = new ProdutoBD().BuscarProdutos();

            if (Produtos == null)
            {
                return;
            }

            foreach (var Produto in Produtos)
            {
                DadosTabela.Add(new VisualizarProdutoTabela
                {
                    IdProduto = Produto.Produto.IdProduto,
                    NomeProduto = Produto.Produto.Nome,
                    NomeCategoria = Produto.Categoria.Nome,
                    PrecoProduto = Produto.Produto.PrecoVenda,
                    QuantidadeTotalProduto = (Produto.QuantidadeTotal < 0 ? "-" : Produto.QuantidadeTotal.ToString()),
                });
            }

            dgvListaProdutos.DataSource = null;
            dgvListaProdutos.DataSource = DadosTabela;
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvListaProdutos.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colIdProduto"].Value));
                }
            }

            if (IdsSelecionados.Count == 1)
            {
                var Produtos = new ProdutoBD().BuscarProdutos();

                var ProdutoSelecionado = Produtos.Find(p => p.Produto.IdProduto == IdsSelecionados.First());

                frmProdutoEditarProduto janela = new frmProdutoEditarProduto(ProdutoSelecionado.Produto);

                if (janela.ShowDialog() == DialogResult.OK)
                {
                    Atualizar();
                    MessageBox.Show("Operação realizada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show(
                    "Selecione um item por vez",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            return;

        }

        private void btnEliminarProdutos_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvListaProdutos.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colIdProduto"].Value));
                }
            }

            if (IdsSelecionados.Count != 0)
            {
                var Opcao = MessageBox.Show(
                    "Tem certeza que quer eliminar os produtos selecionados",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                 );

                if (Opcao == DialogResult.No) return;

                bool Retorno = new ProdutoBD().EliminarProduto(IdsSelecionados);

                if (Retorno)
                {
                    Atualizar();
                    MessageBox.Show("Operação realizada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Ocorreu um erro interno! Tente novamente ou contacte o programador.", 
                        "Mensagem de erro", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );

                    Atualizar();
                    return;
                }
            }

            MessageBox.Show(
                    "Selecione pelo menos um item",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
            return;
        }
    }
}
