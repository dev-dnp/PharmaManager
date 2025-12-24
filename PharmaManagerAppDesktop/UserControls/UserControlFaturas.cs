using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Forms;

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlFaturas : UserControl
    {
        public class FaturaVisualizacaoTabela
        {
            public int IdFatura {  get; set; }
            public string ClienteNome { get; set; }
            public DateTime DataVenda { get; set; }
            public string FuncionarioNome { get; set; }
            public string MetodoPagamento { get; set; }
            public string EstadoFatura { get; set; }
            public decimal ValorPago { get; set; }

        }

        public List<FaturaVisualizacaoTabela> DadosFaturaTabela { get; set; } = new List<FaturaVisualizacaoTabela>();
        public UserControlFaturas()
        {
            InitializeComponent();
        }

        private void btnFacturaDetalhes_Click(object sender, EventArgs e)
        {
            frmFacturaDetalhes janela = new frmFacturaDetalhes();
            janela.ShowDialog();
        }

        private void btnFacturaCancelar_Click(object sender, EventArgs e)
        {
            frmFacturaCancelarFatura janela = new frmFacturaCancelarFatura();
            janela.ShowDialog();

        }

        private void UserControlFaturas_Load(object sender, EventArgs e)
        {
            var ListaFaturas = new FaturaBD().BuscarTodasFaturas();

            foreach (var Item in ListaFaturas)
            {
                DadosFaturaTabela.Add(new FaturaVisualizacaoTabela
                {
                    ClienteNome = Item.Cliente.Nome,
                    DataVenda = Item.Fatura.DataVenda,
                    EstadoFatura = Item.EstadoFatura.Nome,
                    FuncionarioNome = Item.Funcionario.Nome,
                    IdFatura = Item.Fatura.IdFatura,
                    MetodoPagamento = Item.MetodoPagamento.Nome,
                    ValorPago = Item.Fatura.TotalPagamento
                });
            }

            dgvFaturaLista.AutoGenerateColumns = false;
            colIdFatura.DataPropertyName = "IdFatura";
            colDataEmissaoFatura.DataPropertyName = "DataVenda";
            colNomeClienteFatura.DataPropertyName = "ClienteNome";
            colMetodoPagamentoFatura.DataPropertyName = "MetodoPagamento";
            colFuncionarioFatura.DataPropertyName = "FuncionarioNome";
            colEstadoFatura.DataPropertyName = "EstadoFatura";
            colValorPago.DataPropertyName = "ValorPago";

            dgvFaturaLista.DataSource = null;
            dgvFaturaLista.DataSource = DadosFaturaTabela;
        }

        private void btnPesquisarFatura_Click(object sender, EventArgs e)
        {
            string Texto = txtCampoPesquisar.Text;

            var ListaFaturas = new FaturaBD().BuscarTodasFaturasPorTextoDePesquisa(Texto);

            DadosFaturaTabela.Clear();

            foreach (var Item in ListaFaturas)
            {
                DadosFaturaTabela.Add(new FaturaVisualizacaoTabela
                {
                    ClienteNome = Item.Cliente.Nome,
                    DataVenda = Item.Fatura.DataVenda,
                    EstadoFatura = Item.EstadoFatura.Nome,
                    FuncionarioNome = Item.Funcionario.Nome,
                    IdFatura = Item.Fatura.IdFatura,
                    MetodoPagamento = Item.MetodoPagamento.Nome,
                    ValorPago = Item.Fatura.TotalPagamento
                });
            }

            dgvFaturaLista.DataSource = null;
            dgvFaturaLista.DataSource = DadosFaturaTabela;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            var ListaFaturas = new FaturaBD().BuscarTodasFaturas();
            DadosFaturaTabela.Clear();
            txtCampoPesquisar.Clear();
            foreach (var Item in ListaFaturas)
            {
                DadosFaturaTabela.Add(new FaturaVisualizacaoTabela
                {
                    ClienteNome = Item.Cliente.Nome,
                    DataVenda = Item.Fatura.DataVenda,
                    EstadoFatura = Item.EstadoFatura.Nome,
                    FuncionarioNome = Item.Funcionario.Nome,
                    IdFatura = Item.Fatura.IdFatura,
                    MetodoPagamento = Item.MetodoPagamento.Nome,
                    ValorPago = Item.Fatura.TotalPagamento
                });
            }


            dgvFaturaLista.DataSource = null;
            dgvFaturaLista.DataSource = DadosFaturaTabela;
        }
    }
}
