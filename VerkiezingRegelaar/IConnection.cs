using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkiezingRegelaar
{
    public interface IConnection
    {
        void connect();
        void disConnect();
        SqlConnection getConnection();
    }
}
