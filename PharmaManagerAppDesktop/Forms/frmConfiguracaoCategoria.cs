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
    public partial class frmConfiguracaoCategoria : Form
    {
        public frmConfiguracaoCategoria()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCategoriaAdicionar frm = new frmConfiguracaoCategoriaAdicionar();
            
            if (frm.ShowDialog() == DialogResult.OK)
                DadosReferencia.BuscarCategoriasProdutos(); this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmConfiguracaoCategoriaEliminar frm = new frmConfiguracaoCategoriaEliminar();
            
            if(frm.ShowDialog() == DialogResult.OK) 
                DadosReferencia.BuscarCategoriasProdutos(); this.Close();




        }

        private void frmConfiguracaoCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
