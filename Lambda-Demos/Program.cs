using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Demos
{


    class Product
    {
        public int Id { get; private set; } // automatic

        private int price;
        public int Price
        {
            //private get { return price; }
            set
            {
                if (value < 0)
                    price = 0;
                else
                    price = value;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                Product p1 = new Product();
                p1.Id = 111; // write
                Console.WriteLine(p1.Id); // read

                List<int> numbers = new List<int> { 2, 43, 64, 85, 24, 86, 98, 34, 89 };

                int evensSum = 0;
                foreach (int n in numbers)
                {
                    if (n % 2 == 0)
                        evensSum += n;
                }

                Func<int, bool> predicate = new Func<int, bool>(IsEven);

                //int evensSum2 = numbers.Where(predicate).Sum();
                //int evensSum2 = numbers.Where(IsEven).Sum();

                int evensSum2 = numbers.Where(delegate (int n)
                {
                    return n % 2 == 0;
                }).Sum();

                int evensSum3 = numbers.Where((int n) =>
                {
                    return n % 2 == 0;
                }).Sum();

                int evensSum4 = numbers.Where(n => n % 2 == 0).Sum();

                Console.WriteLine($"The sum of all evens using our logic {evensSum}");
                Console.WriteLine($"The sum of all evens using Sum method {evensSum4}");

            }

            public static bool IsEven(int n)
            {
                return n % 2 == 0;
            }
        }
    }
}
