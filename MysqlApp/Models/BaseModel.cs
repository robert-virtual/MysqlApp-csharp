using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace MysqlApp.Models
{
    public class BaseModel<T>:Conexion where T:class

    {
        public IEnumerable<T> GetAll()
        {
            using (var conn = Connection)
            {
                return conn.GetAll<T>();
            }
        }
        public T Get(int id)
        {
            using (var conn = Connection)
            {
                return conn.Get<T>(id);
            }
        }
        public bool Delete(T entity)
        {
            using (var conn = Connection)
            {
                return conn.Delete(entity);
            }
        }
        public bool Update(T entity)
        {
            using (var conn = Connection)
            {
                return conn.Update(entity);
            }
        }
        public long Save(T entity)
        {
            using (var conn = Connection)
            {
                return conn.Insert(entity);
            }
        }
    }
}
