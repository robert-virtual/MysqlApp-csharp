using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MysqlApp.Models
{
    public class Products:Conexion
    {
        public string name { get; set; }
        public int stock { get; set; }
        public float price { get; set; }



        public DataTable GetAll()
        {
            Connection.Open();
            MySqlCommand commd = new MySqlCommand("Select * from products", Connection);
            MySqlDataReader datareader = commd.ExecuteReader();
            datareader.Read();
            DataTable products = new DataTable();
            products.Load(datareader);
            Connection.Close();
            return products; 
        }
        public int Save()
        {
            Connection.Open();
            MySqlCommand commd = new MySqlCommand("insert into products(name,stock,price) values(@name,@stock,@price)", Connection);
            commd.Parameters.AddWithValue("@name", name);
            commd.Parameters.AddWithValue("@stock", stock);
            commd.Parameters.AddWithValue("@price", price);
            commd.Parameters["@name"].Value = name;
            commd.Parameters["@stock"].Value = stock;
            commd.Parameters["@price"].Value = price;
            commd.Prepare();
            var res = commd.ExecuteNonQuery();
            Connection.Close();
            return res; 
        }
    }
}
