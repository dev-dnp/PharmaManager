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
    public partial class frmConfiguracaoCargoEliminar : Form
    {
        public frmConfiguracaoCargoEliminar()
        {
            InitializeComponent();
        }

        private void frmConfiguracaoCargoEliminar_Load(object sender, EventArgs e)
        {
            cmbCargo.ValueMember = "IdCargo";
            cmbCargo.DisplayMember = "Nome";

            DadosReferencia.BuscarCargos();

            cmbCargo.DataSource = DadosReferencia.Cargos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o cargo");
                return;
            }

            int IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);

            var resposta = MessageBox.Show("Tem certeza que quer eliminar?", "Mensagem de alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

            var EliminarCargo = new CargoBD().Eliminar(IdCargo);

            if(EliminarCargo != null)
            {
                MessageBox.Show("Eliminado com sucesso!", "Mensagem de confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show("Não foi possível executar esta operação! Tente novamente ou contacte o programador", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
