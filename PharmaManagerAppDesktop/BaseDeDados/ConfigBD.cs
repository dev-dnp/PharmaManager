using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public static class ConfigBD
    {

       /*  ========================================================================================
            EXEMPLO STRING CONEXAO: @$"Server=NOME_SERVIDOR; Database = NOME_BASE_DE_DADOS; Integrated security=True;"
           ======================================================================================== */


        /*  ========================================================================================
            STRING DE CONEXÃO
            ======================================================================================== */

        public static string StringConexao { get; set; } = @$"
                                                            Data Source=localhost,1500;
                                                            Initial Catalog=PHARMA_MANAGER;
                                                            User ID=sa;
                                                            Password=MinhaSenha!123;
                                                            Persist Security Info=False;
                                                            Pooling=False;
                                                            MultipleActiveResultSets=False;
                                                            Encrypt=True;
                                                            TrustServerCertificate=True;
                                                            Application Name=SQL Server Management Studio";

    }
}
