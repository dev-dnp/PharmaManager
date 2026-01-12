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
    public partial class frmConfiguracaoAlterarSenha : Form
    {
        public frmConfiguracaoAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var SenhaAtual = txtSenhaAtual.Text.Trim();
            var SenhaNova = txtSenhaNova.Text.Trim();
            var SenhaNovaConfimacao = txtConfirmarSenhaNova.Text.Trim();


            if (String.IsNullOrWhiteSpace(SenhaAtual) || String.IsNullOrWhiteSpace(SenhaNova) || String.IsNullOrWhiteSpace(SenhaNovaConfimacao))
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos!",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (SenhaNova != SenhaNovaConfimacao)
            {
                MessageBox.Show(
                    "A nova senha não condiz com a confirmação da senha",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            var AlterarSenha = new UsuarioBD().AlterarSenha(SessaoUsuario.Usuario.Email, SenhaAtual,SenhaNova, SessaoUsuario.Usuario.IdUsuario);

            if(!AlterarSenha)
            {
                MessageBox.Show(
                    "Senha atual incorreta!",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            
            MessageBox.Show(
                "Senha alterada com sucesso!",
                "Mensagem de confirmação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void frmConfiguracaoAlterarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
