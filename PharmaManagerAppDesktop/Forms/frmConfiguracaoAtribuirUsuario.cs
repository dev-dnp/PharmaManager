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
    public partial class frmConfiguracaoAtribuirUsuario : Form
    {
        public int IdFuncionario;
        public frmConfiguracaoAtribuirUsuario()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var NumBilheteIdentidade = txtBilheteIdentidade.Text.Trim();
            
            if(String.IsNullOrEmpty(NumBilheteIdentidade)) { MessageBox.Show("Preencha o campo bilhete de identidade"); return; }

            var Funcionario = new FuncionarioBD().BuscarFuncionarioNumeroBilheteIdentidade(NumBilheteIdentidade);

            if(Funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado!");
                return;
            }

            if(Funcionario.Usuario.IdUsuario > 0)
            {
                MessageBox.Show(
                    "Este funcionário já possui uma conta!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            txtEmail.Text = Funcionario.Funcionario.Email;
            txtNomeCompleto.Text = Funcionario.Funcionario.Nome;
            IdFuncionario = Funcionario.Funcionario.IdFuncionario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            var Senha = txtSenha.Text.Trim();
            var ConfirmarSenha = txtSenha.Text.Trim();
            var Email = txtEmail.Text.Trim();
            var Nome = txtNomeCompleto.Text.Trim();

            if (String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Nome))
            {
                MessageBox.Show(
                    "Primeiro encontre o usuário pelo campo de pesquisa",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (String.IsNullOrEmpty(Senha) || String.IsNullOrEmpty(ConfirmarSenha))
            { 
                MessageBox.Show(
                    "Preencha os campos: nova senha e confirmar nova senha",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (Senha != ConfirmarSenha)
            {
                MessageBox.Show(
                    "As senhas não coencidem!",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var AtribuirUsuario = new UsuarioBD().AtribuirUsuario(Email, Senha, IdFuncionario);

            if (AtribuirUsuario == null)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao atribuir o usuário! Tente novamente ou contacte o programador!",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }


            MessageBox.Show(
                    "Usuário atribuído com sucesso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            )
                ;
            return;
        }
    }
}
