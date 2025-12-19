using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public static class ConexaoBD
    {
        public static string StringConexao { get; set; } = @"Data Source=localhost;
                                                    Initial Catalog=PHARMA_MANAGER;
                                                    Persist Security Info=False;
                                                    User ID=sa;
                                                    Password=MinhaSenha!123;
                                                    Pooling=False;
                                                    MultipleActiveResultSets=False;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True;
                                                    Application Name=SQL Server Management Studio";

    }
}
