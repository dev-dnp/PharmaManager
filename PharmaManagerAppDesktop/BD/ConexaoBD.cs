using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PharmaManagerAppDesktop.BD
{
    public static class ConexaoBD
    {
        static string stringDeConexao = @"Data Source=localhost;
                                          Initial Catalog=PHARMA_MANAGER;
                                          Persist Security Info=False;
                                          User ID=sa;
                                          Password=MinhaSenha!123;
                                          Pooling=False;
                                          MultipleActiveResultSets=False;
                                          Encrypt=True;
                                          TrustServerCertificate=True;
                                          Application Name=SQL Server Management Studio";

        // Método para criar a conexão que será reautilizável para todo sistema!
        public static SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection(stringDeConexao);
            conexao.Open();
            return conexao;
        }
    }
}
