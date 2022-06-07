using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // SRP - UI
        {
            // Accept two int numbers and find the sum and display
            // variables dec
            int fno, sno, sum;
            // IO Statements
            Console.Write("Enter first number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number: ");
            sno = Convert.ToInt32(Console.ReadLine());
            // find the sum
            //sum = fno + sno;
            sum = SimpleCalculatorClassLibrary.SimpleCalculator.FindSum(fno, sno);
            // display
            Console.WriteLine(sum);
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum of {0} and {1} is {2}", fno, sno, sum);
            Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
        } 

       
    } // UI

    
}
