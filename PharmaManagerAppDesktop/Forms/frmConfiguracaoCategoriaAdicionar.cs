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
    public partial class frmConfiguracaoCategoriaAdicionar : Form
    {
        public frmConfiguracaoCategoriaAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string Categoria = txtCategoria.Text.Trim();

            if(String.IsNullOrWhiteSpace(Categoria))
            {
                MessageBox.Show(
                    "Preencha corretamente todos campos",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var AdicionarCategoria = new CategoriaProdutoBD().Adicionar(Categoria);

             if (AdicionarCategoria == null)
            {
                MessageBox.Show(
                    "Não foi possível realizar esta operação! Tente novamente ou contacte o programador.",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            MessageBox.Show(
                    "Operação realizada com suceso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
             );

            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }
    }
}
