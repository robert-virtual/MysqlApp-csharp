using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace MysqlApp.Models
{
    public class Conexion
    {
        protected MySqlConnection Connection { get; set; } 
        public Conexion()
        {
            string server = "localhost";
            string user = "gabriela";
            string password = "P@ass0rd";
            string database = "amazondb";
            string connString = $"server={server};uid={user};pwd={password};database={database}";
            Connection  = new MySqlConnection(connString);
        }
    }
} 