using PharmaManagerAppDesktop.Forms;
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
    public partial class UserControlEstoque : UserControl
    {
        public UserControlEstoque()
        {
            InitializeComponent();
        }

        private void btnRegistarProdutoNoEstoque_Click(object sender, EventArgs e)
        {
            frmRegistarProduto frmRegistarProduto = new frmRegistarProduto();
            frmRegistarProduto.ShowDialog();
        }
    }
}
