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
        DADOS PARA SE CONECTAR À BASE DE DADOS
        ======================================================================================== */

        private static string Source= "localhost";
        private static string NomeBaseDeDados= "PHARMA_MANAGER";
        private static string Usuario= "sa";
        private static string Senha = "MinhaSenha!123";


    /*  ========================================================================================
        STRING DE CONEXÃO
        ======================================================================================== */

        public static string StringConexao { get; set; } = @$"
                                                            Data Source={Source};
                                                            Initial Catalog={NomeBaseDeDados};
                                                            User ID={Usuario};
                                                            Password={Senha};
                                                            Persist Security Info=False;
                                                            Pooling=False;
                                                            MultipleActiveResultSets=False;
                                                            Encrypt=True;
                                                            TrustServerCertificate=True;
                                                            Application Name=SQL Server Management Studio";

    }
}
