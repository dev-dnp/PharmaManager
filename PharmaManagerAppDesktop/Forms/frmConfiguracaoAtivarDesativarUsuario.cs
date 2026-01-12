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
    public partial class frmConfiguracaoAtivarDesativarUsuario : Form
    {

        public class EstadoComboBox
        {
            public int Id {  get; set; }
            public string Nome { get; set; }
        }

        public class FuncionariosComboBox
        {
            public int IdUsuario { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
        }


        List<FuncionariosComboBox> FuncionariosAtuais = new List<FuncionariosComboBox>();

        List<EstadoComboBox> Estados = new List<EstadoComboBox>()
        {
            new EstadoComboBox
            {
                Id = 1,
                Nome = "Ativo"
            },
            new EstadoComboBox
            {
                Id = 0,
                Nome = "Inativo"
            },
        };

        public frmConfiguracaoAtivarDesativarUsuario()
        {
            InitializeComponent();
        }

        private void frmAtivarDesativarUsuario_Load(object sender, EventArgs e)
        {
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Id";
            cmbEstados.DataSource = Estados;
            cmbEstados.SelectedIndex = -1;

            var FuncionariosEncontrados = new FuncionarioBD().BuscarTodosFuncionarios().FindAll( f => f.Usuario.IdUsuario > 0).ToList();

            foreach(var Funcionario in FuncionariosEncontrados)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cmbFuncionarios.SelectedIndex == -1 || cmbEstados.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione todos os campos",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int IdUsuario = Convert.ToInt32((cmbFuncionarios.SelectedValue));
            int IdEstado = Convert.ToInt32((cmbEstados.SelectedValue));

            var AlterarEstado = new UsuarioBD().AtivarDesativarUsuario(IdUsuario, IdEstado);

            if(!AlterarEstado)
            {
                MessageBox.Show(
                    "Não foi possível alterar o estado do usuário! Tente novamente, ou contacte o programador!",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Estado alterado com sucesso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
