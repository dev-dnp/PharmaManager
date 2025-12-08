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
using PharmaManagerAppDesktop.UserControls;

namespace PharmaManagerAppDesktop
{
    public partial class FormJanelaInicial : Form
    {
        public UserControl Uc;

        public FormJanelaInicial()
        {
            InitializeComponent();
        }

        // METODO RESPONSÁVEL PELA REUTILIZAÇÃO DO CONTROLE DE USUÁRIOS
        public void CarregarControleDeUsuario(UserControl uc)
        {
            panelConteudoPrincipal.Controls.Clear();
            
            uc.Dock = DockStyle.Fill;

            panelConteudoPrincipal.Controls.Add(uc);
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlDashboard());
            labelTituloPainelAtual.Text = "Dashboad";
        }

        private void btnMenuVendas_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlVendas());
            labelTituloPainelAtual.Text = "Vendas";
        }

        private void btnMenuFaturas_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlFacturas());
            labelTituloPainelAtual.Text = "Facturas";
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlEstoque());
            labelTituloPainelAtual.Text = "Estoque";
        }

        private void btnMenuFornecedores_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlFornecedores());
            labelTituloPainelAtual.Text = "Fornecedores";
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlClientes());
            labelTituloPainelAtual.Text = "Clientes";
        }

        private void btnMenuFuncionarios_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlListaFuncionarios());
            labelTituloPainelAtual.Text = "Lista de funcionários";
        }

        private void btnMenuNotificacoes_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlNotificacoes());
            labelTituloPainelAtual.Text = "Notificações";
        }

        private void btnMenuConfiguracoes_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlConfiguracoes());
            labelTituloPainelAtual.Text = "Configurações";
        }
    }
}
