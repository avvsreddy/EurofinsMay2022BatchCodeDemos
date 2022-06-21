using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // find sum of two numbers - continuesly
            int fno, sno, sum = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());
                    //sum = fno + sno;
                    sum = Calculator.Sum(fno, sno);
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException fx)
                {
                    Console.WriteLine("Enter only numbers");
                }
                //catch (OverflowException of)
                //{
                //    Console.WriteLine("Enter small numbers");
                //}
                catch(Exception ex)
                {
                    // Inform to app user
                    Console.WriteLine(ex.Message);
                    // Inform to app admin
                    // Log the exceptions
                    // Convert the old exp into new exp - middle layers/back end
                    // Rethrow the exp // back end

                }
            }


        }
    }

    class Calculator // BLL
    {
        public static int Sum(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0)
                return a + b;
            else
                throw new InvalidNumbersException("Enter only even numbers");
        }
    }

    class InvalidNumbersException : ApplicationException
    {
        public InvalidNumbersException(string msg):base(msg)
        {
            //Message = msg;
        }
    }
}
