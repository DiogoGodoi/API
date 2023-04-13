using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class DaoConexao
    {
        public static MySqlConnection GetConection()
        {
            var builder = new MySqlConnectionStringBuilder {
            Server = "192.168.0.253",
            Port = 4550,
            UserID = "root",
            Password = "T21nfr@--",
            Database = "produtos"
            };

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            return conn;
        }
    }
}
