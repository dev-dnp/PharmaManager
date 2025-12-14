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
    public partial class UserControlListaClientes : UserControl
    {
        public UserControlListaClientes()
        {
            InitializeComponent();
        }

        private void btnAbrirFrmAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarCliente frmAddCliente = new frmVendaAdicionarCliente();
            frmAddCliente.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlListaClientes_Load(object sender, EventArgs e)
        {
        }

        private void btnAdicionarItemProduto_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarCliente frmAddCliente = new frmVendaAdicionarCliente();
            frmAddCliente.ShowDialog();
        }
    }
}
