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
            Server = "*",
            Port = 0,
            UserID = "*",
            Password = "*",
            Database = "produtos"
            };

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            return conn;
        }
    }
}
