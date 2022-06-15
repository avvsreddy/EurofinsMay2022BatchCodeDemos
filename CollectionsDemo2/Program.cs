using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int[] numbers = { 34, 12, 67, 22, 50 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("After sorting");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
