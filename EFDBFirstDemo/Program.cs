using EFDBFirstDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage Products - CRUD
            // DB First Approach
            ProductsDataModel db = new ProductsDataModel();
            // get all products
            var products = from p in db.Products
                           select p;

            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }


        }

        private static void Edit()
        {
            // Edit
            // get the object to edit
            ProductsDataModel db = new ProductsDataModel();
            var productToEdit = db.Products.Find(1);
            productToEdit.Price = productToEdit.Price += 1000;
            db.SaveChanges();
        }

        private static void Delete()
        {
            // Delete
            ProductsDataModel db = new ProductsDataModel();
            // get the object to delete
            var productToDel1 = (from p in db.Products
                                 where p.ProductId == 3
                                 select p).FirstOrDefault();

            var productToDel = db.Products.Find(3);

            if (productToDel == null)
                Console.WriteLine("No such product to delete");
            else
            {
                db.Products.Remove(productToDel);

                db.SaveChanges();
                Console.WriteLine("Product deleted");
            }
        }

        public static void Add()
        {
            // Add new Product
            Product p = new Product
            {
                Name = "New Product 1",
                Brand = "New Brand 1",
                Price = 1000,
                Catagory = "New Catagory"
            };

            ProductsDataModel db = new ProductsDataModel();
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Product saved");
        }
    }
}
