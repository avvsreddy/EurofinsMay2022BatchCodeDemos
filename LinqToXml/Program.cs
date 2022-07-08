using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load XML
            XDocument xml = XDocument.Load("XMLFile1.xml");
            // Get all book titles
            var titles = from b in xml.Descendants("title")
                         select b.Value;


            var titleCost = from b in xml.Descendants("book")
                            select new { Title = b.Element("title").Value, Price = b.Element("price").Value };


            // get all book titles of fantacy genre

            var fantacytitles = from b in xml.Descendants("book")
                                where b.Element("genre").Value == "Fantasy"
                                select b.Element("title").Value;


            foreach (var item in fantacytitles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
