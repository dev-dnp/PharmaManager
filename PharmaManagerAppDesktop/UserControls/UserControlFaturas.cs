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
using static System.Windows.Forms.LinkLabel;

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
        public List<FaturaBD.DetalhesFatura> TodasFaturas;
        public UserControlFaturas()
        {
            InitializeComponent();
        }

        private void btnFacturaDetalhes_Click(object sender, EventArgs e)
        {

            List<int> IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvFaturaLista.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colIdFatura"].Value));
                }
            }

            if (IdsSelecionados.Count == 1)
            {
                var FaturaSelecionada = TodasFaturas.Find(f => f.Fatura.IdFatura == IdsSelecionados[0]);

                frmFacturaDetalhes janela = new frmFacturaDetalhes(IdsSelecionados[0], FaturaSelecionada);
                janela.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Selecione uma fatura por vez",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
                return;
            }
        }

        private void UserControlFaturas_Load(object sender, EventArgs e)
        {
            TodasFaturas = new FaturaBD().BuscarTodasFaturas();

            foreach (var Item in TodasFaturas)
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

            var ListaFaturas = new FaturaBD().BuscarTodasFaturas(Texto);

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
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            TodasFaturas = new FaturaBD().BuscarTodasFaturas();

            DadosFaturaTabela.Clear();
            txtCampoPesquisar.Clear();

            foreach (var Item in TodasFaturas)
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

        private void btnCancelarFatura_Click(object sender, EventArgs e)
        {

            List<int> IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvFaturaLista.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colIdFatura"].Value));
                }
            }

            if(IdsSelecionados.Count == 1)
            {
                var FaturaSelecionada = TodasFaturas.Find(f => f.Fatura.IdFatura == IdsSelecionados[0]);

                if (FaturaSelecionada.EstadoFatura.IdEstadoFatura == 3)
                {
                    MessageBox.Show(
                        "A fatura já foi cancelada",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                     );
                    return;
                }


                frmFacturaCancelarFatura janela = new frmFacturaCancelarFatura();
                
                var retorno = janela.ShowDialog();

                if(retorno == DialogResult.OK)
                {
                    if(new FaturaBD().CancelarFatura(IdsSelecionados[0]))
                    {
                        if(new EstoqueBD().Devolucao(IdsSelecionados[0], janela.MotivoCancelamento))
                        {
                            AtualizarLista();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione apenas uma linha",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
                return;
            }

        }
    }
}
