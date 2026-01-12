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

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class frmFuncionarioAdicionar : Form
    {
        private FuncionarioBD.DadosFuncionario DadosFuncionario = new FuncionarioBD.DadosFuncionario();
        public frmFuncionarioAdicionar()
        {
            InitializeComponent();
        }

        private void checkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUsuario.Checked == true)
            {
                panelDadosDeAcesso.Visible = true;
            }
            else
            {
                panelDadosDeAcesso.Visible = false;
                txtSenha.Clear();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Recuperar valores do formulário

            string Nome = txtNome.Text.Trim();
            string BilheteIdentidade = txtBilheteIdentidade.Text.Trim();
            DateTime DataNascimento = dtDataNascimento.Value.Date;
            int IdCargo = cmbCargo.SelectedValue != null ? Convert.ToInt32(cmbCargo.SelectedValue) : 0;
            int IdMunicipio = cmbMunicipio.SelectedValue != null ? Convert.ToInt32(cmbMunicipio.SelectedValue) : 0;
            string Telefone = txtTelefone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Senha = !string.IsNullOrWhiteSpace(txtSenha.Text) ? txtSenha.Text.Trim() : null;
            string Bairro = txtBairro.Text.Trim();

            // Validação
            List<string> erros = new List<string>();

            if(IdCargo == 0)
                erros.Add("Selecione um cargo");

            if (IdMunicipio == 0)
                erros.Add("Selecione um municipio");

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
                
                if(Telefone == null)
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

            if(checkUsuario.Checked == true)
            {
                 if (string.IsNullOrWhiteSpace(Senha))
                    erros.Add("A senha é obrigatória!");
            }
            else
            {
                Senha = null;
            }

            if (string.IsNullOrWhiteSpace(Bairro))
                erros.Add("O bairro é obrigatório.");

            if (erros.Count > 0)
            {
                string msgErro = string.Join("\n", erros);
                MessageBox.Show(msgErro, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DadosFuncionario.Funcionario.Nome = Nome;
            DadosFuncionario.Funcionario.BilheteIdentidade = BilheteIdentidade;
            DadosFuncionario.Funcionario.DataNascimento = DataNascimento;
            DadosFuncionario.Funcionario.Telefone = Telefone;
            DadosFuncionario.Funcionario.Email = Email;

            DadosFuncionario.Endereco.IdMunicipio = IdMunicipio;
            DadosFuncionario.Endereco.Bairro = Bairro;

            DadosFuncionario.Usuario.Email = Email;
            DadosFuncionario.Usuario.Senha = Senha;

            DadosFuncionario.Cargo.IdCargo = IdCargo;


            bool AdicionarFuncionario = new FuncionarioBD().AdicionarFuncionario(DadosFuncionario);

            if(AdicionarFuncionario)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Não foi possível adicionar o funcionário!");
            }

        }

        private void frmAdicionarFuncionario_Load(object sender, EventArgs e)
        {
            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.DisplayMember = "Nome";
            cmbProvincia.DataSource = DadosReferencia.Provincias;
            cmbProvincia.SelectedIndex = -1;

            cmbCargo.ValueMember = "IdCargo";
            cmbCargo.DisplayMember = "Nome";
            cmbCargo.DataSource = DadosReferencia.Cargos;
            cmbCargo.SelectedIndex = -1;
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
    }
}
