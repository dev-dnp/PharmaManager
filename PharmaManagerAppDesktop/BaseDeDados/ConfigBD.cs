using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaManagerAppDesktop.BaseDeDados
{
    public static class ConfigBD
    {

        /*  
             EXEMPLO STRING CONEXAO: 

             @$"Server = NOME_SERVIDOR; 
             Database = NOME_BASE_DE_DADOS; 
             Integrated security=True;"
        */

        /* ----------------------------------------------------------------------
            ATRIBUTO ESTÁTICO QUE SERÁ PARTILHANDO IGUALMENTE POR TODO SISTEMA
           ---------------------------------------------------------------------- */
        public static string StringConexao { get; set; } = @"   Data Source=localhost;
                                                                Integrated Security=True;
                                                                Persist Security Info=False;
                                                                Pooling=False;
                                                                Database = PHARMA_MANAGER;
                                                                MultipleActiveResultSets=False;
                                                                Encrypt=True;
                                                                TrustServerCertificate=True;
                                                                Application Name=""SQL Server Management Studio"";";

    }
}
