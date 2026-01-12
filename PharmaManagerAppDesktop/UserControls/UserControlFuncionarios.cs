using PharmaManagerAppDesktop.BaseDeDados;
using PharmaManagerAppDesktop.Forms;
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
    public partial class UserControlFuncionarios : UserControl
    {

        public class VisualizacaoTabelaFuncionarios
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string BilheteIdentidade { get; set; }
            public string Cargo { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
        }

        List<VisualizacaoTabelaFuncionarios> DadosTabela = new List<VisualizacaoTabelaFuncionarios>();


        public UserControlFuncionarios()
        {
            InitializeComponent();
        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioAdicionar frm = new frmFuncionarioAdicionar();

            if(frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Adicionado com sucesso!",
                    "Mensagem de confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Atualizar();
            }
        }

        private void UserControlFuncionarios_Load(object sender, EventArgs e)
        {

            var Funcionarios = new FuncionarioBD().BuscarTodosFuncionarios();

            foreach(var Funcionario in  Funcionarios)
            {
                string endereco = Funcionario.Endereco.Bairro + ", " + Funcionario.Municipio.Nome + ", " + Funcionario.Provincia.Nome;
                DadosTabela.Add(new VisualizacaoTabelaFuncionarios
                {
                    Nome = Funcionario.Funcionario.Nome,
                    BilheteIdentidade = Funcionario.Funcionario.BilheteIdentidade,
                    Cargo = Funcionario.Cargo.Nome,
                    Email = Funcionario.Funcionario.Email,
                    Id = Funcionario.Funcionario.IdFuncionario,
                    Telefone = Funcionario.Funcionario.Telefone,
                    Endereco = endereco
                });
            }


            dgvListaFuncionarios.AutoGenerateColumns = false;

            colId.DataPropertyName = "Id";
            colNome.DataPropertyName = "Nome";
            colBilheteIdentidade.DataPropertyName = "BilheteIdentidade";
            colCargo.DataPropertyName = "Cargo";
            colTelefone.DataPropertyName = "Telefone";
            colEmail.DataPropertyName = "Email";
            colEndereco.DataPropertyName = "Endereco";

            dgvListaFuncionarios.DataSource = null;
            dgvListaFuncionarios.DataSource = DadosTabela;
        }

        private void Atualizar()
        {
            DadosTabela.Clear();

            string pesquisa = txtCampoPesquisa.Text.Trim();

            var Funcionarios = new FuncionarioBD().BuscarTodosFuncionarios(pesquisa);

            foreach (var Funcionario in Funcionarios)
            {
                string endereco = Funcionario.Endereco.Bairro + ", " + Funcionario.Municipio.Nome + ", " + Funcionario.Provincia.Nome;

                DadosTabela.Add(new VisualizacaoTabelaFuncionarios
                {
                    Nome = Funcionario.Funcionario.Nome,
                    BilheteIdentidade = Funcionario.Funcionario.BilheteIdentidade,
                    Cargo = Funcionario.Cargo.Nome,
                    Email = Funcionario.Funcionario.Email,
                    Id = Funcionario.Funcionario.IdFuncionario,
                    Telefone = Funcionario.Funcionario.Telefone,
                    Endereco = endereco
                });
            }

            dgvListaFuncionarios.DataSource = null;
            dgvListaFuncionarios.DataSource = DadosTabela;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtCampoPesquisa.Clear();
            Atualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvListaFuncionarios.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colId"].Value));
                }
            }

            if (IdsSelecionados.Count == 1)
            {
                var Funcionario = new FuncionarioBD().BuscarFuncionarioPorId(IdsSelecionados.First());

                frmFuncionarioEditar frm = new frmFuncionarioEditar(Funcionario);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Editado com sucesso!",
                        "Mensagem de confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Atualizar();
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item por vez",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var IdsSelecionados = new List<int>();

            foreach (DataGridViewRow linha in dgvListaFuncionarios.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells["check"].Value);

                if (selecionado)
                {
                    IdsSelecionados.Add(Convert.ToInt32(linha.Cells["colId"].Value));
                }
            }

            if (IdsSelecionados.Count > 0)
            {

                var resposta = MessageBox.Show(
                    "Tem certeza que quer eliminar os registos selecionados?",
                    "Mensagem de alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if(resposta == DialogResult.No) return;

                bool retorno = new FuncionarioBD().EliminarFuncionario(IdsSelecionados);

                if (retorno)
                {
                    MessageBox.Show(
                        "Registo eliminado com sucesso!",
                        "Mensagem de confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Atualizar();
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione pelo menos um item",
                    "Mensagem de alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
