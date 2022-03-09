using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WebAppArticulos.DAO
{
    public class ConexionBD
    {
        private const string CADENA = "Server=(localdb)\\MSSqlLocalDb;Database=ArticulosDBAccenture;Trusted_Connection=True;";

        public static SqlConnection connection = new SqlConnection(CADENA);
    }
}
