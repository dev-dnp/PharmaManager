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
using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.UserControls;

namespace PharmaManagerAppDesktop
{
    public partial class FormJanelaInicial : Form
    {
        public UserControl Uc;

        public FormJanelaInicial()
        {
            InitializeComponent();

            CarregarControleDeUsuario(new UserControlPainel());
            labelTituloPainelAtual.Text = "Painel Inicial";
            SelecionarMenu("Painel Inicial");
        }

        // METODO RESPONSÁVEL PELA REUTILIZAÇÃO DO CONTROLE DE USUÁRIOS
        public void CarregarControleDeUsuario(UserControl uc)
        {
            panelConteudoPrincipal.Controls.Clear();
            
            panelConteudoPrincipal.Controls.Add(uc);

            uc.Dock = DockStyle.Fill;
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlPainel());
            labelTituloPainelAtual.Text = "Painel Inicial";
            SelecionarMenu("Painel Inicial");
        }

        private void btnMenuVendas_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlVendas());
            labelTituloPainelAtual.Text = "Vendas";
            SelecionarMenu("Vendas");
        }

        private void btnMenuFaturas_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlFaturas());
            labelTituloPainelAtual.Text = "Faturas";
            SelecionarMenu("Faturas");
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlEstoque());
            labelTituloPainelAtual.Text = "Estoque";
            SelecionarMenu("Estoque");
        }

        private void btnMenuFornecedores_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlFornecedores());
            labelTituloPainelAtual.Text = "Fornecedores";
            SelecionarMenu("Fornecedores");
        }


        private void btnMenuFuncionarios_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlFuncionarios());
            labelTituloPainelAtual.Text = "Funcionários";
            SelecionarMenu("Funcionários");
        }


        private void btnMenuConfiguracoes_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlConfiguracoes());
            labelTituloPainelAtual.Text = "Configurações";
            SelecionarMenu("Configurações");
        }

        private void panelConteudoPrincipal_Resize(object sender, EventArgs e)
        {
            if (panelConteudoPrincipal.Controls.Count > 0)
            {
                Control uc = panelConteudoPrincipal.Controls[0];

                uc.Size = panelConteudoPrincipal.ClientSize;
                uc.Location = new Point(0, 0);
            }
        }

        private void btnMenuProdutos_Click(object sender, EventArgs e)
        {
            CarregarControleDeUsuario(new UserControlProdutos());
            labelTituloPainelAtual.Text = "Produtos";
            SelecionarMenu("Produtos");
        }

        private void FormJanelaInicial_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = "Olá, " + SessaoUsuario.Funcionario.Nome + "!";
        }

        public void SelecionarMenu(string opcaoMenu)
        {

            if(opcaoMenu == "Produtos")
                btnMenuProdutos.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuProdutos.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Configurações")
                btnMenuConfiguracoes.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuConfiguracoes.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Fornecedores")
                btnMenuFornecedores.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuFornecedores.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Painel Inicial")
                btnMenuPainel.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuPainel.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Vendas")
                btnMenuVendas.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuVendas.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Estoque")
                btnMenuEstoque.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuEstoque.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Faturas")
                btnMenuFaturas.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuFaturas.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

            if (opcaoMenu == "Funcionários")
                btnMenuFuncionarios.FillColor = System.Drawing.Color.FromArgb(140, 208, 235);
            else
                btnMenuFuncionarios.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);

        }
    }
}
