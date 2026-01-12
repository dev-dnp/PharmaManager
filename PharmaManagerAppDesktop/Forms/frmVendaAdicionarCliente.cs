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
            string NomeCliente = txtNome.Text.Trim();
            string TelefoneCliente = txtTelefone.Text.Trim();

            if (String.IsNullOrWhiteSpace(NomeCliente))
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


            if(!String.IsNullOrWhiteSpace(TelefoneCliente))
            {
                TelefoneCliente = ValidarNumeroTelefone.Validar(TelefoneCliente);
                
                if(String.IsNullOrEmpty(TelefoneCliente))
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


            Cliente.Nome = NomeCliente;
            Cliente.Telefone = TelefoneCliente;

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
