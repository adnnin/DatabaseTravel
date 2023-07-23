using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BD_Travel_dot_net_4_7
{

    public class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HPPAVILION15; Initial Catalog=Турфирма; Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CheckConnection()
        {
            MessageBox.Show(sqlConnection.State.ToString());
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

    }
}
