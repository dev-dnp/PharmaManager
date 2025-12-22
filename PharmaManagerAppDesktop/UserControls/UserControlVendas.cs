using PharmaManagerAppDesktop.Entidades;
using PharmaManagerAppDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using PharmaManagerAppDesktop.BaseDeDados;

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlVendas : UserControl
    {
        public class ItemProduto
        {
            public int IdProduto { get; set; }
            public int IdLote { get; set; }
            public int Quantidade { get; set; }
            public string Nome { get; set; }
            public decimal PrecoUnitario { get; set; }
            public int TaxaImposto { get; set; }
            public decimal ValorTaxaImposto { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Desconto { get; set; }
        }

        //List
        //    <(
        //        decimal TotalSemImposto, 
        //        decimal Valor, 
        //        float Percentual
        //    )> variavel  = new List();



        public List<ItemProduto> ItensProdutos = new List<ItemProduto>();
        public List<ProdutoDB.DetalhesProduto> ProdutosDisponiveisNoEstoque;
        public Cliente Cliente = new Cliente();
        
        

        public UserControlVendas()
        {
            InitializeComponent();
            
        }

        private void btnFaturaAdicionarItemProduto_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarItemProduto frmAddItemProduto = new frmVendaAdicionarItemProduto(ItensProdutos, ProdutosDisponiveisNoEstoque);
            var resultado = frmAddItemProduto.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                dgvVendaListaProdutos.DataSource = null;

                dgvVendaListaProdutos.DataSource = ItensProdutos;
            }
        }

        private void btnFaturaAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarCliente JanelaAddCliente = new frmVendaAdicionarCliente();

            var retorno = JanelaAddCliente.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                Cliente = JanelaAddCliente.Cliente;

                lblNomeCliente.Text = Cliente.Nome;
                lblTelefoneCliente.Text = Cliente.Telefone;
            }
        }

        private void btnVendaEditarItemProduto_Click(object sender, EventArgs e)
        {
            frmVendaEditarItemProduto janela = new frmVendaEditarItemProduto();
            janela.ShowDialog();
        }

        private void btnVendaFinalizar_Click(object sender, EventArgs e)
        {
            frmVendaResumoVenda janela = new frmVendaResumoVenda();
            
            
        }

        private void UserControlVendas_Load(object sender, EventArgs e)
        {
            colCodProduto.DataPropertyName = "IdProduto";
            colDescontoProduto.DataPropertyName = "Desconto";
            colNomeProduto.DataPropertyName = "Nome";
            colPrecoUnitarioProduto.DataPropertyName = "PrecoUnitario";
            colQuantidadeProduto.DataPropertyName = "Quantidade";
            colSubtotalProduto.DataPropertyName = "Subtotal";
            colTaxaImpostoProduto.DataPropertyName = "TaxaImposto";
            colValorImpostoProduto.DataPropertyName = "ValorTaxaImposto";

            dgvVendaListaProdutos.AutoGenerateColumns = false;

            ProdutosDisponiveisNoEstoque = new ProdutoDB().BuscarProdutosDisponiveis();
        }
    }
}
