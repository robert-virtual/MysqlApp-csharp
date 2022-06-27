using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;

namespace MysqlApp.Models
{
    [Table("Products")]
    public class Products:BaseModel<Products>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }

        [Write(false)]
        public Category Category { get; set; }
        
        public IEnumerable<Products> GetAll() 
        {
            using(var conn = Connection)
            {
                var sql = @"SELECT * FROM Products p INNER JOIN Categories c on c.Id = p.CategoryId";
                var products = conn.Query<Products, Category, Products>(sql, (p, c) => {
                    p.Category = c;
                    return p;
                });
                return products;
            }

        }

    }
}
