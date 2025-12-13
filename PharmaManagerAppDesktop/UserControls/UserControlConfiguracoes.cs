using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaManagerAppDesktop.Forms;

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlConfiguracoes : UserControl
    {
        public UserControlConfiguracoes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmDadosOrganizacao frmAddDadosOrganizacao = new frmDadosOrganizacao();
            frmAddDadosOrganizacao.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmSenha = new frmAlterarSenha();
            frmSenha.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmAtribuirUsuario frmAddAtribuirUsuario = new frmAtribuirUsuario();
            frmAddAtribuirUsuario.ShowDialog();
        }

        private void UserControlConfiguracoes_Load(object sender, EventArgs e)
        {

        }
    }
}
