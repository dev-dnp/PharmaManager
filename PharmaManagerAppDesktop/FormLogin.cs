using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaManagerAppDesktop.BD;

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
            LoginBD login = new LoginBD();
            var resultado = login.Autenticacao(txtEmail.Text, txtSenha.Text);

            if (resultado == null)
            {
                MessageBox.Show("Email ou senha incorreta!");
            } 
            else
            {
                var dadosUsuario = (Dictionary<string, object>)resultado["usuario"];
                var dadosFuncionario = (Dictionary<string, object>)resultado["funcionario"];

                SessaoUsuario.Funcionario = dadosFuncionario;
                SessaoUsuario.Usuario = dadosUsuario;

                FormJanelaInicial formJanelaInicial = new FormJanelaInicial();
                formJanelaInicial.ShowDialog();

                
            }
        }

    }
}
