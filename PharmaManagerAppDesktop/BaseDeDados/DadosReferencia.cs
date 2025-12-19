using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public static class DadosReferencia
    {
        public static List<Cargo> Cargos = new List<Cargo>();
        public static List<Categoria> Categorias = new List<Categoria>();
        public static List<EstadoFatura> EstadosFatura = new List<EstadoFatura>();
        public static List<MetodoPagamento> MetodosPagamento = new List<MetodoPagamento>();
        public static List<Provincia> Provincias = new List<Provincia>();
        public static List<Permissao> Permissoes = new List<Permissao>();
        

        public static void BuscarCargos()
        {
            Cargos.Clear();

            using(SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();
                
                string query = "SELECT ID_CARGO, TITULO, DESCRICAO FROM TB_CARGO";

                using(SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using(SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while(leitor.Read())
                        {
                            Cargos.Add(new Cargo
                            {
                                IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                Titulo = leitor.IsDBNull(leitor.GetOrdinal("TITULO")) ? null : leitor.GetString(leitor.GetOrdinal("TITULO")),
                                Descricao = leitor.IsDBNull(leitor.GetOrdinal("DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("DESCRICAO")),
                            });
                        }
                    }
                }
            }

        }


        public static void BuscarMetodosPagamento()
        {
            MetodosPagamento.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_METODO_PAGAMENTO, METODO_PAGAMENTO FROM TB_METODO_PAGAMENTO";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            MetodosPagamento.Add(new MetodoPagamento
                            {
                                IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                Metodo = leitor.IsDBNull(leitor.GetOrdinal("METODO_PAGAMENTO")) ? null : leitor.GetString(leitor.GetOrdinal("METODO_PAGAMENTO")),
                            });
                        }
                    }
                }
            }

        }
    }
}
