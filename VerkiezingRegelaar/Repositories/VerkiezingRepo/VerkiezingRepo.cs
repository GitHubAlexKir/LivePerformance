using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerkiezingRegelaar.Entities;

namespace VerkiezingRegelaar.Repositories.VerkiezingRepo
{
    public class VerkiezingRepo : IVerkiezingRepo
    {
        IConnection connection;
        public VerkiezingRepo()
        {
            this.connection = new Connection();
        }

        public List<Partij> getAllPartijen()
        {
            List<Partij> partijen = new List<Partij>();
            connection.connect();
            SqlCommand sqlCommand = new SqlCommand("select * from partij", connection.getConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    partijen.Add(new Partij(Convert.ToInt32(reader["ID"]), reader["naam"].ToString(), reader["lijsttrekker"].ToString()));
                }
            }
            connection.disConnect();
            return partijen;
        }
    

        public List<Partij> getPartijen(int id)
        {
            throw new NotImplementedException();
        }

        public List<Verkiezing> getVerkiezingen()
        {
            List<Verkiezing> verkiezingen = new List<Verkiezing>();
            connection.connect();
            SqlCommand sqlCommand = new SqlCommand("select * from verkiezing", connection.getConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    verkiezingen.Add(new Verkiezing(Convert.ToInt32(reader["ID"]), reader["naam"].ToString(), Convert.ToInt32(reader["zetels"])));
                }
            }
            connection.disConnect();
            return verkiezingen;
        }

        public void addVerkiezing(List<int> partijIDs, string text, int value)
        {
            SqlCommand SqlCommand = new SqlCommand("INSERT INTO Verkiezing(Naam,zetels) VALUES (@naam,@zetels) SELECT SCOPE_IDENTITY()", connection.getConnection());
            connection.connect();
            SqlCommand.Parameters.AddWithValue("@naam", text);
            SqlCommand.Parameters.AddWithValue("@zetels", value);
            SqlCommand.Connection = connection.getConnection();
            int verkiezing = (int)(decimal)SqlCommand.ExecuteScalar();
            foreach (int ID in partijIDs)
            {
                SqlCommand = new SqlCommand("INSERT INTO VerkiezingPartij(VerkiezingID,PartijID) VALUES(@verkiezing,@partij)", connection.getConnection());
                SqlCommand.Parameters.AddWithValue("@verkiezing", verkiezing);
                SqlCommand.Parameters.AddWithValue("@partij", ID);
                SqlCommand.ExecuteNonQuery();
            }
            connection.disConnect();
        }
    }
}
