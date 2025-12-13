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

        private void btnFaturaAdicionarItemProduto_Click(object sender, EventArgs e)
        {
            frmAdicionarItemProduto frmAddItemProduto = new frmAdicionarItemProduto();
            frmAddItemProduto.ShowDialog();
        }

        private void btnFaturaAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmFaturaAdicionarCliente frmAddCliente = new frmFaturaAdicionarCliente();
            frmAddCliente.ShowDialog();
        }
    }
}
