using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Entidades;
using PharmaManagerAppDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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

        public class ResumoFinanceiro
        {
            public decimal TotalSemDescontosEImpostos { get; set; }
            public decimal TotalDescontos { get; set; }
            public decimal TotalValorDeImposto { get; set; }
            public decimal TotalPagar { get; set; }
        }



        public List<ItemProduto> ItensProdutos = new List<ItemProduto>();
        public ClienteEntidade Cliente = new ClienteEntidade();
        public List<ProdutoBD.DetalhesProduto> ProdutosDisponiveisNoEstoque;
        public ResumoFinanceiro Resumo;

        
        

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
                this.CalcularResumoFinanceiro();
            }
        }

        private void btnFaturaAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarCliente JanelaAddCliente = new frmVendaAdicionarCliente(Cliente);

            var retorno = JanelaAddCliente.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                lblNomeCliente.Text = Cliente.Nome;
                lblTelefoneCliente.Text = Cliente.Telefone;
            }
        }

        private void btnVendaEditarItemProduto_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvVendaListaProdutos.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["checkItemProduto"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colCodProduto"].Value));
                }
            }

            if(IdsSelecionados.Count == 1)
            {
                var ItemSelecionado = ItensProdutos.Find(item => item.IdProduto == IdsSelecionados.First());

                frmVendaEditarItemProduto janela = new frmVendaEditarItemProduto(ItemSelecionado, ItensProdutos);
                
                var resultado = janela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    dgvVendaListaProdutos.DataSource = null;
                    dgvVendaListaProdutos.DataSource = ItensProdutos;
                    this.CalcularResumoFinanceiro();
                    return;
                }
            }

            MessageBox.Show(
                "Selecione apenas uma linha por vez",
                "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void btnVendaFinalizar_Click(object sender, EventArgs e)
        {

            if(Cliente == null || Resumo == null || ItensProdutos.Count == 0)
            {

                MessageBox.Show(
                    "Certifique-se de que o cliente exista ou se os produtos já foram adicionados a lista",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            frmVendaResumoVenda janela = new frmVendaResumoVenda(this);
           
            var retorno = janela.ShowDialog();
            
            if(retorno == DialogResult.OK)
            {
                int IdMetodoPagamento = janela.MetodoPagamento.IdMetodoPagamento;
                var ItemFatura = new List<ItemFaturaEntidade>();

                foreach(var Item in ItensProdutos)
                {
                    ItemFatura.Add(new ItemFaturaEntidade
                    {
                        Desconto = Item.Desconto,
                        IdLote = Item.IdLote,
                        PrecoVenda = Item.PrecoUnitario,
                        Quantidade = Item.Quantidade,
                    });
                }

                if(Cliente != null)
                {
                    Cliente.Nome = Cliente.Nome ?? "-";
                    Cliente.Telefone = Cliente.Telefone ?? "-";
                }

                var Dados = new FaturaBD.DadosFatura
                {
                    ClienteEntidade = Cliente,
                    FaturaEntidade = new FaturaEntidade
                    {
                        DataVenda = DateTime.Now,
                        IdFuncionario = SessaoUsuario.Funcionario.IdFuncionario,
                        IdMetodoPagamento = IdMetodoPagamento,
                        IdEstadoFatura = 2, // Paga, de acordo com a base de dados,
                    },
                    ItemFaturaEntidade = ItemFatura

                };

                FaturaBD Fatura = new FaturaBD();
                
                bool resultado = Fatura.CriarFatura(Dados);

                if(resultado)
                {
                    MessageBox.Show(
                        "Operação realizada com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ItensProdutos = new List<ItemProduto>();
                    Cliente = new ClienteEntidade();
                    Resumo = new ResumoFinanceiro();
                    CalcularResumoFinanceiro();
                    dgvVendaListaProdutos.DataSource = null;

                    lblNomeCliente.Text = "(Nenhum)";
                    lblTelefoneCliente.Text = "(Nenhum)";

                }
                else
                {
                    MessageBox.Show(
                        "Falha! Ocorreu uma falha ao processar a fatura. Por favor, tente novamente ou contacte o programador!",
                        "Mensagem de erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            
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

            ProdutosDisponiveisNoEstoque = new ProdutoBD().BuscarProdutosDisponiveis();
        }

        private void CalcularResumoFinanceiro()
        {
            decimal TotalSemDescontosEImpostos = 0;
            decimal TotalDescontos = 0;
            decimal ValorDoImposto = 0;
            decimal TotalPagar = 0;

            if(ItensProdutos != null)
            {
                foreach(var Item in ItensProdutos)
                {
                    TotalSemDescontosEImpostos += (Item.Quantidade * Item.PrecoUnitario);
                    TotalDescontos += Item.Desconto;
                    ValorDoImposto += Item.ValorTaxaImposto;
                }
            }
            

            TotalPagar = TotalSemDescontosEImpostos + ValorDoImposto - TotalDescontos;

            lblVendaValorImposto.Text = ValorDoImposto.ToString("C2", new CultureInfo("pt-AO"));
            lblVendaTotalDesconto.Text = TotalDescontos.ToString("C2", new CultureInfo("pt-AO")); 
            lblVendaTotalSemDescontosEImpostos.Text = TotalSemDescontosEImpostos.ToString("C2", new CultureInfo("pt-AO")); 
            lblVendaTotalPagar.Text = TotalPagar.ToString("C2", new CultureInfo("pt-AO"));

            Resumo = new ResumoFinanceiro 
            { 
                TotalDescontos = TotalDescontos,
                TotalPagar = TotalPagar,
                TotalSemDescontosEImpostos = TotalSemDescontosEImpostos,
                TotalValorDeImposto = ValorDoImposto
            };
        }

        private void btnFaturaEliminarItemSelecionado_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvVendaListaProdutos.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["checkItemProduto"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colCodProduto"].Value));
                }
            }

            if(IdsSelecionados.Count > 0)
            {
                ItensProdutos.RemoveAll(item => IdsSelecionados.Contains(item.IdProduto));

                dgvVendaListaProdutos.DataSource = null;
                dgvVendaListaProdutos.DataSource = ItensProdutos;
                this.CalcularResumoFinanceiro();
                return;
            }

            MessageBox.Show(
                "Selecione a caixa de seleção do produto",
                "Mensagem de erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

        }

    }
}
