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
        protected MySqlConnection Connection { get; set; } = new MySqlConnection($"server=localhost;uid=robert;pwd=P@ssw0rd;database=amazondb");

    }
} 