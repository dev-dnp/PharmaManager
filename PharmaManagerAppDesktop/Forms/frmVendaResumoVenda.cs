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
    public partial class frmVendaResumoVenda : Form
    {

        UserControlVendas FormVenda;
        public MetodoPagamento MetodoPagamento;

        public frmVendaResumoVenda(UserControlVendas formulario)
        {
            InitializeComponent();

            cbMetodoPagamento.DisplayMember = "Nome";
            cbMetodoPagamento.ValueMember = "IdMetodoPagamento";
            cbMetodoPagamento.DataSource = DadosReferencia.MetodosPagamento;

            FormVenda = formulario;
        }

        private void frmVendaResumoVenda_Load(object sender, EventArgs e)
        {
            if(FormVenda.Cliente != null && FormVenda.Resumo != null)
            {
                lblNomeCliente.Text = FormVenda.Cliente.Nome ?? "-";
                lblTelefoneCliente.Text = FormVenda.Cliente.Telefone ?? "-";

                lblTotalSemDescontosEImpostos.Text = FormVenda.Resumo.TotalSemDescontosEImpostos.ToString("C2", new CultureInfo("pt-AO"));
                lblTotalValorImposto.Text = FormVenda.Resumo.TotalValorDeImposto.ToString("C2", new CultureInfo("pt-AO"));
                lblTotalDescontos.Text = FormVenda.Resumo.TotalDescontos.ToString("C2", new CultureInfo("pt-AO"));
                lblTotalPagar.Text = FormVenda.Resumo.TotalPagar.ToString("C2", new CultureInfo("pt-AO"));
            } else
            {
                FormVenda.Cliente = new ClienteEntidade();
            }
        }

        private void cbMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamento = cbMetodoPagamento.SelectedItem as MetodoPagamento;
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            if(cbMetodoPagamento.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
