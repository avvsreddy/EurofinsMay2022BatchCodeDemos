using DbProgrammingDemo.DataAccess;
using DbProgrammingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgrammingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Manage Products / CRUD

            // Step A: Choose or Create Database - Manual - Done
            // Step B: Create a table - Manaul - Done

            // Collect data
            //Product p = new Product();
            //Console.Write("Enter Product Name: ");
            //p.Name = Console.ReadLine();
            //Console.Write("Enter Product Cost: ");
            //p.Price = int.Parse(Console.ReadLine());
            //Console.Write("Enter Brand: ");
            //p.Brand = Console.ReadLine();
            //Console.Write("Enter Catagory: ");
            //p.Catagory = Console.ReadLine();
            //IProductsRepository repo = new ProductsRepository();
            //int count = repo.Save(p);
            //Console.WriteLine($"{count} product(s) saved");

            IProductsRepository repo = new ProductsRepository();
            List<Product> products = repo.GetProducts();
            foreach (Product p in products)       
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    
}
