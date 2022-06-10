using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { ProductId = 111, Name = "IPhone X", Brand = "Apple", Price = 89000 };
            Product p2 = new Product { ProductId = 222, Name = "Galaxy S24", Brand = "Samsung", Price = 56000 };
            Product p3 = new Product { ProductId = 333, Name = "Appo S10", Brand = "Appo", Price = 34000 };

            Catagory c = new Catagory { CatagoryId = 1, Name = "Smart Phones" };
            c.Products.Add(p1);
            c.Products.Add(p2);
            c.Products.Add(p3);

            DisplayCatagoryDetails(c);
            
            // Create 3 products, one catagory and add all products to the catagory


        }
        static void DisplayCatagoryDetails(Catagory c)
        {
            Console.WriteLine($"Catagory : {c.Name}");
            Console.WriteLine($"Products Count: {c.Products.Count}");
            Console.WriteLine("The products are");
            Console.WriteLine("-----------------------");
            
            foreach (Product product in c.Products)
            {
                Console.WriteLine(product.Name);
            }

            for (int i = 0; i < c.Products.Count; i++)
            {
                Console.WriteLine(c.Products[i].Name);
            }
        }
        static void DisplayProductsDetail(Product p)
        {
            // display product name and catagory name
            Console.WriteLine("Product Name: " + p.Name);
            Console.WriteLine("Catagory Name: " + p.TheCatagory.Name);
        }

       
    }
}
