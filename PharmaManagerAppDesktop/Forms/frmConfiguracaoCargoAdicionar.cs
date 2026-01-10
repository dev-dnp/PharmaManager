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
    public partial class frmConfiguracaoCargoAdicionar : Form
    {
        public frmConfiguracaoCargoAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string NomeCargo = txtCargo.Text.Trim();
            string Descricao = String.IsNullOrWhiteSpace(txtDescricao.Text.Trim()) ? null : txtDescricao.Text.Trim();

            if(String.IsNullOrWhiteSpace(NomeCargo))
            {
                MessageBox.Show(
                    "Preencha corretamento o campo categoria",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var AdicionarCargo = new CargoBD().Adicionar(NomeCargo, Descricao);

            if(AdicionarCargo  != null)
            {
                MessageBox.Show(
                    "Cargo adiconado com sucesso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            MessageBox.Show(
                    "Não foi possível executar esta operação! Tente novamente ou contacte o programador",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            return;
        }
    }
}
