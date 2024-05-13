using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV
{
    class connection
    {
        public static SqlConnection getConnection()
        {
            string query = "Data Source=DESKTOP-UE2LPMV;Initial Catalog=firstDB;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(query);
            return conn;
        }
    }
}
