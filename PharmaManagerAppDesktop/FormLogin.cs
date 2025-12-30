using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Entidades;

namespace PharmaManagerAppDesktop
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            pictureLoading.Visible = true;

            // Validar o campo email
            if (txtEmail.Text.Trim() == String.Empty)
            {
                MessageBox.Show(
                    "Campo email obrigatório",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtEmail.Clear();
                txtEmail.Focus();
                pictureLoading.Visible = false;
                return; 
            }

            // Validar o campo senha

            if (txtSenha.Text == String.Empty)
            {
                MessageBox.Show(
                    "Campo senha obrigatório",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtSenha.Focus();
                pictureLoading.Visible = false;
                return;
            }


            // Buscar usuario na base de dados
            Usuario usuario = new UsuarioBD().BuscarUsuarioPorEmailESenha(txtEmail.Text, txtSenha.Text);


            // Caso o usuário não exista
            if (usuario == null)
            {
                MessageBox.Show(
                    "Email ou senha incorreto! Tente novamente.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                pictureLoading.Visible = false;
                return;
            }

            // Usuário existe! Assinando sua sessão de usuário 
            FuncionarioBD.TodosDadosFuncionario infoFuncionario = new FuncionarioBD().BuscarUmFuncionarioPorIdUsuario(usuario.IdUsuario); 

            SessaoUsuario.Usuario = usuario;
            SessaoUsuario.Funcionario = infoFuncionario.Funcionario;
            SessaoUsuario.Cargo = infoFuncionario.Cargo;
            SessaoUsuario.Permissao = infoFuncionario.Permissao;
            SessaoUsuario.Provincia = infoFuncionario.Provincia;
            SessaoUsuario.Municipio = infoFuncionario.Municipio;
            SessaoUsuario.Endereco = infoFuncionario.Endereco;

            DadosReferencia.BuscarMetodosPagamento();
            DadosReferencia.BuscarProvincias();
            DadosReferencia.BuscarMunicipios();
            DadosReferencia.BuscarCargos();
            DadosReferencia.BuscarCategoriasProdutos();
            DadosReferencia.BuscarEstadoFatura();
            DadosReferencia.BuscarPermissoes();


            FormJanelaInicial janela = new FormJanelaInicial();
            janela.ShowDialog();


        }

    }
}
