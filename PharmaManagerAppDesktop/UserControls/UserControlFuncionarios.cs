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
    public partial class UserControlFuncionarios : UserControl
    {
        public UserControlFuncionarios()
        {
            InitializeComponent();
        }

        private void checkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            // Checar se o funcionário possuirá uma conta de Login
            if (checkUsuario.Checked == true)
            {
                panelDadosDeAcesso.Visible = true;
            }
            else
            {
                panelDadosDeAcesso.Visible = false;
                tbSenha.Clear();
            }
        }
    }
}
