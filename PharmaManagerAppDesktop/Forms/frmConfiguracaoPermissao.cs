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
using static PharmaManagerAppDesktop.Forms.frmConfiguracaoAtivarDesativarUsuario;

namespace PharmaManagerAppDesktop.Forms
{
    public partial class frmConfiguracaoPermissao : Form
    {
        public frmConfiguracaoPermissao()
        {
            InitializeComponent();
        }

        public class PermissaoComboBox
        {
            public int IdPermissao {  get; set; }
            public string Nome {  get; set; }
        }

        public class FuncionariosComboBox
        {
            public int IdUsuario { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
        }


        List<FuncionariosComboBox> FuncionariosAtuais = new List<FuncionariosComboBox>();

        List<PermissaoComboBox> Permissoes = new List<PermissaoComboBox>()
        {
            new PermissaoComboBox
            {
                IdPermissao = 1,
                Nome = "Administrador",
            },
            new PermissaoComboBox
            {
                IdPermissao = 2,
                Nome = "Caixa",
            }
        };



        private void frmConfiguracaoPermissao_Load(object sender, EventArgs e)
        {
            cmbPermissao.ValueMember = "IdPermissao";
            cmbPermissao.DisplayMember = "Nome";
            cmbPermissao.DataSource = Permissoes;
            cmbPermissao.SelectedIndex = -1;

            var FuncionariosEncontrados = new FuncionarioBD().BuscarTodosFuncionarios().FindAll(f => f.Usuario.IdUsuario > 0).ToList();

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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int IdUsuario = Convert.ToInt32(cmbFuncionarios.SelectedValue);
            int IdPermissao = Convert.ToInt32(cmbPermissao.SelectedValue);

            var AtribuirPermissao = new PermissaoBD().AtualizarPermissao(IdUsuario, IdPermissao);

            if(AtribuirPermissao)
            {
                MessageBox.Show(
                    "Permissão atribuída com sucesso!",
                    "Mesnagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                 );

                this.Close();
                return;
            }

            MessageBox.Show(
                    "Não foi possivel atualizar a permissão! Tente novamente ou contacte o programador.",
                    "Mensagem de erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
             );

            return;
        }
    }
}
