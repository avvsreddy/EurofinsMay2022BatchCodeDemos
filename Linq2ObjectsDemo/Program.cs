using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq2ObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq to Objects

            int[] numbers = { 11, 52, 36, 14, 65, 46, 77, 18, 29 };

            // Table numbers
            // column number

            // sql: select number from numbers where number mod 2 = 0 order by number desc;

            // extract all even numbers into another array in decreasing order
            // Linq to Object: 

            var evenNumbers = from n in numbers 
                              where n % 2 == 0 
                              orderby n descending
                              select n;


            // Linq to XML
            XDocument xml = XDocument.Load("XMLFile1.xml");

            var evensFromXml = from n in xml.Descendants("number")
                               where int.Parse(n.Value) % 2 == 0
                               orderby n.Value descending
                               select n.Value;

            foreach (var item in evensFromXml)
            {
                Console.WriteLine(item);
            }

            int[] evens = new int[numbers.Length];
            for (int i = 0,x=0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evens[x++] = numbers[i];
                }
            }

            // display all data in a new array
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
