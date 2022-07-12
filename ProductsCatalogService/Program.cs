using ProductsCatalogService.DataAccess;
using ProductsCatalogService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage Products
            // Add new product
            ProductsDbContext db = new ProductsDbContext();
            db.Database.Log = Console.WriteLine;
            // add new product
            Product p = new Product { Name = "P2", Cost = 780, InStock = true };

            db.Products.Add(p);
            db.SaveChanges();


                            

        }
    }
}
