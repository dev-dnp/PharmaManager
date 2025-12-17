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
    public partial class UserControlFacturas : UserControl
    {
        public UserControlFacturas()
        {
            InitializeComponent();
        }

        private void userControlVendas1_Load(object sender, EventArgs e)
        {

        }

        private void btnFacturaDetalhes_Click(object sender, EventArgs e)
        {
            frmFacturaDetalhes janela = new frmFacturaDetalhes();
            janela.ShowDialog();
        }

        private void btnFacturaCancelar_Click(object sender, EventArgs e)
        {
            frmFacturaCancelarFatura janela = new frmFacturaCancelarFatura();
            janela.ShowDialog();

        }
    }
}
