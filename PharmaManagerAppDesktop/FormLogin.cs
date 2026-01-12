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
            imagemCarregamento.Visible = true;

            var Email = txtEmail.Text.Trim();
            var Senha = txtSenha.Text.Trim();


            // VALIDANDO OS CAMPOS EMAIL E SENHA SE ESTÃO VAZIOS OU NULOS

            if (String.IsNullOrWhiteSpace(Email) || String.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                imagemCarregamento.Visible = false;
                return; 
            }

            // BUSCAR USUÁRIO NA BASE DE DADOS

            UsuarioEntidade Usuario = new UsuarioBD().AutenticarUsuario(txtEmail.Text, txtSenha.Text);

            // CASO O USUÁRIO NÃO EXISTA 

            if (Usuario == null)
            {
                MessageBox.Show(
                    "Email ou senha incorreto! Tente novamente.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                imagemCarregamento.Visible = false;
                return;
            }

            if(!Usuario.Ativo)
            {
                MessageBox.Show(
                    "Acesso bloqueado! Contacte o Administrador",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                imagemCarregamento.Visible = false;
                return;
            }

            // USUÁRIO EXISTE! PEGANDO OS SEUS DADOS COMO FUNCIONÁRIO

            FuncionarioBD.DadosFuncionario infoFuncionario = new FuncionarioBD().BuscarUmFuncionarioPorIdUsuario(Usuario.IdUsuario); 


            // CASO O USUÁRIO AINDA NÃO TENHA NENHUMA PERMISSÃO NO SISTEMA

            if(infoFuncionario.Permissao.Nome == null)
            {
                MessageBox.Show(
                    "Não existe nenhuma permissão para este usuário! Contacte o Administrador para atribui-lo.",
                    "Mensagem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                imagemCarregamento.Visible = false;
                return;
            }

            // USUARIO ENTROU NO SISTEMMA. ASSINANDO SUA SESSÃO DE USUÁRIO

            SessaoUsuario.Usuario = Usuario;
            SessaoUsuario.Funcionario = infoFuncionario.Funcionario;
            SessaoUsuario.Cargo = infoFuncionario.Cargo;
            SessaoUsuario.Permissao = infoFuncionario.Permissao;
            SessaoUsuario.Provincia = infoFuncionario.Provincia;
            SessaoUsuario.Municipio = infoFuncionario.Municipio;
            SessaoUsuario.Endereco = infoFuncionario.Endereco;
            
            DadosReferencia.AtualizarTodasReferencias();


            // ABRINDO A JANELA INICIAL

            FormJanelaInicial frm = new FormJanelaInicial();
            this.Hide();
            frm.ShowDialog();
            
            // USUARIO SAIU DO SISTEMA. DESTRUINDO OS DADOS DE SESSÃO

            SessaoUsuario.Limpar();
            txtEmail.Clear();
            txtSenha.Clear();
            txtEmail.Focus();
            imagemCarregamento.Visible = false;
            this.Show();
        }

    }
}
