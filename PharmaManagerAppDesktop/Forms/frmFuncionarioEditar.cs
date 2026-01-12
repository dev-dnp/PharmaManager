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
            // Recuperar valores do formulário

            string Nome = txtNome.Text.Trim();
            string BilheteIdentidade = txtBilheteIdentidade.Text.Trim();
            DateTime DataNascimento = dtDataNascimento.Value.Date;
            int IdCargo = cmbCargo.SelectedValue != null ? Convert.ToInt32(cmbCargo.SelectedValue) : 0;
            int IdMunicipio = cmbMunicipio.SelectedValue != null ? Convert.ToInt32(cmbMunicipio.SelectedValue) : 0;
            string Telefone = txtTelefone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Bairro = txtBairro.Text.Trim();

            // Validação
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O nome é obrigatório.");


            if (string.IsNullOrWhiteSpace(BilheteIdentidade))
                erros.Add("O Bilhete de Identidade é obrigatório.");
            else
            {
                var Validar = Utilitarios.ValidarNumeroBilheteIdentidade.Validar(BilheteIdentidade);
                if (!Validar.Valido) erros.Add(Validar.MsgErro);
                else BilheteIdentidade = Validar.NumeroBilheteIdentidade;
            }

            if (DataNascimento == default || DataNascimento > DateTime.Today)
                erros.Add("Data de nascimento inválida.");

            if (IdCargo <= 0)
                erros.Add("Selecione um cargo válido.");

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

            if (erros.Count > 0)
            {
                string msgErro = string.Join("\n", erros);
                MessageBox.Show(msgErro, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
