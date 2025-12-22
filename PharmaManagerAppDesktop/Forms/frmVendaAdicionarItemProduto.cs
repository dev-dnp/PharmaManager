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

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmVendaAdicionarItemProduto : Form
    {

        // CONSTANTES REUTILIZAVÉIS

        public const decimal TAXA_IMPOSTO = 14;
        public const string MOEDA = " AOA";

        private int _idProduto;
        private int _idLoteProduto;
        private string _nomeProduto;
        private int _quantidadeProduto;
        private decimal _subtotalProduto;
        private decimal _valorTaxaImposto;
        private decimal _precoUnitarioProduto;


        // LISTA DE ITENS DE PRODUTOS ADICIONADOS

        List<UserControlVendas.ItemProduto> Produtos;
        List<ProdutoDB.DetalhesProduto> ProdutosDisponiveisNoEstoque;


        public frmVendaAdicionarItemProduto
        (
            List<UserControlVendas.ItemProduto> listaItensProdutos,
            List<ProdutoDB.DetalhesProduto> listaProdutosDisponiveisNoEstoque
        )
        {
            InitializeComponent();
            Produtos = listaItensProdutos;
            ProdutosDisponiveisNoEstoque = listaProdutosDisponiveisNoEstoque.ToList();
        }

        private void frmAdicionarItemProduto_Load(object sender, EventArgs e)
        {
            cbListaProdutos.Items.Clear();
            cbListaProdutos.DataSource = ProdutosDisponiveisNoEstoque;
            cbListaProdutos.DisplayMember = "NomeProduto";
            cbListaProdutos.ValueMember = "IdLote";
            
            this.RestaurarFormulario();
        }

        private void cbListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Indice = cbListaProdutos.SelectedIndex;
            if (Indice == -1) return;

            // Buscar dados do produto
            var ProdutoSelecionado = ProdutosDisponiveisNoEstoque[Indice];
           
            txtQuantidade.Text = "1";

            try
            {
                int _quantidade= int.Parse(txtQuantidade.Text);

                txtPrecoUnitario.Text = ProdutoSelecionado.PrecoUnitario.ToString() + MOEDA;
                CalcularSubtotal(_quantidade, ProdutoSelecionado.PrecoUnitario);

                _idProduto = ProdutoSelecionado.IdProduto;
                _nomeProduto = ProdutoSelecionado.NomeProduto;
                _idLoteProduto = ProdutoSelecionado.IdLote;
                _quantidadeProduto = _quantidade;
                _precoUnitarioProduto = ProdutoSelecionado.PrecoUnitario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A quantide deve ser um número maior que zero (0)");
                Console.WriteLine("Informação do erro: \n" + ex);
            }
        }

        private void CalcularSubtotal(int quantidadeProduto, decimal precoUnitarioproduto)
        {
            if (txtQuantidade.Text.Trim() == String.Empty) return;

            decimal Subtotal = 0;
            
            decimal ValorTaxaImposto = (TAXA_IMPOSTO/100) * (precoUnitarioproduto * quantidadeProduto);

            Subtotal = (quantidadeProduto * precoUnitarioproduto) + ValorTaxaImposto;

            txtValorImposto.Text = ValorTaxaImposto.ToString("N2") + MOEDA;
            txtSubtotal.Text = Subtotal.ToString("N2") + MOEDA;

            _subtotalProduto = Subtotal;
            _valorTaxaImposto = ValorTaxaImposto;
        }

        private void RestaurarFormulario()
        {
            this.txtCodigoProduto.Clear();
            this.txtQuantidade.Text = "1";
            this.txtPrecoUnitario.Clear();
            this.txtSubtotal.Clear();
            this.txtValorImposto.Clear();
            this.cbListaProdutos.SelectedIndex = -1;

            _idLoteProduto = 0;
            _idProduto = 0;
            _nomeProduto = null;
            _precoUnitarioProduto = 0;
            _quantidadeProduto = 0;
            _subtotalProduto = 0;
            _valorTaxaImposto = 0;
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int _Indice = cbListaProdutos.SelectedIndex;
            if (_Indice == -1) return;

            // Buscar dados do produto
            var ProdutoSelecionado = ProdutosDisponiveisNoEstoque[_Indice];

            try
            {
                int _quantidade = int.Parse(txtQuantidade.Text);

                txtPrecoUnitario.Text = ProdutoSelecionado.PrecoUnitario.ToString() + MOEDA;
                CalcularSubtotal(_quantidade, ProdutoSelecionado.PrecoUnitario);

                _idProduto = ProdutoSelecionado.IdProduto;
                _nomeProduto = ProdutoSelecionado.NomeProduto;
                _idLoteProduto = ProdutoSelecionado.IdLote;
                _quantidadeProduto = _quantidade;
                _precoUnitarioProduto = ProdutoSelecionado.PrecoUnitario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A quantide deve ser um número maior que zero (0)");
                Console.WriteLine("Informação do erro: \n" + ex);
            }

        }

        private void btnPesquisarPorCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoProduto.Text.Trim());

                if (codigo <= 0) throw new Exception();

                var produtoEncontrado = ProdutosDisponiveisNoEstoque.Where(p => p.IdProduto == codigo).ToList();

                if(produtoEncontrado.Count > 0)
                {
                    txtPrecoUnitario.Text = produtoEncontrado[0].PrecoUnitario.ToString() + MOEDA;
                    cbListaProdutos.SelectedValue = produtoEncontrado[0].IdLote;
                    txtQuantidade.Text = "1";
                    CalcularSubtotal(1, produtoEncontrado[0].PrecoUnitario);
                }
                else
                {
                    MessageBox.Show("Código não encontrado!");
                    RestaurarFormulario();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Código inválido! Use um número maior que zero.");
                Console.WriteLine("Informação do erro: \n" + ex);
            }

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {

            Console.WriteLine("_idProduto: " + _idProduto);
            Console.WriteLine("_nomeProduto: " + _nomeProduto);
            Console.WriteLine("_precoUnitarioProduto: " + _precoUnitarioProduto);
            Console.WriteLine("_subtotalProduto: " + _subtotalProduto);
            Console.WriteLine("_quantidadeProduto: " + _quantidadeProduto);
            Console.WriteLine("_valorTaxaImposto: " + _valorTaxaImposto);
            Console.WriteLine("_idLoteProduto: " + _idLoteProduto);

            bool todasPreenchidas = _idProduto > 0 &&
                                    !string.IsNullOrEmpty(_nomeProduto) &&
                                    _precoUnitarioProduto > 0 &&
                                    _subtotalProduto > 0 &&
                                    _quantidadeProduto > 0 &&
                                    _valorTaxaImposto >= 0 &&
                                    _idLoteProduto > 0;

            if(todasPreenchidas == false)
            {
                MessageBox.Show("Preencha corretamente todos os campos!");
                return;
            }

            var ProdutoExistente = Produtos.Where(p => p.IdLote == _idLoteProduto);

            if(ProdutoExistente.Count() > 0)
            {
                MessageBox.Show("Este produto já foi registado na fatura!");
                return;
            }

            if (_idProduto == 0 || _idLoteProduto == 0) return;

            Produtos.Add( new UserControlVendas.ItemProduto
            {
                IdProduto = _idProduto,
                Nome = _nomeProduto,
                Desconto = 0,
                PrecoUnitario = _precoUnitarioProduto,
                Subtotal = _subtotalProduto,
                Quantidade = _quantidadeProduto,
                TaxaImposto = 14,
                ValorTaxaImposto = _valorTaxaImposto,
                IdLote = _idLoteProduto,

            });

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
