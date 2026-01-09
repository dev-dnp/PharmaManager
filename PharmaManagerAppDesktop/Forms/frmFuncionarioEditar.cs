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
using static PharmaManagerAppDesktop.BaseDeDados.FuncionarioBD;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmFuncionarioEditar : Form
    {
        DadosFuncionario Funcionario;
        public frmFuncionarioEditar(FuncionarioBD.DadosFuncionario f)
        {
            InitializeComponent();

            Funcionario = f;
        }

        private void frmFuncionarioEditar_Load(object sender, EventArgs e)
        {
            txtNome.Text = Funcionario.Funcionario.Nome;
            txtBilheteIdentidade.Text = Funcionario.Funcionario.BilheteIdentidade;
            txtEmail.Text = Funcionario.Funcionario.Email;
            txtTelefone.Text = Funcionario.Funcionario.Telefone;
            txtBairro.Text = Funcionario.Endereco.Bairro;
            txtEmail.Text = Funcionario.Funcionario.Email;
            dtDataNascimento.Text = Funcionario.Funcionario.DataNascimento.ToString();
            
            cmbCargo.ValueMember = "IdCargo";
            cmbCargo.DisplayMember = "Nome";
            cmbCargo.DataSource = DadosReferencia.Cargos;

            cmbProvincia.DataSource = null;
            cmbMunicipio.DataSource = null;

            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.DisplayMember = "Nome";


            cmbMunicipio.ValueMember = "IdMunicipio";
            cmbMunicipio.DisplayMember = "Nome";
            
            cmbProvincia.DataSource = DadosReferencia.Provincias;


            cmbProvincia.SelectedValue = Funcionario.Provincia.IdProvincia;
            cmbMunicipio.SelectedValue = Funcionario.Municipio.IdMunicipio;
            cmbCargo.SelectedValue = Funcionario.Cargo.IdCargo;
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

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text.Trim();
            string BilheteIdentidade = txtBilheteIdentidade.Text.Trim();
            DateTime DataNascimento = dtDataNascimento.Value;
            int IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);
            string Telefone = txtTelefone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            int IdMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
            string Bairro = txtBairro.Text.Trim();

            if(String.IsNullOrEmpty(Nome) || String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Telefone) || String.IsNullOrEmpty(BilheteIdentidade) || cmbProvincia.SelectedIndex == -1 || cmbMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            bool retorno = new FuncionarioBD().EditarFuncionario(new FuncionarioBD.DadosFuncionario
            {
                Funcionario = new Entidades.FuncionarioEntidade
                {
                    IdFuncionario = Funcionario.Funcionario.IdFuncionario,
                    Nome = Nome,
                    Email = Email,
                    Telefone = Telefone,
                    IdCargo = IdCargo,
                    BilheteIdentidade = BilheteIdentidade,
                    DataNascimento = DataNascimento
                },

                Endereco = new Entidades.EnderecoEntidade
                {
                    IdEndereco = Funcionario.Endereco.IdEndereco,
                    Bairro = Bairro,
                    IdMunicipio = IdMunicipio
                }
            });

            if(retorno)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();

                //MessageBox.Show(
                //    "Editado com sucesso!",
                //    "Mensagem de confirmação",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information
                //);
                return;
            }
            else
            {
                MessageBox.Show(
                    "Falha ao editar o funcionário! Tente novamente ou contate o programador!",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
