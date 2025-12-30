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
    public partial class frmFornecedorAdicionar : Form
    {
        public frmFornecedorAdicionar()
        {
            InitializeComponent();
        }

        private void frmFornecedorAdicionar_Load(object sender, EventArgs e)
        {
            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.DisplayMember = "Nome";
            cmbProvincia.DataSource = DadosReferencia.Provincias;
            cmbProvincia.SelectedIndex = -1;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedValue == null || cmbProvincia.SelectedIndex == -1)
            {
                cmbMunicipio.SelectedIndex = -1;
                cmbMunicipio.DataSource = null;
                return;
            }

            int IdProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);

            cmbMunicipio.DataSource = null;
            cmbMunicipio.ValueMember = "IdMunicipio";
            cmbMunicipio.DisplayMember = "Nome";
            
            var Municipios = DadosReferencia.Municipios.FindAll(mun => mun.IdProvincia == IdProvincia);
            cmbMunicipio.DataSource = Municipios;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text.Trim();
            string Nif = txtNif.Text.Trim();
            string Telefone = txtTelefone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            int IdMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
            string Bairro = txtBairro.Text.Trim();

            if(String.IsNullOrEmpty(Nome) || String.IsNullOrEmpty(Nif) || String.IsNullOrEmpty(Telefone) || String.IsNullOrEmpty(Email) || cmbMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            FornecedorBD.DadosFornecedor Fornecedor = new FornecedorBD.DadosFornecedor()
            {
                Fornecedor =
                {
                    Nome = Nome,
                    Email = Email,
                    Telefone = Telefone,
                    NIF = Nif,
                },
                Endereco =
                {
                    Bairro = Bairro,
                    IdMunicipio=IdMunicipio,
                }
            };

            bool retorno  = new FornecedorBD().AdicionarFornecedor(Fornecedor);

            if(retorno)
            {
                MessageBox.Show(
                    "Fornecedor registado com sucesso!",
                    "Mensagem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                this.Close();
            } 
            else
            {
                MessageBox.Show(
                    "Erro ao registar o fornecedor! Tente novamente ou contacte o programador.",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
                
        }

    }
}
