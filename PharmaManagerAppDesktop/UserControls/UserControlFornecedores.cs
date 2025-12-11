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

        private void btnAbrirFrmAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            frmAdicionarFornecedor frmAddFornecedor = new frmAdicionarFornecedor();
            frmAddFornecedor.ShowDialog();
        }

        private void btnAdicionarItemProduto_Click(object sender, EventArgs e)
        {
            frmAdicionarFornecedor frmAddFornecedor = new frmAdicionarFornecedor();
            frmAddFornecedor.ShowDialog();
        }
    }
}
