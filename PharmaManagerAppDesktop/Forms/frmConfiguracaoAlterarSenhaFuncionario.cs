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
    public partial class frmConfiguracaoAlterarSenhaFuncionario : Form
    {
        public frmConfiguracaoAlterarSenhaFuncionario()
        {
            InitializeComponent();
        }

        public class FuncionariosComboBox
        {
            public int IdUsuario { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
        }

        List<FuncionariosComboBox> FuncionariosAtuais = new List<FuncionariosComboBox>();

        private void frmConfiguracaoAlterarSenhaFuncionario_Load(object sender, EventArgs e)
        {
            var FuncionariosEncontrados = new FuncionarioBD().BuscarTodosFuncionarios().FindAll(f => f.Usuario.IdUsuario > 0);

            foreach (var Funcionario in FuncionariosEncontrados)
            {
                FuncionariosAtuais.Add(new FuncionariosComboBox
                {
                    IdUsuario = Funcionario.Funcionario.IdUsuario,
                    Email = Funcionario.Funcionario.Email,
                    Nome = $"{Funcionario.Funcionario.Nome} ({Funcionario.Funcionario.Email})"
                });
            }

            cmbFuncionarios.DisplayMember = "Nome";
            cmbFuncionarios.ValueMember = "IdUsuario";
            cmbFuncionarios.DataSource = FuncionariosAtuais;
            cmbFuncionarios.SelectedIndex = -1;
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            var Senha = txtSenhaNova.Text.Trim();
            var SenhaConfimacao = txtConfirmarSenhaNova.Text.Trim();
            var IdUsuario = Convert.ToInt32(cmbFuncionarios.SelectedValue);


            if (String.IsNullOrWhiteSpace(Senha) || String.IsNullOrWhiteSpace(SenhaConfimacao) || cmbFuncionarios.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Preencha corretamente todos os campos!",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (Senha != SenhaConfimacao)
            {
                MessageBox.Show(
                    "A nova senha não condiz com a confirmação da senha",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            var AlterarSenha = new UsuarioBD().AlterarSenha(SessaoUsuario.Usuario.Email, null, Senha, IdUsuario);

            if (!AlterarSenha)
            {
                MessageBox.Show(
                    "Não foi possível alterar a senha do usuário! Tente novamente ou contacte o programador",
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
    }
}
