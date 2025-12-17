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
    public partial class UserControlFornecedores : UserControl
    {
        public UserControlFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorAdicionar frmAddFornecedor = new frmFornecedorAdicionar();
            frmAddFornecedor.ShowDialog();
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorEditar janela = new frmFornecedorEditar();
            janela.ShowDialog();
        }
    }
}
