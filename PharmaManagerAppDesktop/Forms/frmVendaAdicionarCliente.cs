using PharmaManagerAppDesktop.Entidades;
using PharmaManagerAppDesktop.Utilitarios;
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

        public ClienteEntidade Cliente;
        public frmVendaAdicionarCliente(ClienteEntidade cliente)
        {
            InitializeComponent();
            Cliente = cliente;
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

                txtNome.Focus();
                return;
            }

            string tel = null;

            if(txtTelefone.Text.Trim().Length > 0)
            {
                tel = ValidarNumeroTelefone.Validar(txtTelefone.Text.Trim());
                
                if(String.IsNullOrEmpty(tel))
                {
                    MessageBox.Show(
                        "Número de telefone inválido",
                        "Mensagem de erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }
            }


            Cliente.Nome = txtNome.Text;
            Cliente.Telefone = tel;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmVendaAdicionarCliente_Load(object sender, EventArgs e)
        {
            txtNome.Text = Cliente.Nome;
            txtTelefone.Text = Cliente.Telefone;
        }
    }
}
