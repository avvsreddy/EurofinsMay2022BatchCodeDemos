using DbProgrammingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgrammingDemo.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(Product productToSave)
        {
            // Step 1: Connect to DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyProductsDB2022;Integrated Security=True";
            conn.Open();

            // Step 2: Send SQL Insert Command
            string sqlInsert = $"insert into products values ('{productToSave.Name}',{productToSave.Price},'{productToSave.Brand}','{productToSave.Catagory}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            int count = 0;
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            finally
            {
                // Step 3:
                conn.Close();
            }
            return count;
        }

        public int Update(Product productToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
