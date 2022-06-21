using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCollectionDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(); // LOFO
            // add
            numbers.Push(100);
            numbers.Push(200);
            // read
            int a = numbers.Pop();
            a = numbers.Peek();

            
            Queue<int> q = new Queue<int>(); // FIFO
            // add
            q.Enqueue(100);
            // read
            a = q.Dequeue();
            //a = q.Peek();

            LinkedList<int> ll = new LinkedList<int>();

            //SortedList<int> sl = new System.Collections.Generic.SortedList<int>();

            Dictionary<int,string> scores = new Dictionary<int,string>();
            // add
            scores.Add(111, "Pass");
            scores.Add(222, "Fail");

            // read
            string res = scores[222];

            HashSet<int> hash = new HashSet<int>();
            // add
            hash.Add(100);
            hash.Add(200);
            hash.Add(200);
            Console.WriteLine(hash.Count);

            //System.Collections.Concurrent.ConcurrentStack<int>

        }
    }
}
