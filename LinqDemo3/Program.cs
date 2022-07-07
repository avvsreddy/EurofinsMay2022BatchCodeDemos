using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo3
{


    //class PNamePrice
    //{
    //    public string PName { get; set; }
    //    public int Price { get; set; }
    //}

    class NameBrand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ
            // Get all products names
            var plist = from p in GetProducts()
                        select p.PName;

            // Get product name and price
            var plist2 = from p2 in GetProducts()
                         select new  { PName=p2.PName, Price=p2.Price };

            // Get name,brand
            var plist3 = from p3 in GetProducts()
                         select new NameBrand { Name = p3.PName, Brand = p3.Brand };

            // Get only price
            var plist4 = from p4 in GetProducts()
                         select p4.Price;

            // Get the total worth of all products
            int totalWorth = 0;
            foreach (var item in GetProducts())
            {
                totalWorth += item.Price;
            }

            // using linq
            int totalWorth2 = (from p in GetProducts()
                               select p.Price).Sum();

            // Get totalWorth of all apple products

            int totalWorth3 = (from p in GetProducts()
                               where p.Brand=="Apple"
                               select p.Price).Sum();
            // get most expensive product name
            int expensiveCost = (from p in GetProducts()
                                 select p.Price).Max();
            string pname = (from p in GetProducts()
                           where p.Price == expensiveCost
                           select p.PName).First();

            string pname2 = (from p in GetProducts()
                            where p.Price == ((from p2 in GetProducts() select p2.Price)).Max()
                            select p.PName).First();

            Console.WriteLine(pname2);

            string pname3 = (from p in GetProducts()
                             orderby p.Price descending
                             select p.PName).First();

            // Get all pname and cname only
            var pnamecname = from p in GetProducts()
                             select new { PName = p.PName, CName = p.Catagory.CName };
                             
        }

        static List<Product> GetProducts()
        {
            Catagory c1 = new Catagory { CID = 1, CName = "Laptops" };
            Catagory c2 = new Catagory { CID = 2, CName = "Mobiles" };
            Catagory c3 = new Catagory { CID = 3, CName = "Watches" };
            
            List<Product> plist = new List<Product> 
            {
                new Product{PID=111, PName="Dell XPS 3", Brand="Dell", Price=78000, Catagory=c1},
                new Product{PID=222, PName="HP Pavilion 3", Brand="HP", Price=58000, Catagory=c1},
                new Product{PID=333, PName="Galaxy S45", Brand="Samsung", Price=68000, Catagory=c2},
                new Product{PID=444, PName="IPhone X", Brand="Apple", Price=98000, Catagory=c2},
                new Product{PID=555, PName="Moto G", Brand="Motorola", Price=48000, Catagory=c2},
                new Product{PID=666, PName="Noice 56", Brand="Noice", Price=28000, Catagory=c3},
                new Product{PID=777, PName="IWatch 2", Brand="Apple", Price=78000, Catagory=c3},
            };
            return plist;
        }
    }

    class Product
    {
        public int PID { get; set; }
        public string PName { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Catagory Catagory { get; set; }

    }

    class Catagory
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
