using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Models
{
    class ProductsRepository : IProductsrepository
    {
        private string connectionString = null;

        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }   

        public void Create(Entity user)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("INSERT INTO Products (Name, Price) VALUES(@Name, @Price)", user);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("DELETE Products WHERE Id=@Id", new { id });
            }
        }

        public Entity Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entity> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Entity>("SELECT * FROM Products").ToList();
            }
        }

        public void Update(Entity user)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Execute("UPDATE Products SET Name=@Name, Price=@Price WHERE Id=@Id", user);
            }
        }
    }
}
