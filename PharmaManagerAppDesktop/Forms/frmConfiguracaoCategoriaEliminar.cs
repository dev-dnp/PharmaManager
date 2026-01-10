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
    public partial class frmConfiguracaoCategoriaEliminar : Form
    {
        public frmConfiguracaoCategoriaEliminar()
        {
            InitializeComponent();
        }

        private void frmConfiguracaoCategoriaEditar_Load(object sender, EventArgs e)
        {
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.DisplayMember = "Nome";

            DadosReferencia.BuscarCategoriasProdutos();
            cmbCategoria.DataSource = DadosReferencia.CategoriasProduto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que quer eliminar?", "Mensagem de alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

            int IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            var EliminarCategoria = new CategoriaProdutoBD().Eliminar(IdCategoria);

            if(EliminarCategoria == null)
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
