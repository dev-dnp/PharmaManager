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
            public int id { get; set; }
            public string nome { get; set; }
            public string nif { get; set; }
            public string tel{ get; set; }
            public string email { get; set; }
            public string endereco { get; set; }
        }

        List<VisualizacaoTabela> DadosTabela = new List<VisualizacaoTabela>();
        public UserControlFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorAdicionar frmAddFornecedor = new frmFornecedorAdicionar();
            frmAddFornecedor.ShowDialog();
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorEditar janela = new frmFornecedorEditar();
            janela.ShowDialog();
        }

        private void UserControlFornecedores_Load(object sender, EventArgs e)
        {
            var Dados = new FornecedorBD().BuscarTodosFornecedores();

            foreach(var Dado in Dados)
            {
                string Endereco = Dado.Endereco.Bairro + ", " + Dado.Municipio.Nome + ", " + Dado.Provincia.Nome;

                DadosTabela.Add(new VisualizacaoTabela
                {
                    id = Dado.Fornecedor.IdFornecedor,
                    email = Dado.Fornecedor.Email,
                    nome = Dado.Fornecedor.Nome,
                    endereco = Endereco,
                    tel= Dado.Fornecedor.Telefone,
                    nif = Dado.Fornecedor.NIF,
                    
                });
            }


            dgvListaDeFornecedores.AutoGenerateColumns = false;

            id.DataPropertyName = "id";
            email.DataPropertyName = "email";
            nome.DataPropertyName = "nome";
            endereco.DataPropertyName = "endereco";
            tel.DataPropertyName = "tel";
            nif.DataPropertyName = "nif";

            dgvListaDeFornecedores.DataSource = null;
            dgvListaDeFornecedores.DataSource = DadosTabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string texto = txtCampoPesquisa.Text.Trim();

            var Dados = new FornecedorBD().BuscarTodosFornecedores(texto);

            DadosTabela.Clear();

            foreach (var Dado in Dados)
            {
                string Endereco = Dado.Endereco.Bairro + ", " + Dado.Municipio.Nome + ", " + Dado.Provincia.Nome;

                DadosTabela.Add(new VisualizacaoTabela
                {
                    id = Dado.Fornecedor.IdFornecedor,
                    email = Dado.Fornecedor.Email,
                    nome = Dado.Fornecedor.Nome,
                    endereco = Endereco,
                    tel = Dado.Fornecedor.Telefone,
                    nif = Dado.Fornecedor.NIF,

                });
            }

            dgvListaDeFornecedores.DataSource = null;
            dgvListaDeFornecedores.DataSource = DadosTabela;
        }

        private void Atualizar()
        {
            txtCampoPesquisa.Clear();

            var Dados = new FornecedorBD().BuscarTodosFornecedores();

            DadosTabela.Clear();

            foreach (var Dado in Dados)
            {
                string Endereco = Dado.Endereco.Bairro + ", " + Dado.Municipio.Nome + ", " + Dado.Provincia.Nome;

                DadosTabela.Add(new VisualizacaoTabela
                {
                    id = Dado.Fornecedor.IdFornecedor,
                    email = Dado.Fornecedor.Email,
                    nome = Dado.Fornecedor.Nome,
                    endereco = Endereco,
                    tel = Dado.Fornecedor.Telefone,
                    nif = Dado.Fornecedor.NIF,

                });
            }

            dgvListaDeFornecedores.DataSource = null;
            dgvListaDeFornecedores.DataSource = DadosTabela;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
