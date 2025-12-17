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
            frmVendaAdicionarItemProduto frmAddItemProduto = new frmVendaAdicionarItemProduto();
            frmAddItemProduto.ShowDialog();
        }

        private void btnFaturaAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmVendaAdicionarCliente frmAddCliente = new frmVendaAdicionarCliente();
            frmAddCliente.ShowDialog();
        }

        private void btnVendaEditarItemProduto_Click(object sender, EventArgs e)
        {
            frmVendaEditarItemProduto janela = new frmVendaEditarItemProduto();
            janela.ShowDialog();
        }

        private void btnVendaFinalizar_Click(object sender, EventArgs e)
        {
            frmVendaResumoVenda janela = new frmVendaResumoVenda();
            janela.ShowDialog();
        }
    }
}
