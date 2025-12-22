using PharmaManagerAppDesktop.Entidades;
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
    
    public partial class frmVendaAdicionarCliente : Form
    {

        public Cliente Cliente = new Cliente();
        public frmVendaAdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show(
                    "Campo nome obrigatório",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtNome.Clear();
                txtNome.Focus();
                return;
            }


            Cliente.Nome = txtNome.Text;
            Cliente.Telefone = txtTelefone.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
