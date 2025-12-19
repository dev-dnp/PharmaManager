using PharmaManagerAppDesktop.BaseDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmVendaResumoVenda : Form
    {
        public frmVendaResumoVenda()
        {
            InitializeComponent();

            cbVendaMetodoPagamento.DataSource = DadosReferencia.MetodosPagamento;
            cbVendaMetodoPagamento.DisplayMember = "IdMetodoPagamento";
            cbVendaMetodoPagamento.ValueMember = "IdMetodoPagamento";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
