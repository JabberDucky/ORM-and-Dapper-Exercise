using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;

        public DapperProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }
       
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
