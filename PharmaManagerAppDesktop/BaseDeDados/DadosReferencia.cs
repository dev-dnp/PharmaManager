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
        /* --------------------------------------------------------------------------
            DADOS ESTÁTICOS QUE SERÃO CONSUMIDOS CONSTANTEMENTE POR TODA APLICAÇÃO
           --------------------------------------------------------------------------- */


        public static List<CargoEntidade> Cargos = new List<CargoEntidade>();
        public static List<CategoriaEntidade> CategoriasProduto = new List<CategoriaEntidade>();
        public static List<EstadoFaturaEntidade> EstadosFatura = new List<EstadoFaturaEntidade>();
        public static List<MetodoPagamentoEntidade> MetodosPagamento = new List<MetodoPagamentoEntidade>();
        public static List<ProvinciaEntidade> Provincias = new List<ProvinciaEntidade>();
        public static List<MunicipioEntidade> Municipios = new List<MunicipioEntidade>();
        public static List<PermissaoEntidade> Permissoes = new List<PermissaoEntidade>();
        

        public static void BuscarCargos()
        {
            Cargos = new CargoBD().BuscarTodos();
        }

        public static void BuscarCategoriasProdutos()
        {
            CategoriasProduto = new CategoriaProdutoBD().BuscarTodas();
        }

        public static void BuscarMetodosPagamento()
        {
            MetodosPagamento.Clear();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_METODO_PAGAMENTO, NOME FROM TB_METODO_PAGAMENTO";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                MetodosPagamento.Add(new MetodoPagamentoEntidade
                                {
                                    IdMetodoPagamento = leitor.IsDBNull(leitor.GetOrdinal("ID_METODO_PAGAMENTO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_METODO_PAGAMENTO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar os metodos de pagamentos disponiveis");
                Console.WriteLine("Mensagem de erro: " + ex);
            }
        }

        public static void BuscarEstadoFatura()
        {

            try
            {
                EstadosFatura.Clear();

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_ESTADO_FATURA, NOME FROM TB_ESTADO_FATURA";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                EstadosFatura.Add(new EstadoFaturaEntidade
                                {
                                    IdEstadoFatura = leitor.IsDBNull(leitor.GetOrdinal("ID_ESTADO_FATURA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ESTADO_FATURA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar os estados da fatura");
                Console.WriteLine("Mensagem de erro: " + ex);
            }

        }

        public static void BuscarProvincias()
        {

            try
            {
                Provincias.Clear();

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_PROVINCIA, NOME FROM TB_PROVINCIA";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Provincias.Add(new ProvinciaEntidade
                                {
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar todas as províncias");
                Console.WriteLine("Mensagem de erro: " + ex);
            }

        }

        public static void BuscarMunicipios()
        {

            try
            {
                Municipios.Clear();

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_MUNICIPIO, NOME, ID_PROVINCIA FROM TB_MUNICIPIO";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Municipios.Add(new MunicipioEntidade
                                {
                                    IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar todos municípios");
                Console.WriteLine("Mensagem de erro: " + ex);
            }

        }

        public static void BuscarPermissoes()
        {

            try
            {
                Permissoes.Clear();

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_PERMISSAO, NOME FROM TB_PERMISSAO";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Permissoes.Add(new PermissaoEntidade
                                {
                                    IdPermissao = leitor.IsDBNull(leitor.GetOrdinal("ID_PERMISSAO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PERMISSAO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar todas permissões");
                Console.WriteLine("Mensagem de erro: " + ex);
            }

        }
    
        public static void AtualizarTodasReferencias()
        {
            DadosReferencia.BuscarMetodosPagamento();
            DadosReferencia.BuscarProvincias();
            DadosReferencia.BuscarMunicipios();
            DadosReferencia.BuscarCargos();
            DadosReferencia.BuscarCategoriasProdutos();
            DadosReferencia.BuscarEstadoFatura();
            DadosReferencia.BuscarPermissoes();
        }
    }
}
