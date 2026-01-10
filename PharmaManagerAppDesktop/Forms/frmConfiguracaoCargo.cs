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
    public partial class frmConfiguracaoCargo : Form
    {
        public frmConfiguracaoCargo()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCargoAdicionar frm = new frmConfiguracaoCargoAdicionar();

            if (frm.ShowDialog() == DialogResult.OK)
                DadosReferencia.BuscarCargos(); this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCargoEliminar frm = new frmConfiguracaoCargoEliminar();

            if (frm.ShowDialog() == DialogResult.OK)
                DadosReferencia.BuscarCargos(); this.Close();
        }
    }
}
