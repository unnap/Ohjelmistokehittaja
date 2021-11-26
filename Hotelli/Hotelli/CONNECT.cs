using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli
{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhots; port=3306; username=root; password=; database=hotelli");
        
        public MySqlConnection getConnection()
        {
            return connection;
        }
        
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
