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
    public partial class frmFornecedorEditar : Form
    {
        FornecedorBD.DadosFornecedor Fornecedor = new FornecedorBD.DadosFornecedor();
        public frmFornecedorEditar(FornecedorBD.DadosFornecedor f)
        {
            InitializeComponent();

            Fornecedor = f;
        }

        private void frmFornecedorEditar_Load(object sender, EventArgs e)
        {
            txtNome.Text = Fornecedor.Fornecedor.Nome;
            txtNif.Text = Fornecedor.Fornecedor.NIF;
            txtBairro.Text = Fornecedor.Endereco.Bairro;
            txtEmail.Text = Fornecedor.Fornecedor.Email;
            txtTelefone.Text = Fornecedor.Fornecedor.Telefone;


            cmbProvincia.DataSource = null;
            cmbMunicipio.DataSource = null;

            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.DisplayMember = "Nome";
            cmbMunicipio.ValueMember = "IdMunicipio";
            cmbMunicipio.DisplayMember = "Nome";

            cmbProvincia.DataSource = DadosReferencia.Provincias;

            cmbProvincia.SelectedValue = Fornecedor.Provincia.IdProvincia;
            cmbMunicipio.SelectedValue = Fornecedor.Municipio.IdMunicipio;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text.Trim();
            string Nif = txtNif.Text.Trim();
            string Telefone = txtTelefone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            int IdMunicipio = cmbMunicipio.SelectedValue != null ? Convert.ToInt32(cmbMunicipio.SelectedValue) : 0;
            string Bairro = txtBairro.Text.Trim();

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
                    IdFornecedor = this.Fornecedor.Fornecedor.IdFornecedor,
                    Nome = Nome,
                    Email = Email,
                    Telefone = Telefone,
                    NIF = Nif,
                },
                Endereco =
                {
                    IdEndereco = this.Fornecedor.Endereco.IdEndereco,
                    Bairro = Bairro,
                    IdMunicipio=IdMunicipio,
                }
            };

            bool retorno = new FornecedorBD().EditarFornecedor(Fornecedor);

            if (retorno)
            {
                MessageBox.Show(
                    "Operação realizada com sucesso!",
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
                    "Erro ao editar o fornecedor! Tente novamente ou contacte o programador.",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
