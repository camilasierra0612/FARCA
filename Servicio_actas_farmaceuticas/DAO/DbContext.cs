using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_actas_farmaceuticas.DAO
{
    internal class DbContext
    {
        // Replace "Your_Connection_String_Here" with your actual connection string
        private string connectionString = "Server=devsimontry;Database=FarmaciaCami;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
