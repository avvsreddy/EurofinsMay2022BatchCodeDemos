using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IShape s;//= new Shape { H = 10, W = 15 };

             //Shape s = new Rectangle(); // Base class ref variable can hold derived type objects
            IShape s = new Triangle();
            //Line s = new Line();
            s.Draw();
            //Draw(s);

        }

        static void Draw(IShape s)
        {
            s.Draw();
        }
    }

    class Line : IShape
    {
        public int H { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int W { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    class ThreeDLine : Line
    {
        
    }

     public interface IShape
    {
         int H { get; set; }
         int W { get; set; }

         void CalculateArea();
        //{
            
        //    Console.WriteLine($"The area of Shape is {H*W}");
        //}

         void Draw();
        //{
        //    Console.WriteLine("Drawing Shape");
        //}
    }

    class Rectangle : IShape // IS-A - Realization
    {
        public  int H { get; set;}
        public  int W { get; set ; }

        public  void CalculateArea()
        {
            Console.WriteLine(H*W);
        }

        public  void Draw()
        {
            Console.WriteLine("Drawing Ractangle");
        }
    }

    class Triangle : IShape
    {
        public int H { get; set ; }
        public int W { get ; set ; }

        public void CalculateArea()
        {
            Console.WriteLine(H*W/2);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Traingle");
        }
    }
}
