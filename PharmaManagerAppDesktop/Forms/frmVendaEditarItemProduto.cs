using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Entidades;
using PharmaManagerAppDesktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmVendaEditarItemProduto : Form
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
        UserControlVendas.ItemProduto Produto;
        List<UserControlVendas.ItemProduto> ListaProdutos;

        public frmVendaEditarItemProduto
        (
            UserControlVendas.ItemProduto itemProduto,
            List<UserControlVendas.ItemProduto> listaProdutos
        )
        {
            InitializeComponent();
            Produto = itemProduto;
            ListaProdutos = listaProdutos;
        }


        private void btnVendaExecutarEditarItemProduto_Click(object sender, EventArgs e)
        {
            ListaProdutos.RemoveAll(item => item.IdProduto == Produto.IdProduto);


            if (_quantidadeProduto <= 0)
            {
                MessageBox.Show("Preencha corretamente todos os campos!");
                return;
            }


            if (_idProduto == 0 || _idLoteProduto == 0) return;

            ListaProdutos.Add(new UserControlVendas.ItemProduto
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

        private void frmVendaEditarItemProduto_Load(object sender, EventArgs e)
        {
            this.txtQuantidade.Text = Produto.Quantidade.ToString();
            this.txtPrecoUnitario.Text = Produto.PrecoUnitario.ToString("C2", new CultureInfo("pt-AO"));
            this.txtSubtotal.Text = Produto.Subtotal.ToString("C2", new CultureInfo("pt-AO"));
            this.txtValorImposto.Text = Produto.ValorTaxaImposto.ToString("C2", new CultureInfo("pt-AO"));
            this.txtNomeProduto.Text = Produto.Nome;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Quantidade = int.Parse(txtQuantidade.Text);

                txtPrecoUnitario.Text = Produto.PrecoUnitario.ToString("C2", new CultureInfo("pt-AO"));


                CalcularSubtotal(Quantidade, Produto.PrecoUnitario);

                _idProduto = Produto.IdProduto;
                _nomeProduto = Produto.Nome;
                _idLoteProduto = Produto.IdLote;
                _quantidadeProduto = Quantidade;
                _precoUnitarioProduto = Produto.PrecoUnitario;
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

            decimal ValorTaxaImposto = (TAXA_IMPOSTO / 100) * (precoUnitarioproduto * quantidadeProduto);

            Subtotal = (quantidadeProduto * precoUnitarioproduto) + ValorTaxaImposto;

            txtValorImposto.Text = ValorTaxaImposto.ToString("C2", new CultureInfo("pt-AO"));
            txtSubtotal.Text = Subtotal.ToString("C2", new CultureInfo("pt-AO"));

            _subtotalProduto = Subtotal;
            _valorTaxaImposto = ValorTaxaImposto;
        }
    }
}
