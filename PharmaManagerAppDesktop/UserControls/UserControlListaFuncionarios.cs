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
    public partial class UserControlListaFuncionarios : UserControl
    {
        public UserControlListaFuncionarios()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrirFrmAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            frmAdicionarFuncionario frmAddFuncionario = new frmAdicionarFuncionario();
            frmAddFuncionario.ShowDialog();

        }
    }
}
