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

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlConfiguracoes : UserControl
    {
        public UserControlConfiguracoes()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmConfiguracaoAlterarSenha frmSenha = new frmConfiguracaoAlterarSenha();
            frmSenha.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmConfiguracaoAtribuirUsuario frmAddAtribuirUsuario = new frmConfiguracaoAtribuirUsuario();
            frmAddAtribuirUsuario.ShowDialog();
        }

        private void btnConfiguracaoAtivarDesativarUsuario_Click(object sender, EventArgs e)
        {
            frmConfiguracaoAtivarDesativarUsuario frmAddDesativarAtivarUsuario = new frmConfiguracaoAtivarDesativarUsuario();
            frmAddDesativarAtivarUsuario.ShowDialog();
        }

        private void btnConfigurarCategoria_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCategoria frm = new frmConfiguracaoCategoria();
            frm.ShowDialog();
        }

        private void btnConfigurarCargo_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCargo frm = new frmConfiguracaoCargo();
            frm.ShowDialog();
        }

        private void UserControlConfiguracoes_Load(object sender, EventArgs e)
        {
            GerirPermissoes();
        }

        private void GerirPermissoes()
        {
            var Administrador = SessaoUsuario.Permissao.Nome.Replace(" ", "").Split(',').Contains("1");

            if (Administrador == false)
            {
                btnAtivarDesativarUsuario.Visible = false;
                btnAtivarDesativarUsuario.Enabled = false;

                btnAtribuirUsuario.Visible = false;
                btnAtribuirUsuario.Enabled = false;

                btnConfigurarCargo.Visible = false;
                btnConfigurarCargo.Enabled = false;

                btnConfigurarCategoria.Visible = false;
                btnConfigurarCategoria.Enabled = false;

                btnPermissoes.Visible = false;
                btnPermissoes.Enabled = false;

                btnAlterarSenhaDeUsuario.Visible = false;
                btnAlterarSenhaDeUsuario.Enabled = false;
            }
        }

        private void btnPermissoes_Click(object sender, EventArgs e)
        {
            frmConfiguracaoPermissao frm = new frmConfiguracaoPermissao();
            frm.ShowDialog();
        }

        private void btnAlterarSenhaDeUsuario_Click(object sender, EventArgs e)
        {
            frmConfiguracaoAlterarSenhaFuncionario frm = new frmConfiguracaoAlterarSenhaFuncionario();
            frm.ShowDialog();
        }
    }
}
