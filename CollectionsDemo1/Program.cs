using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[3];
            Item i1 = new Item { Id = 111, Name = "IPhone", Cost = 89000 };
            items[0] = i1;

            int[,] a = new int[3,5];
            a[1, 1] = 10;

            int[][] jaggedScore = new int[3][];
            jaggedScore[0] = new int[3];
            jaggedScore[1] = new int[2];
            jaggedScore[2] = new int[5];

            jaggedScore[1][1] = 50;

        }
    }
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
