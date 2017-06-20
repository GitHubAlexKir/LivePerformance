using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkiezingRegelaar
{
    public class Connection : IConnection
    {
        public SqlConnection databaseConnection;
        public void connect()
        {
            databaseConnection = new SqlConnection("Server=mssql.fhict.local;Database=dbi361412;User Id=dbi361412;Password=Wachtwoord2;");
            databaseConnection.Open();
        }
        public void disConnect()
        {
            databaseConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return databaseConnection;
        }
    }
}
