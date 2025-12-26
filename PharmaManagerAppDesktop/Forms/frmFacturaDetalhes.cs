using PharmaManagerAppDesktop.BaseDeDados;
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
using static PharmaManagerAppDesktop.UserControls.UserControlVendas;

namespace PharmaManagerAppDesktop.Forms
{

    public partial class frmFacturaDetalhes : Form
    {
        public class ItemProduto
        {
            public int IdProduto { get; set; }
            public int Quantidade { get; set; }
            public string Nome { get; set; }
            public decimal PrecoUnitario { get; set; }
            public decimal TaxaImposto { get; set; }
            public decimal ValorTaxaImposto { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Desconto { get; set; }
        }

        public List<FaturaBD.ItemFatura> Itens;
        public FaturaBD.DetalhesFatura DetalhesFaturaAtual;
        public int IdFatura;
        public List<ItemProduto> ItemProdutoTabela;
        public frmFacturaDetalhes(int idFatura, FaturaBD.DetalhesFatura detalhesFaturaAtual)
        {
            InitializeComponent();
            IdFatura = idFatura;
            DetalhesFaturaAtual = detalhesFaturaAtual;
        }

        private void btnFecharDetalhesFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturaDetalhes_Load(object sender, EventArgs e)
        {
            Itens = new FaturaBD().BuscarItensFaturas(IdFatura);

            if(Itens == null)
            {
                return;
            }

            ItemProdutoTabela = new List<ItemProduto>();
            dgvListaDetalhesItens.DataSource = null;


            foreach (var Item in  Itens)
            {
                ItemProdutoTabela.Add(new ItemProduto
                {
                    IdProduto = Item.Produto.IdProduto,
                    Nome = Item.Produto.Nome,
                    Quantidade = Item.Item.Quantidade,
                    PrecoUnitario = Item.Item.PrecoVenda,
                    TaxaImposto = Item.TaxaImposto,
                    Desconto = Item.Item.Desconto,
                    ValorTaxaImposto = Item.ValorImposto,
                    Subtotal = Item.Subtotal
                });
            }

            colCodProduto.DataPropertyName = "IdProduto";
            colDescontoProduto.DataPropertyName = "Desconto";
            colNomeProduto.DataPropertyName = "Nome";
            colPrecoUnitarioProduto.DataPropertyName = "PrecoUnitario";
            colQuantidadeProduto.DataPropertyName = "Quantidade";
            colSubtotalProduto.DataPropertyName = "Subtotal";
            colTaxaImpostoProduto.DataPropertyName = "TaxaImposto";
            colValorImpostoProduto.DataPropertyName = "ValorTaxaImposto";

            dgvListaDetalhesItens.AutoGenerateColumns = false;
            dgvListaDetalhesItens.DataSource = ItemProdutoTabela;

            lblNomeCliente.Text = DetalhesFaturaAtual.Cliente.Nome;
            lblTelefoneCliente.Text = DetalhesFaturaAtual.Cliente.Telefone;
            lblEstadoFatura.Text = DetalhesFaturaAtual.EstadoFatura.Nome;


            if (DetalhesFaturaAtual.Fatura.IdEstadoFatura == 1)
                lblEstadoFatura.BackColor = System.Drawing.Color.FromArgb(40, 42, 54);
            else if (DetalhesFaturaAtual.Fatura.IdEstadoFatura == 2)
                lblEstadoFatura.BackColor = System.Drawing.Color.FromArgb(0, 202, 146);
            else
                lblEstadoFatura.BackColor = System.Drawing.Color.FromArgb(255, 98, 88);

            CalcularResumoFinanceiro(); 
        }

        private void CalcularResumoFinanceiro()
        {
            decimal TotalSemDescontosEImpostos = 0;
            decimal TotalDescontos = 0;
            decimal ValorDoImposto = 0;
            decimal TotalPagar = 0;

            if (Itens != null)
            {
                foreach (var Item in Itens)
                {
                    TotalSemDescontosEImpostos += (Item.Item.Quantidade * Item.Item.PrecoVenda);
                    TotalDescontos += Item.Item.Desconto;
                    ValorDoImposto += Item.ValorImposto;
                }
            }


            TotalPagar = TotalSemDescontosEImpostos + ValorDoImposto - TotalDescontos;

            lblVendaValorImposto.Text = ValorDoImposto.ToString("C2", new CultureInfo("pt-AO"));
            lblVendaTotalDesconto.Text = TotalDescontos.ToString("C2", new CultureInfo("pt-AO"));
            lblVendaTotalSemDescontosEImpostos.Text = TotalSemDescontosEImpostos.ToString("C2", new CultureInfo("pt-AO"));
            lblVendaTotalPagar.Text = TotalPagar.ToString("C2", new CultureInfo("pt-AO"));

            
        }
    }
}
