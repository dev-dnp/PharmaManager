using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class FornecedorBD
    {
        public class DadosFornecedor
        {
            public FornecedorEntidade Fornecedor { get; set; } = new FornecedorEntidade();
            public EnderecoEntidade Endereco { get; set; } = new EnderecoEntidade();
            public MunicipioEntidade Municipio { get; set; } = new MunicipioEntidade();
            public ProvinciaEntidade Provincia { get; set; } = new ProvinciaEntidade();
        }

        


        public bool AdicionarFornecedor(DadosFornecedor dados)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"INSERT INTO TB_ENDERECO (ID_MUNICIPIO, BAIRRO) VALUES (@idMunicipio, @bairro) SELECT SCOPE_IDENTITY();";

                    int IdEndereco = 0;

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idMunicipio", dados.Endereco.IdMunicipio);
                        cmd.Parameters.AddWithValue("@bairro", dados.Endereco.Bairro);

                        IdEndereco = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string query2 = @"INSERT INTO TB_FORNECEDOR
                                    (NOME, NIF, ID_ENDERECO, TELEFONE, EMAIL)
                                  VALUES
                                    (@nome, @nif, @idEndereco, @telefone, @email)
                                 ";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conexao))
                    {
                        cmd2.Parameters.AddWithValue("@nome", dados.Fornecedor.Nome);
                        cmd2.Parameters.AddWithValue("@nif", dados.Fornecedor.NIF);
                        cmd2.Parameters.AddWithValue("@idEndereco", IdEndereco);
                        cmd2.Parameters.AddWithValue("@telefone", dados.Fornecedor.Telefone);
                        cmd2.Parameters.AddWithValue("@email", dados.Fornecedor.Email);

                        cmd2.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao adiconar o fornecedor: " + ex.Message);
                return false;
            }


        }
    
        public List<DadosFornecedor> BuscarTodosFornecedores(string? pesquisa = "")
        {

            List<DadosFornecedor> Fornecedores = new List<DadosFornecedor>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT 
                                        forn.ID_FORNECEDOR,
                                        forn.NOME,
                                        forn.NIF,
                                        forn.EMAIL,
                                        forn.TELEFONE,

                                        ende.ID_ENDERECO,
                                        ende.BAIRRO AS ENDERECO_BAIRRO_NOME,

                                        mun.ID_MUNICIPIO,
                                        mun.NOME AS MUNICIPIO_NOME,

                                        prov.ID_PROVINCIA,
                                        prov.NOME AS PROVINCIA_NOME
  
                                    FROM TB_FORNECEDOR forn
                                    LEFT JOIN TB_ENDERECO ende
                                        ON forn.ID_ENDERECO = ende.ID_ENDERECO
                                    LEFT JOIN TB_MUNICIPIO mun
                                        ON mun.ID_MUNICIPIO = ende.ID_MUNICIPIO
                                    LEFT JOIN TB_PROVINCIA prov
                                        ON mun.ID_PROVINCIA = prov.ID_PROVINCIA
                                    WHERE
                                    forn.ID_FORNECEDOR LIKE @pesquisa OR
                                    forn.NOME LIKE @pesquisa OR
                                    forn.NIF LIKE @pesquisa OR
                                    forn.EMAIL LIKE @pesquisa OR
                                    forn.TELEFONE LIKE @pesquisa
";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                        using(SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while(leitor.Read())
                            {
                                Fornecedores.Add(new DadosFornecedor
                                {
                                    Fornecedor =
                                    {
                                        IdFornecedor = leitor.IsDBNull(leitor.GetOrdinal("ID_FORNECEDOR")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_FORNECEDOR")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("NOME")),
                                        NIF = leitor.IsDBNull(leitor.GetOrdinal("NIF")) ? "-" : leitor.GetString(leitor.GetOrdinal("NIF")),
                                        Email = leitor.IsDBNull(leitor.GetOrdinal("EMAIL")) ? "-" : leitor.GetString(leitor.GetOrdinal("EMAIL")),
                                        Telefone = leitor.IsDBNull(leitor.GetOrdinal("TELEFONE")) ? "-" : leitor.GetString(leitor.GetOrdinal("TELEFONE")),
                                    },
                                    Endereco =
                                    {
                                        Bairro = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_BAIRRO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("ENDERECO_BAIRRO_NOME")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                    },
                                    Municipio =
                                    {
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("MUNICIPIO_NOME")),
                                    },
                                    Provincia =
                                    {
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("PROVINCIA_NOME")) ? "-" : leitor.GetString(leitor.GetOrdinal("PROVINCIA_NOME")),
                                    }

                                });
                            }
                        }
                    }

                }

                return Fornecedores;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar o fornecedor: " + ex.Message);
                return null;
            }
        }
    }
}
