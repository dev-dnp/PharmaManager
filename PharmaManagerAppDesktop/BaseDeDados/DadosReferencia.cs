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
        public static List<Categoria> CategoriasProduto = new List<Categoria>();
        public static List<EstadoFatura> EstadosFatura = new List<EstadoFatura>();
        public static List<MetodoPagamento> MetodosPagamento = new List<MetodoPagamento>();
        public static List<Provincia> Provincias = new List<Provincia>();
        public static List<Municipio> Municipios = new List<Municipio>();
        public static List<Permissao> Permissoes = new List<Permissao>();
        

        public static void BuscarCargos()
        {
            Cargos.Clear();

            using(SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();
                
                string query = "SELECT ID_CARGO, NOME, DESCRICAO FROM TB_CARGO";

                using(SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using(SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while(leitor.Read())
                        {
                            Cargos.Add(new Cargo
                            {
                                IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
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

                string query = "SELECT ID_METODO_PAGAMENTO, NOME FROM TB_METODO_PAGAMENTO";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            MetodosPagamento.Add(new MetodoPagamento
                            {
                                IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                            });
                        }
                    }
                }
            }
        }

        public static void BuscarCategoriasProdutos()
        {
            CategoriasProduto.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_CATEGORIA, NOME FROM TB_CATEGORIA";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            CategoriasProduto.Add(new Categoria
                            {
                                IdCategoria = leitor.IsDBNull(leitor.GetOrdinal("ID_CATEGORIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_CATEGORIA")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                            });
                        }
                    }
                }
            }
        }

        public static void BuscarEstadoFatura()
        {
            EstadosFatura.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_ESTADO_FATURA, NOME FROM TB_ESTADO_FATURA";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            EstadosFatura.Add(new EstadoFatura
                            {
                                IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                            });
                        }
                    }
                }
            }
        }

        public static void BuscarProvincias()
        {
            Provincias.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_PROVINCIA, NOME FROM TB_PROVINCIA";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Provincias.Add(new Provincia
                            {
                                IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                            });
                        }
                    }
                }
            }
        }

        public static void BuscarMunicipios()
        {
            Municipios.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_MUNICIPIO, NOME, ID_PROVINCIA FROM TB_MUNICIPIO";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Municipios.Add(new Municipio
                            {
                                IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                            });
                        }
                    }
                }
            }
        }

        public static void BuscarPermissoes()
        {
            Permissoes.Clear();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                conexao.Open();

                string query = "SELECT ID_PERMISSAO, NOME FROM TB_PERMISSAO";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Permissoes.Add(new Permissao
                            {
                                IdPermissao = leitor.IsDBNull(leitor.GetOrdinal("ID_PERMISSAO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PERMISSAO")),
                                Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                            });
                        }
                    }
                }
            }
        }
    
    }
}
