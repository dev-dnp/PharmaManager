using PharmaManagerAppDesktop.BaseDeDados;
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
    public partial class frmProdutoEditarProduto : Form
    {
        public ProdutoEntidade Produto;
        public frmProdutoEditarProduto(ProdutoEntidade produto)
        {
            InitializeComponent();
            Produto = produto;
        }
        
        private void frmProdutoEditar_Load(object sender, EventArgs e)
        {
            // 1️⃣ Carregar ComboBox
            cmbCategoria.DataSource = DadosReferencia.CategoriasProduto;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "IdCategoria";

            // (opcional) força refresh do binding
            cmbCategoria.SelectedIndex = -1;

            // 2️⃣ Preencher campos
            txtNome.Text = Produto.Nome;
            txtCodigoBarras.Text = Produto.CodigoBarras;
            txtPrecoVenda.Text = Produto.PrecoVenda.ToString();

            // 3️⃣ Selecionar categoria pelo ID
            cmbCategoria.SelectedValue = Produto.IdCategoria;
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Length > 0 && txtCodigoBarras.Text.Length > 0 && txtNome.Text.Length > 0 && cmbCategoria.SelectedIndex != -1)
                {
                    var DadosProduto = new ProdutoEntidade()
                    {
                        IdProduto = Produto.IdProduto,
                        CodigoBarras = txtCodigoBarras.Text,
                        IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                        Nome = txtNome.Text,
                        PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text),
                    };

                    new ProdutoBD().EditarProduto(DadosProduto);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Valores inválidos! Preencha corretamento os campos");
            }
        }
    }
}
