using DbProgrammingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
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
        /// <summary>
        /// Search product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns product data. if not found returns null</returns>
        public Product GetProductById(int id)
        {
            // Step 1: Connect to DB
            SqlConnection conn = GetConnection();

            string sqlSelect = "[dbo].[sp_getProductById]";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Product p = null;
            if (reader.HasRows)
            {
                reader.Read();
                p = new Product();
                p.ProductId = (int)reader[0];
                p.Name = reader[1].ToString();
                p.Price = (int)reader["Price"];
                p.Brand = reader.GetString(3);
                p.Catagory = reader.GetString(4);
            }
            conn.Close();
            return p;

        }

        private static IDbConnection GetConnection()
        {
            //SqlConnection conn = new SqlConnection();

            IDbConnection conn = null;

           
            string constr = ConfigurationManager.ConnectionStrings["default"].ConnectionString; ;
            string provider = ConfigurationManager.ConnectionStrings["default"].ProviderName;

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            conn = factory.CreateConnection();
            conn.Open();
            return conn;
        }

        public Product GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            // Step 1: Connect to DB
            IDbConnection conn = GetConnection();

            string sqlSelect = $"select * from products";
            //SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlSelect;
            cmd.Connection = conn;
            //SqlDataReader reader = cmd.ExecuteReader();
            IDataReader reader = cmd.ExecuteReader();
            Product p = null;
            List<Product> plist = new List<Product>();
            //if (reader.HasRows)
            //{
                while (reader.Read())
                {
                    p = new Product();
                    p.ProductId = (int)reader[0];
                    p.Name = reader[1].ToString();
                    p.Price = (int)reader["Price"];
                    p.Brand = reader.GetString(3);
                    p.Catagory = reader.GetString(4);
                    plist.Add(p);
                }
            //}
            conn.Close();
            return plist;
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            throw new NotImplementedException();
        }

        public int GetProductsCost()
        {
            throw new NotImplementedException();
        }

        public int GetProductsCount()
        {
            throw new NotImplementedException();
        }

        public int Save(Product productToSave)
        {
            // Step 1: Connect to DB
            SqlConnection conn = GetConnection();

            // SQL Injection
            // uid = aaa
            // pwd = aaa' or 1=1;--

            // select count(*) from login where uid='aaa' and pwd = 'aaa' or 1=1;--'
            // select count(*) from login where uid='{uid}' and pwd = '{pwd}'

            // pname = iphone
            // pname = iphone';delete products;--
            // select * from products where name = '{pname}'
            // select * from products where name = 'iphone';delete products;--'


            // Step 2: Send SQL Insert Command
            //string sqlInsert = $"insert into products values ('{productToSave.Name}',{productToSave.Price},'{productToSave.Brand}','{productToSave.Catagory}')";

            string sqlInsert = "insert into products values (@name,@price,@brand,@cat)";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@name", productToSave.Name);
            cmd.Parameters.AddWithValue("@price", productToSave.Price);
            cmd.Parameters.AddWithValue("@brand", productToSave.Brand);
            //cmd.Parameters.AddWithValue("@cat", productToSave.Catagory);
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@cat";
            p.Value = productToSave.Catagory;
            cmd.Parameters.Add(p);


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
