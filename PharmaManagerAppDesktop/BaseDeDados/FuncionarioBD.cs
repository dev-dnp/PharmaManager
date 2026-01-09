using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using PharmaManagerAppDesktop.Entidades;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class FuncionarioBD
    {

        public class DadosFuncionario
        {
            public UsuarioEntidade Usuario = new UsuarioEntidade();
            public FuncionarioEntidade Funcionario = new FuncionarioEntidade();
            public CargoEntidade Cargo = new CargoEntidade();
            public EnderecoEntidade Endereco = new EnderecoEntidade();
            public ProvinciaEntidade Provincia = new ProvinciaEntidade();
            public MunicipioEntidade Municipio = new MunicipioEntidade();
            public PermissaoEntidade Permissao = new PermissaoEntidade();
        }

        public DadosFuncionario BuscarUmFuncionarioPorIdUsuario(int idUsuario)
        {
            List<DadosFuncionario> funcionarios = new List<DadosFuncionario>();

            using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
            {
                conexao.Open();

                string query = @"SELECT TOP 1
                                fun.ID_FUNCIONARIO,
                                fun.NOME AS FUNCIONARIO_NOME,
                                fun.BILHETE_IDENTIDADE  AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                fun.DATA_NASCIMENTO  AS FUNCIONARIO_DATA_NASCIMENTO,
                                fun.ID_USUARIO  AS FUNCIONARIO_ID_USUARIO,
                                fun.ID_CARGO  AS FUNCIONARIO_ID_CARGO,
                                fun.ID_ENDERECO  AS FUNCIONARIO_ID_ENDERECO, 
                                fun.TELEFONE  AS FUNCIONARIO_TELEFONE,
                                fun.EMAIL AS FUNCIONARIO_EMAIL,

                                usu.ID_USUARIO,
                                usu.EMAIL  AS USUARIO_EMAIL,
                                usu.SENHA  AS USUARIO_SENHA,
                                usu.FOTO  AS USUARIO_FOTO,

                                car.ID_CARGO,
                                car.NOME  AS CARGO_NOME,
                                car.DESCRICAO AS CARGO_DESCRICAO,

                                e.ID_ENDERECO,
                                e.BAIRRO AS ENDERECO_BAIRRO,
                                e.ID_MUNICIPIO AS ENDERECO_ID_MUNICIPIO,

                                mun.ID_MUNICIPIO,
                                mun.NOME AS MUNICIPIO_NOME,
                                mun.ID_PROVINCIA AS MUNICIPIO_ID_PROVINCIA,

                                prov.ID_PROVINCIA,
                                prov.NOME AS PROVINCIA_NOME,

                                perm.PERMISSOES

                                FROM TB_FUNCIONARIO fun

                                LEFT JOIN TB_USUARIO usu
                                    ON fun.ID_USUARIO = usu.ID_USUARIO
  
                                LEFT JOIN TB_CARGO car
                                    ON fun.ID_CARGO = car.ID_CARGO
  
                                LEFT JOIN TB_ENDERECO e
                                    ON fun.ID_ENDERECO = e.ID_ENDERECO
  
                                LEFT JOIN TB_MUNICIPIO mun
                                    ON e.ID_MUNICIPIO = mun.ID_MUNICIPIO
  
                                LEFT JOIN TB_PROVINCIA prov
                                    ON mun.ID_PROVINCIA = prov.ID_PROVINCIA
  
                                LEFT JOIN TB_USUARIO_PERMISSAO uperm
                                    ON usu.ID_USUARIO = uperm.ID_USUARIO
  
                                LEFT JOIN (
                                    SELECT
                                        up.ID_USUARIO,
                                        STRING_AGG(p.NOME, ', ') AS PERMISSOES
                                    FROM TB_USUARIO_PERMISSAO up
                                    JOIN TB_PERMISSAO p ON up.ID_PERMISSAO = p.ID_PERMISSAO
                                    GROUP BY up.ID_USUARIO
                                ) perm ON perm.ID_USUARIO = usu.ID_USUARIO

  
                                WHERE fun.ID_USUARIO = @idUsuario;";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            funcionarios.Add(new DadosFuncionario
                            {
                                Usuario = new UsuarioEntidade
                                {
                                    IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ?  0 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_EMAIL")),
                                    Senha = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_SENHA")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_SENHA")),
                                    Foto = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_FOTO")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_FOTO")),
                                },

                                Funcionario = new FuncionarioEntidade 
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    DataNascimento =  leitor.GetDateTime(leitor.GetOrdinal("FUNCIONARIO_DATA_NASCIMENTO")),
                                    IdUsuario  = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")),
                                    IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),

                                },

                                Cargo = new CargoEntidade
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                    Descricao = leitor.IsDBNull(leitor.GetOrdinal("CARGO_DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_DESCRICAO")),
                                },

                                Endereco = new EnderecoEntidade
                                {
                                    Bairro = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_BAIRRO")) ? null : leitor.GetString(leitor.GetOrdinal("ENDERECO_BAIRRO")),
                                    IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                    IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")),
                                },

                                Municipio = new MunicipioEntidade
                                {
                                    IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("MUNICIPIO_NOME")),
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")),
                                },

                                Provincia = new ProvinciaEntidade
                                {
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PROVINCIA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PROVINCIA_NOME")),
                                },

                                Permissao = new PermissaoEntidade
                                {
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PERMISSOES")) ? null : leitor.GetString(leitor.GetOrdinal("PERMISSOES"))
                                }

                            });
                        }
                    }
                }
            }


            if (funcionarios.Count == 0)
                return null;

            return funcionarios.First();
        }

        public DadosFuncionario BuscarFuncionarioPorId(int idFuncionario)
        {
            List<DadosFuncionario> funcionarios = new List<DadosFuncionario>();

            using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
            {
                conexao.Open();

                string query = @"SELECT TOP 1
                                fun.ID_FUNCIONARIO,
                                fun.NOME AS FUNCIONARIO_NOME,
                                fun.BILHETE_IDENTIDADE  AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                fun.DATA_NASCIMENTO  AS FUNCIONARIO_DATA_NASCIMENTO,
                                fun.ID_USUARIO  AS FUNCIONARIO_ID_USUARIO,
                                fun.ID_CARGO  AS FUNCIONARIO_ID_CARGO,
                                fun.ID_ENDERECO  AS FUNCIONARIO_ID_ENDERECO, 
                                fun.TELEFONE  AS FUNCIONARIO_TELEFONE,
                                fun.EMAIL AS FUNCIONARIO_EMAIL,

                                usu.ID_USUARIO,
                                usu.EMAIL  AS USUARIO_EMAIL,
                                usu.SENHA  AS USUARIO_SENHA,
                                usu.FOTO  AS USUARIO_FOTO,

                                car.ID_CARGO,
                                car.NOME  AS CARGO_NOME,
                                car.DESCRICAO AS CARGO_DESCRICAO,

                                e.ID_ENDERECO,
                                e.BAIRRO AS ENDERECO_BAIRRO,
                                e.ID_MUNICIPIO AS ENDERECO_ID_MUNICIPIO,

                                mun.ID_MUNICIPIO,
                                mun.NOME AS MUNICIPIO_NOME,
                                mun.ID_PROVINCIA AS MUNICIPIO_ID_PROVINCIA,

                                prov.ID_PROVINCIA,
                                prov.NOME AS PROVINCIA_NOME,

                                perm.PERMISSOES

                                FROM TB_FUNCIONARIO fun

                                LEFT JOIN TB_USUARIO usu
                                    ON fun.ID_USUARIO = usu.ID_USUARIO
  
                                LEFT JOIN TB_CARGO car
                                    ON fun.ID_CARGO = car.ID_CARGO
  
                                LEFT JOIN TB_ENDERECO e
                                    ON fun.ID_ENDERECO = e.ID_ENDERECO
  
                                LEFT JOIN TB_MUNICIPIO mun
                                    ON e.ID_MUNICIPIO = mun.ID_MUNICIPIO
  
                                LEFT JOIN TB_PROVINCIA prov
                                    ON mun.ID_PROVINCIA = prov.ID_PROVINCIA
  
                                LEFT JOIN TB_USUARIO_PERMISSAO uperm
                                    ON usu.ID_USUARIO = uperm.ID_USUARIO
  
                                LEFT JOIN (
                                    SELECT
                                        up.ID_USUARIO,
                                        STRING_AGG(p.NOME, ', ') AS PERMISSOES
                                    FROM TB_USUARIO_PERMISSAO up
                                    JOIN TB_PERMISSAO p ON up.ID_PERMISSAO = p.ID_PERMISSAO
                                    GROUP BY up.ID_USUARIO
                                ) perm ON perm.ID_USUARIO = usu.ID_USUARIO

  
                                WHERE fun.ID_FUNCIONARIO = @idFuncionario";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);

                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            funcionarios.Add(new DadosFuncionario
                            {
                                Usuario = new UsuarioEntidade
                                {
                                    IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_EMAIL")),
                                    Senha = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_SENHA")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_SENHA")),
                                    Foto = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_FOTO")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_FOTO")),
                                },

                                Funcionario = new FuncionarioEntidade
                                {
                                    IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                    BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                    DataNascimento = leitor.GetDateTime(leitor.GetOrdinal("FUNCIONARIO_DATA_NASCIMENTO")),
                                    IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")),
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")),
                                    IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")),
                                    Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                    Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),

                                },

                                Cargo = new CargoEntidade
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                    Descricao = leitor.IsDBNull(leitor.GetOrdinal("CARGO_DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_DESCRICAO")),
                                },

                                Endereco = new EnderecoEntidade
                                {
                                    Bairro = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_BAIRRO")) ? null : leitor.GetString(leitor.GetOrdinal("ENDERECO_BAIRRO")),
                                    IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                    IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")),
                                },

                                Municipio = new MunicipioEntidade
                                {
                                    IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("MUNICIPIO_NOME")),
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")),
                                },

                                Provincia = new ProvinciaEntidade
                                {
                                    IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PROVINCIA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PROVINCIA_NOME")),
                                },

                                Permissao = new PermissaoEntidade
                                {
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("PERMISSOES")) ? null : leitor.GetString(leitor.GetOrdinal("PERMISSOES"))
                                }

                            });
                        }
                    }
                }
            }


            if (funcionarios.Count == 0)
                return null;

            return funcionarios.First();
        }

        public DadosFuncionario BuscarFuncionarioNumeroBilheteIdentidade(string numeroBilheteIdentidade)
        {
            List<DadosFuncionario> funcionarios = new List<DadosFuncionario>();

            try
            {

                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT TOP 1
                                    fun.ID_FUNCIONARIO,
                                    fun.NOME AS FUNCIONARIO_NOME,
                                    fun.BILHETE_IDENTIDADE  AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                    fun.DATA_NASCIMENTO  AS FUNCIONARIO_DATA_NASCIMENTO,
                                    fun.ID_USUARIO  AS FUNCIONARIO_ID_USUARIO,
                                    fun.ID_CARGO  AS FUNCIONARIO_ID_CARGO,
                                    fun.ID_ENDERECO  AS FUNCIONARIO_ID_ENDERECO, 
                                    fun.TELEFONE  AS FUNCIONARIO_TELEFONE,
                                    fun.EMAIL AS FUNCIONARIO_EMAIL,

                                    usu.ID_USUARIO,
                                    usu.EMAIL  AS USUARIO_EMAIL,
                                    usu.SENHA  AS USUARIO_SENHA,
                                    usu.FOTO  AS USUARIO_FOTO,

                                    car.ID_CARGO,
                                    car.NOME  AS CARGO_NOME,
                                    car.DESCRICAO AS CARGO_DESCRICAO,

                                    e.ID_ENDERECO,
                                    e.BAIRRO AS ENDERECO_BAIRRO,
                                    e.ID_MUNICIPIO AS ENDERECO_ID_MUNICIPIO,

                                    mun.ID_MUNICIPIO,
                                    mun.NOME AS MUNICIPIO_NOME,
                                    mun.ID_PROVINCIA AS MUNICIPIO_ID_PROVINCIA,

                                    prov.ID_PROVINCIA,
                                    prov.NOME AS PROVINCIA_NOME,

                                    perm.PERMISSOES

                                    FROM TB_FUNCIONARIO fun

                                    LEFT JOIN TB_USUARIO usu
                                        ON fun.ID_USUARIO = usu.ID_USUARIO
  
                                    LEFT JOIN TB_CARGO car
                                        ON fun.ID_CARGO = car.ID_CARGO
  
                                    LEFT JOIN TB_ENDERECO e
                                        ON fun.ID_ENDERECO = e.ID_ENDERECO
  
                                    LEFT JOIN TB_MUNICIPIO mun
                                        ON e.ID_MUNICIPIO = mun.ID_MUNICIPIO
  
                                    LEFT JOIN TB_PROVINCIA prov
                                        ON mun.ID_PROVINCIA = prov.ID_PROVINCIA
  
                                    LEFT JOIN TB_USUARIO_PERMISSAO uperm
                                        ON usu.ID_USUARIO = uperm.ID_USUARIO
  
                                    LEFT JOIN (
                                        SELECT
                                            up.ID_USUARIO,
                                            STRING_AGG(p.NOME, ', ') AS PERMISSOES
                                        FROM TB_USUARIO_PERMISSAO up
                                        JOIN TB_PERMISSAO p ON up.ID_PERMISSAO = p.ID_PERMISSAO
                                        GROUP BY up.ID_USUARIO
                                    ) perm ON perm.ID_USUARIO = usu.ID_USUARIO

  
                                    WHERE fun.BILHETE_IDENTIDADE = @numeroBilheteIdentidade AND fun.ATIVO = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@numeroBilheteIdentidade", numeroBilheteIdentidade);

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                funcionarios.Add(new DadosFuncionario
                                {
                                    Usuario = new UsuarioEntidade
                                    {
                                        IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                        Email = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_EMAIL")),
                                        Senha = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_SENHA")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_SENHA")),
                                        Foto = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_FOTO")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_FOTO")),
                                    },

                                    Funcionario = new FuncionarioEntidade
                                    {
                                        IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                        BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                        DataNascimento = leitor.GetDateTime(leitor.GetOrdinal("FUNCIONARIO_DATA_NASCIMENTO")),
                                        IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_USUARIO")),
                                        IdCargo = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_CARGO")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("FUNCIONARIO_ID_ENDERECO")),
                                        Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                        Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),

                                    },

                                    Cargo = new CargoEntidade
                                    {
                                        IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                        Descricao = leitor.IsDBNull(leitor.GetOrdinal("CARGO_DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_DESCRICAO")),
                                    },

                                    Endereco = new EnderecoEntidade
                                    {
                                        Bairro = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_BAIRRO")) ? null : leitor.GetString(leitor.GetOrdinal("ENDERECO_BAIRRO")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ENDERECO_ID_MUNICIPIO")),
                                    },

                                    Municipio = new MunicipioEntidade
                                    {
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("MUNICIPIO_NOME")),
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("MUNICIPIO_ID_PROVINCIA")),
                                    },

                                    Provincia = new ProvinciaEntidade
                                    {
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("PROVINCIA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PROVINCIA_NOME")),
                                    },

                                    Permissao = new PermissaoEntidade
                                    {
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("PERMISSOES")) ? null : leitor.GetString(leitor.GetOrdinal("PERMISSOES"))
                                    }

                                });
                            }
                        }
                    }
                }


                if (funcionarios.Count == 0) return null;
                return funcionarios.First();

            }
            catch(Exception ex) {
                Console.WriteLine("Falha ao pegar funcionarios por numero do bilhete de identidade: " + ex.Message);
                return null; 
            }

        }

        public List<DadosFuncionario> BuscarTodosFuncionarios(string pesquisa = "")
        {
            List<DadosFuncionario> funcionarios = new List<DadosFuncionario>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"SELECT

                                  fun.NOME AS FUNCIONARIO_NOME,
                                  fun.TELEFONE AS FUNCIONARIO_TELEFONE,
                                  fun.EMAIL AS FUNCIONARIO_EMAIL,
                                  fun.BILHETE_IDENTIDADE AS FUNCIONARIO_BILHETE_IDENTIDADE,
                                  fun.DATA_NASCIMENTO AS FUNCIONARIO_DATA_NASCIMENTO,
                                  fun.ATIVO AS FUNCIONARIO_ATIVO,

                                  fun.ID_CARGO,
                                  fun.ID_ENDERECO,
                                  fun.ID_FUNCIONARIO,
                                  fun.ID_USUARIO,

                                  cg.NOME AS CARGO_NOME,
                                  cg.DESCRICAO AS CARGO_DESCRICAO,

                                  ende.BAIRRO AS ENDERECO_BAIRRO,

                                  mun.ID_MUNICIPIO,
                                  mun.NOME AS MUNICIPIO_NOME,

                                  prov.ID_PROVINCIA,
                                  prov.NOME AS PROVINCIA_NOME,

                                  usu.ATIVO AS USUARIO_ATIVO,
                                  usu.FOTO AS USUARIO_FOTO

                                FROM TB_FUNCIONARIO fun
                                JOIN TB_CARGO cg
                                  ON cg.ID_CARGO = fun.ID_CARGO
                                LEFT JOIN TB_ENDERECO ende
                                  ON fun.ID_ENDERECO = ende.ID_ENDERECO
                                LEFT JOIN TB_MUNICIPIO mun
                                  ON mun.ID_MUNICIPIO = ende.ID_MUNICIPIO
                                LEFT JOIN TB_PROVINCIA prov
                                  ON prov.ID_PROVINCIA = mun.ID_PROVINCIA
                                LEFT JOIN TB_USUARIO usu
                                  ON usu.ID_USUARIO = fun.ID_USUARIO

                                WHERE 
                                    (
                                        fun.NOME LIKE @pesquisa OR
                                        fun.TELEFONE LIKE @pesquisa OR
                                        fun.EMAIL LIKE @pesquisa OR
                                        fun.BILHETE_IDENTIDADE LIKE @pesquisa 
                                    ) 
                                AND 
                                    (
                                        fun.ATIVO = @ativo
                                    )
                            ";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {

                        cmd.Parameters.AddWithValue("@ativo", 1);
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                funcionarios.Add(new DadosFuncionario
                                {
                                    Usuario = new UsuarioEntidade
                                    {
                                        IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? 0 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                        Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),
                                        Foto = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_FOTO")) ? null : leitor.GetString(leitor.GetOrdinal("USUARIO_FOTO")),
                                        Ativo = leitor.IsDBNull(leitor.GetOrdinal("USUARIO_ATIVO")) ? false : leitor.GetBoolean(leitor.GetOrdinal("USUARIO_ATIVO"))
                                    },

                                    Funcionario = new FuncionarioEntidade
                                    {
                                        IdFuncionario = leitor.IsDBNull(leitor.GetOrdinal("ID_FUNCIONARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_FUNCIONARIO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_NOME")),
                                        BilheteIdentidade = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_BILHETE_IDENTIDADE")),
                                        DataNascimento = leitor.GetDateTime(leitor.GetOrdinal("FUNCIONARIO_DATA_NASCIMENTO")),
                                        IdUsuario = leitor.IsDBNull(leitor.GetOrdinal("ID_USUARIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_USUARIO")),
                                        IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                        Telefone = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_TELEFONE")),
                                        Email = leitor.IsDBNull(leitor.GetOrdinal("FUNCIONARIO_EMAIL")) ? null : leitor.GetString(leitor.GetOrdinal("FUNCIONARIO_EMAIL")),

                                    },

                                    Cargo = new CargoEntidade
                                    {
                                        IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("CARGO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_NOME")),
                                        Descricao = leitor.IsDBNull(leitor.GetOrdinal("CARGO_DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("CARGO_DESCRICAO")),
                                    },

                                    Endereco = new EnderecoEntidade
                                    {
                                        Bairro = leitor.IsDBNull(leitor.GetOrdinal("ENDERECO_BAIRRO")) ? null : leitor.GetString(leitor.GetOrdinal("ENDERECO_BAIRRO")),
                                        IdEndereco = leitor.IsDBNull(leitor.GetOrdinal("ID_ENDERECO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_ENDERECO")),
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                    },

                                    Municipio = new MunicipioEntidade
                                    {
                                        IdMunicipio = leitor.IsDBNull(leitor.GetOrdinal("ID_MUNICIPIO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_MUNICIPIO")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("MUNICIPIO_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("MUNICIPIO_NOME")),
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                    },

                                    Provincia = new ProvinciaEntidade
                                    {
                                        IdProvincia = leitor.IsDBNull(leitor.GetOrdinal("ID_PROVINCIA")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_PROVINCIA")),
                                        Nome = leitor.IsDBNull(leitor.GetOrdinal("PROVINCIA_NOME")) ? null : leitor.GetString(leitor.GetOrdinal("PROVINCIA_NOME")),
                                    },

                                });
                            }
                        }
                    }
                }

                return funcionarios;

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro ao buscar todos os funcionários: " + ex.Message);
                return null;
            }

            
        }

        public bool EditarFuncionario(DadosFuncionario dados)
        {
            try
            {
                using(SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE TB_FUNCIONARIO
                                        SET
                                            NOME = @nome,
                                            BILHETE_IDENTIDADE =@bilheteIdentidade,
                                            DATA_NASCIMENTO = @dataNascimento,
                                            ID_CARGO = @idCargo,
                                            TELEFONE = @telefone,
                                            EMAIL = @email
                                        WHERE 
                                            ID_FUNCIONARIO = @idFuncionario";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idFuncionario", dados.Funcionario.IdFuncionario);
                        cmd.Parameters.AddWithValue("@nome", dados.Funcionario.Nome);
                        cmd.Parameters.AddWithValue("@bilheteIdentidade", dados.Funcionario.BilheteIdentidade);
                        cmd.Parameters.AddWithValue("@dataNascimento", dados.Funcionario.DataNascimento);
                        cmd.Parameters.AddWithValue("@idCargo", dados.Funcionario.IdCargo);
                        cmd.Parameters.AddWithValue("@email", dados.Funcionario.Email);
                        cmd.Parameters.AddWithValue("@telefone", dados.Funcionario.Telefone);

                        cmd.ExecuteNonQuery();
                    }

                    string query2 = @"UPDATE TB_ENDERECO 
                                    SET
                                    BAIRRO = @bairro,
                                    ID_MUNICIPIO = @idMunicipio
                                    WHERE
                                    ID_ENDERECO = @idEndereco
                    ";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conexao))
                    {
                        cmd2.Parameters.AddWithValue("@bairro", dados.Endereco.Bairro);
                        cmd2.Parameters.AddWithValue("@idMunicipio", dados.Endereco.IdMunicipio);
                        cmd2.Parameters.AddWithValue("@idEndereco", dados.Endereco.IdEndereco);

                        cmd2.ExecuteNonQuery();
                    }

                    return true;
                  
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Ocorreu um erro ao editar os dados do funcionário" + ex.Message);
                return false;
            }
        }

        public bool AdicionarFuncionario(DadosFuncionario dados)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    using (SqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            int IdEndereco = 0;

                            string query = "INSERT INTO TB_ENDERECO (BAIRRO, ID_MUNICIPIO) VALUES (@bairro, @idMunicipio); SELECT SCOPE_IDENTITY()";

                            using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                            {
                                cmd.Parameters.AddWithValue("@bairro", dados.Endereco.Bairro);
                                cmd.Parameters.AddWithValue("@idMunicipio", dados.Endereco.IdMunicipio);

                                IdEndereco = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            int IdUsuario = -1;

                            if (dados.Usuario.Senha != null)
                            {
                                string query2 = "INSERT INTO TB_USUARIO (EMAIL, SENHA) VALUES (@email, @senha); SELECT SCOPE_IDENTITY()";

                                using (SqlCommand cmd2 = new SqlCommand(query2, conexao, transacao))
                                {
                                    cmd2.Parameters.AddWithValue("@email", dados.Usuario.Email);
                                    cmd2.Parameters.AddWithValue("@senha", dados.Usuario.Senha);

                                    IdUsuario = Convert.ToInt32(cmd2.ExecuteScalar());
                                }
                            }

                            string query3 = @"INSERT INTO TB_FUNCIONARIO 
                                            (NOME, BILHETE_IDENTIDADE, DATA_NASCIMENTO, EMAIL, TELEFONE, ID_CARGO, ID_ENDERECO, ID_USUARIO) 
                                                VALUES 
                                            (@nome, @bilheteIdentidade, @dataNascimento, @email, @telefone, @idCargo, @idEndereco, @idUsuario)";

                            using (SqlCommand cmd3 = new SqlCommand(query3, conexao, transacao))
                            {
                                cmd3.Parameters.AddWithValue("@nome", dados.Funcionario.Nome);
                                cmd3.Parameters.AddWithValue("@bilheteIdentidade", dados.Funcionario.BilheteIdentidade);
                                cmd3.Parameters.AddWithValue("@dataNascimento", dados.Funcionario.DataNascimento);
                                cmd3.Parameters.AddWithValue("@email", dados.Funcionario.Email);
                                cmd3.Parameters.AddWithValue("@telefone", dados.Funcionario.Telefone);
                                cmd3.Parameters.AddWithValue("@idCargo", dados.Cargo.IdCargo);
                                cmd3.Parameters.AddWithValue("@idEndereco", IdEndereco);
                                cmd3.Parameters.AddWithValue("@idUsuario", IdUsuario == -1 ? (object)DBNull.Value : IdUsuario);

                                cmd3.ExecuteNonQuery();
                            }
                            transacao.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transacao.Rollback();
                            Console.WriteLine(ex.Message);
                            return false;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool EliminarFuncionario(List<int> idsFuncionarios)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = @"UPDATE
                                        TB_FUNCIONARIO
                                    SET
                                       ATIVO = 0
                                    WHERE
                                        ID_FUNCIONARIO = @idFuncionario
                    ";


                    foreach (int id in idsFuncionarios)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idFuncionario", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao eliminar o funcionário: " + ex.Message);
                if (ex.Number == 547) return false;
                return false;
            }
        }
    }
}
