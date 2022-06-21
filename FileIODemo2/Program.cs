using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FileIODemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product { ProductID = 111, Name = "IPhone X", Cost = 75000, Brand = "Apple" };
            //XmlSerializeProduct(p);

            Product product = XmlDeserializeProduct();
            Console.WriteLine($"{product.ProductID}\t{product.Name}\t{product.Cost}\t{product.Brand}");

            //Product product = DeserializeProduct();
            //Console.WriteLine($"{product.ProductID}\t{product.Name}\t{product.Cost}\t{product.Brand}");
            //Product p = new Product { ProductID = 111, Name = "IPhone X", Cost = 75000, Brand = "Apple" };
            //SerializeProduct(p);
            //Console.WriteLine("Product is serialized");
            //SaveProduct(p);
            //Console.WriteLine("Product saved");

            //List<Product> products = ReadAllProducts();
            //// display
            //Console.WriteLine("Id\tName\tCost\tBrand");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"{product.ProductID}\t{product.Name}\t{product.Cost}\t{product.Brand}");
            //}

        }


        static Product DeserializeProduct()
        {
            Stream stream = new FileStream("e:\\products.dat", FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            Product p = (Product) binary.Deserialize(stream);
            return p;
        }


        static Product XmlDeserializeProduct()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            Stream stream = new FileStream("e:\\products.xml", FileMode.Open);
            Product p = (Product)xml.Deserialize(stream);
            return p;
        }
        static void XmlSerializeProduct(Product p)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            Stream stream = new FileStream("e:\\products.xml", FileMode.Append);
            xml.Serialize(stream, p);
            stream.Close();
        }

        static void SerializeProduct(Product p)
        {

            Stream stream = new FileStream("e:\\products.dat", FileMode.Append);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, p);
            stream.Close();
            // Binary
            // XML
            // SOAP
            // JSON


            //StreamWriter writer = new StreamWriter(@"E:\products.txt", true);
            //try
            //{
            //    //string csvData = $"{p.ProductID},{p.Name},{p.Cost},{p.Brand}";
            //    //writer.WriteLine(csvData);
            //}
            //finally
            //{
            //    writer.Close();
            //}
        }

        static void SaveProduct(Product p)
        {
            StreamWriter writer = new StreamWriter(@"E:\products.txt",true);
            try
            {
                string csvData = $"{p.ProductID},{p.Name},{p.Cost},{p.Brand}";
                writer.WriteLine(csvData);
            }
            finally
            {
                writer.Close();
            }
        }

        static List<Product> ReadAllProducts()
        {
            List<Product> products = new List<Product>();
            // read from file and fill into collection and return
            StreamReader reader=null;
            try
            {
                reader = new StreamReader(@"e:\products.txt");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    Product p = new Product {ProductID=int.Parse(data[0]),Name=data[1],Cost=int.Parse(data[2]),Brand=data[3] };
                    products.Add(p);
                }
            }
            finally
            {
                reader.Close();
            }
            return products;
        }
    }

    [Serializable]
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Brand { get; set; }
    }
}
