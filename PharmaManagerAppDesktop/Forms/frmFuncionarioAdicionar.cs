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
            string Nome = txtNome.Text;
            string BilheteIdentidade = txtBilheteIdentidade.Text;
            DateTime DataNascimento = dtDataNascimento.Value.Date;
            int IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);
            int IdMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
            string Telefone = txtTelefone.Text;
            string Email = txtEmail.Text;
            string Senha = txtSenha.Text.Trim().Length > 0 ? txtSenha.Text.Trim() : null;
            string Bairro = txtBairro.Text;

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


            bool retorno = new FuncionarioBD().AdicionarFuncionario(DadosFuncionario);

            if(retorno)
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
