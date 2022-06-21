using System;
using System.Collections.Generic; // Typed Dynamic
//using System.Collections; // Untyped Dynamic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCollectionsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dynamic Collection - Typed/Untyped
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(101);
            numbers.Add(120);
            numbers.Add(150);
            numbers.Add(100);
            numbers.TrimExcess();
            Console.WriteLine($"The count {numbers.Count}");
            Console.WriteLine($"The Capacity {numbers.Capacity}");
            Console.WriteLine($"Sum {numbers.Sum()}");
            Console.WriteLine($"Max {numbers.Max()}");

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            // add data
            //numbers.Add(10);
            // read data
            //int a = numbers[0];
            

        }
    }
}
