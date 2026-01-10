using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class CargoBD
    {
        public List<CargoEntidade> BuscarTodos()
        {

            List<CargoEntidade> Cargos = new List<CargoEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "SELECT ID_CARGO, NOME, DESCRICAO FROM TB_CARGO WHERE ATIVO = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                Cargos.Add(new CargoEntidade
                                {
                                    IdCargo = leitor.IsDBNull(leitor.GetOrdinal("ID_CARGO")) ? -1 : leitor.GetInt32(leitor.GetOrdinal("ID_CARGO")),
                                    Nome = leitor.IsDBNull(leitor.GetOrdinal("NOME")) ? null : leitor.GetString(leitor.GetOrdinal("NOME")),
                                    Descricao = leitor.IsDBNull(leitor.GetOrdinal("DESCRICAO")) ? null : leitor.GetString(leitor.GetOrdinal("DESCRICAO")),
                                });
                            }
                        }
                    }
                }

                return Cargos;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Falha ao retonar todos cargos!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }


        public string Adicionar(string nome, string descricao)
        {

            List<CargoEntidade> Cargos = new List<CargoEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "INSERT INTO TB_CARGO (NOME, DESCRICAO) VALUES (@nome, @descricao)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao == null ? (object)DBNull.Value : descricao);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Cargo adicionado com sucesso!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao adicionar cargo!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }

        public string Eliminar(int idCargo)
        {

            List<CargoEntidade> Cargos = new List<CargoEntidade>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(ConfigBD.StringConexao))
                {
                    conexao.Open();

                    string query = "UPDATE TB_CARGO SET ATIVO = 0 WHERE ID_CARGO = @idCargo";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idCargo", idCargo);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Cargo eliminado com sucesso!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao eliminar o cargo!");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                return null;
            }
        }

    }
}
