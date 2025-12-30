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

        public class TodosDadosFuncionario
        {
            public Usuario Usuario;
            public FuncionarioEntidade Funcionario;
            public CargoEntidade Cargo;
            public EnderecoEntidade Endereco;
            public ProvinciaEntidade Provincia;
            public MunicipioEntidade Municipio;
            public Permissao Permissao;
        }

        public TodosDadosFuncionario BuscarUmFuncionarioPorIdUsuario(int IdUsuario)
        {
            List<TodosDadosFuncionario> funcionarios = new List<TodosDadosFuncionario>();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
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
                    cmd.Parameters.AddWithValue("@idUsuario", IdUsuario);

                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            funcionarios.Add(new TodosDadosFuncionario
                            {
                                Usuario = new Usuario
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

                                Permissao = new Permissao
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

            return funcionarios[0];
        }
    }
}
