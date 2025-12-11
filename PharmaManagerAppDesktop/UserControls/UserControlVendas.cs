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
    public partial class UserControlVendas : UserControl
    {
        public UserControlVendas()
        {
            InitializeComponent();
        }

        private void btnAdicionarItemProduto_Click(object sender, EventArgs e)
        {
            frmAdicionarItemProduto frmAddItemProduto = new frmAdicionarItemProduto();
            frmAddItemProduto.ShowDialog();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmAdicionarCliente frmAddCliente = new frmAdicionarCliente();
            frmAddCliente.ShowDialog();
        }
    }
}
