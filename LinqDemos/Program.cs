using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };
            // extract all evens
            // Linq expression
            var evens = (from n in numbers
                        where IsEven(n) //n % 2 == 0
                        select n).ToList();

            numbers.Add(10);
            // Linq statement/extension methods
            //var evens2 = numbers.Where(n => n % 2 == 0).Select(n => n);

            // 2 4 6 8
            //var evens = GetEvens();
            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> GetEvens()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // extract all evens
            // Linq expression
            var evens = from n in numbers
                        where IsEven(n) //n % 2 == 0
                        select n;

            return evens.ToList();
        }

        public static bool IsEven(int n)
        {
            Console.WriteLine("In IsEven()");
            return n % 2 == 0;
        }
    }
}
