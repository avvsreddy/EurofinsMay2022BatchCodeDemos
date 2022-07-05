using DbProgrammingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgrammingDemo.DataAccess
{
    public interface IProductsRepository
    {
        // CRUD
        int Save(Product productToSave); //  done
        int Delete(int id);

        int Update(Product productToUpdate);

        // search / Query
        List<Product> GetProducts();
        List<Product> GetProductsByBrand(string brand);

        List<Product> GetProductsByCatagory(string catagory);
        Product GetProductByName(string name);
        /// <summary>
        /// Search product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns product data. if not found returns null</returns>
        Product GetProductById(int id);

        int GetProductsCost();
        int GetProductsCount();
    }
}
