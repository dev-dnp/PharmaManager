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
    public partial class frmFacturaCancelarFatura : Form
    {

        public string MotivoCancelamento;
        public frmFacturaCancelarFatura()
        {
            InitializeComponent();
        }

        private void btnAprovarCancelamentoFatura_Click(object sender, EventArgs e)
        {
            if(txtMotivoCancelamento.Text.Length <= 0)
            {
                MessageBox.Show("Descreva o motivo do cancelamento!");
                return;
            }

            MotivoCancelamento = txtMotivoCancelamento.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
