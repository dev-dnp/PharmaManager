using PharmaManagerAppDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public class UsuarioBD
    {

        public Usuario BuscarUsuarioPorEmailESenha(string email, string senha)
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.StringConexao))
            {
                try
                {
                    conexao.Open();

                } catch(Exception ex)
                {
                    MessageBox.Show("Falha ao conectar com a base de dados! Verifique a ligação.");
                    Console.WriteLine(ex.Message);
                    conexao.Close();
                    return null;
                }

                string query = @"SELECT TOP 1
                                ID_USUARIO, EMAIL, SENHA, FOTO
                                FROM TB_USUARIO
                                WHERE EMAIL = @email AND SENHA = @senha";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (SqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while(leitor.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                IdUsuario = leitor.GetInt32(0),
                                Email = leitor.GetString(1),
                                Senha = leitor.GetString(2),
                                Foto = leitor.IsDBNull(3) ? null : leitor.GetString(3),
                            });
                        }
                    }
                }
            }


            if (usuarios.Count == 0)
                return null;

            return usuarios[0];
        }
    }
}
