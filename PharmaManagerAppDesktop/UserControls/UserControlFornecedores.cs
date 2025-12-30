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
using PharmaManagerAppDesktop.Forms;

namespace PharmaManagerAppDesktop.UserControls
{
    public partial class UserControlFornecedores : UserControl
    {

        public class VisualizacaoTabela
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Nif { get; set; }
            public string Tel{ get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
        }

        BindingList<VisualizacaoTabela> DadosTabela = new BindingList<VisualizacaoTabela>();
        public UserControlFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorAdicionar frmAddFornecedor = new frmFornecedorAdicionar();
            
            if(frmAddFornecedor.ShowDialog()  == DialogResult.OK)
            {
                Atualizar();
            } 

        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            List<int> Ids = new List<int>();

            foreach(DataGridViewRow linha in dgvListaDeFornecedores.Rows)
            {
                if(Convert.ToBoolean(linha.Cells["check"].Value))
                {
                    Ids.Add(Convert.ToInt32(linha.Cells["id"].Value));
                }
            }

            if (Ids.Count == 1)
            {
                var Fornecedores = new FornecedorBD().BuscarTodosFornecedores();

                var Fornecedor = Fornecedores.Find(f => f.Fornecedor.IdFornecedor == Ids.First());

                frmFornecedorEditar janela = new frmFornecedorEditar(Fornecedor);
                
                if(janela.ShowDialog() == DialogResult.OK)
                {
                    Atualizar();
                }
            } 
            else
            {
                MessageBox.Show(
                    "Selecione um item por vez",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            
        }

        private void UserControlFornecedores_Load(object sender, EventArgs e)
        {
            Atualizar();

            dgvListaDeFornecedores.AutoGenerateColumns = false;

            id.DataPropertyName = "Id";
            nome.DataPropertyName = "Nome";
            nif.DataPropertyName = "Nif";
            tel.DataPropertyName = "Tel";
            email.DataPropertyName = "Email";
            endereco.DataPropertyName = "Endereco";

            dgvListaDeFornecedores.DataSource = DadosTabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string texto = txtCampoPesquisa.Text.Trim();
            Atualizar(texto);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtCampoPesquisa.Clear();
            Atualizar();
        }

        private void Atualizar(string pesquisa = "")
        {
            var FornecedoresBuscados = new FornecedorBD().BuscarTodosFornecedores(pesquisa);

            DadosTabela.Clear();

            foreach (var f in FornecedoresBuscados)
            {

                string EnderecoCompleto = f.Endereco.Bairro + ", " + f.Municipio.Nome + ", " + f.Provincia.Nome;

                DadosTabela.Add(new VisualizacaoTabela
                {
                    Id = f.Fornecedor.IdFornecedor,
                    Nome = f.Fornecedor.Nome,
                    Nif = f.Fornecedor.NIF,
                    Tel = f.Fornecedor.Telefone,
                    Email = f.Fornecedor.Email,
                    Endereco = f.Municipio.Nome == null ? "-" : EnderecoCompleto
                });
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<int> Ids = new List<int>();

            foreach (DataGridViewRow linha in dgvListaDeFornecedores.Rows)
            {
                if (Convert.ToBoolean(linha.Cells["check"].Value))
                {
                    Ids.Add(Convert.ToInt32(linha.Cells["id"].Value));
                }
            }

            if (Ids.Count > 0)
            {

                var Opcao = MessageBox.Show(
                    "Tem certeza que quer eliminar os produtos selecionados",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                 );

                if (Opcao == DialogResult.No) return;

                var retorno = new FornecedorBD().EliminarFornecedores(Ids);

                if (retorno)
                {
                    Atualizar();
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um item por vez",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
