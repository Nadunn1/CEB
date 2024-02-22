using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEB_App
{
    public class Database
    {
        public SqlConnection DBConnect()
        {
            string con_string = "Data Source=DARK_PHOENIX\\SQLEXPRESS;Initial Catalog=CEB;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(con_string);
            return con;
        }
    }
}
