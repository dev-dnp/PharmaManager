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

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            frmAdicionarFuncionario frmAddFuncionario = new frmAdicionarFuncionario();
            frmAddFuncionario.ShowDialog();
        }
    }
}
