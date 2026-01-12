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
            int IdMunicipio = cmbMunicipio.SelectedValue != null ? Convert.ToInt32(cmbMunicipio.SelectedValue) : 0;
            string Bairro = txtBairro.Text.Trim();

            // Validação
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O nome é obrigatório.");

            if (IdMunicipio <= 0)
                erros.Add("Selecione um município válido.");

            if (!string.IsNullOrWhiteSpace(Telefone))
            {
                Telefone = Utilitarios.ValidarNumeroTelefone.Validar(Telefone);

                if (Telefone == null)
                    erros.Add("O Número de telefone informado é inválido.");
            }
            else
            {
                erros.Add("Número de telefone é obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(Email))
                erros.Add("O email é obrigatório.");
            else if (!Utilitarios.ValidarEmail.Validar(Email))
                erros.Add("O email informado é inválido.");

            if (string.IsNullOrWhiteSpace(Bairro))
                erros.Add("O bairro é obrigatório.");

            if (string.IsNullOrWhiteSpace(Nif))
                erros.Add("O Número de Identificação Fiscal é obrigatório.");

            if (erros.Count > 0)
            {
                string msgErro = string.Join("\n", erros);
                MessageBox.Show(msgErro, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
