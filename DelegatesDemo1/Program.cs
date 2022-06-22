using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo1
{

    //class MyDelegate : MulticastDelegate
    //{

    //}

    delegate void MyDelegate(string str); // Delegate Declaration
    delegate void MyDelegate2();

    internal class Program
    {
        static void Main(string[] args)
        {
            // Direct
            //Greeting("Hello 1");
            // Indirect
            //MulticastDelegate mcd = new
            Program p = new Program();
            MyDelegate md = new MyDelegate(p.Hello);
            md += Greeting; // Subscription
            //md.Invoke("Hello 2");
            md -= p.Hello;
            MyDelegate2 md2 = new MyDelegate2(Hi);
            //md += Hi;
            //md -= Greeting;
            if(md != null)
                md("Hi...");
        }

        static void Hi()
        {
            Console.WriteLine("Hi");
        }

        static void Greeting(string msg)
        {
            Console.WriteLine($"Greeting :{msg}");
        }

        void Hello(string str)
        {
            Console.WriteLine($"Hello :{str}");
        }
    }
}
