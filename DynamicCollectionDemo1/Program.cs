using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCollectionDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need a dynamic double collection to store and read n number of values
            //23,345,567,678,6,45,34,23,345,567,789,8900
            //MyIntDynamicCollection numbers = new MyIntDynamicCollection();

            MyDynamicCollection<int> numbers = new MyDynamicCollection<int>();
            List<int> scores = new List<int>();
            scores.Add(100);

            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(14);
            numbers.Add(17);
            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(14);
            numbers.Add(17);
            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(14);
            numbers.Add(17);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers.Get(i));
            }

        }
    }

    class MyIntDynamicCollection
    {
        private int[] data = new int[5];
        private int index = 0;
        public void Add(int n)
        {
            if(index < data.Length) // collection is empty
            {
                data[index++] = n;
            }
            else // colletion is full
            {
                // resize the collection
                //int[] temp = new int[data.Length * 2];
                //for (int i = 0; i < data.Length; i++)
                //{
                //    temp[i] = data[i]; // copy data from old collection into new collection
                //}
                //Array.Copy(data, temp, data.Length);
                //temp[index++] = n;
                //data = temp;

                Array.Resize(ref data, data.Length * 2);
                data[index++] = n;
            }
        }

        public int Count 
        { 
            get
            {
                return index; 
            }
        }

        public int Get(int i)
        {
            return data[i];
        }
    }

    class MyDoubleDynamicCollection
    {
        private double[] data = new double[5];
        private int index = 0;
        public void Add(double n)
        {
            if (index < data.Length) // collection is empty
            {
                data[index++] = n;
            }
            else // colletion is full
            {
                Array.Resize(ref data, data.Length * 2);
                data[index++] = n;
            }
        }
        public int Count
        {
            get { return index; }
        }
        public double Get(int i)
        {
            return data[i];
        }
    }

    class MyStringDynamicCollection
    {
        private string[] data = new string[5];
        private int index = 0;
        public void Add(string n)
        {
            if (index < data.Length) // collection is empty
            {
                data[index++] = n;
            }
            else // colletion is full
            {
                // resize the collection
                //int[] temp = new int[data.Length * 2];
                //for (int i = 0; i < data.Length; i++)
                //{
                //    temp[i] = data[i]; // copy data from old collection into new collection
                //}
                //Array.Copy(data, temp, data.Length);
                //temp[index++] = n;
                //data = temp;

                Array.Resize(ref data, data.Length * 2);
                data[index++] = n;
            }
        }

        public int Count
        {
            get
            {
                return index;
            }
        }

        public string Get(int i)
        {
            return data[i];
        }
    }


    class MyDynamicCollection<T>
    {
        private T[] data = new T[5];
        private int index = 0;
        public void Add(T n)
        {
            if (index < data.Length) // collection is empty
            {
                data[index++] = n;
            }
            else // colletion is full
            {
                // resize the collection
                Array.Resize(ref data, data.Length * 2);
                data[index++] = n;
            }
        }

        public int Count
        {
            get
            {
                return index;
            }
        }

        public T Get(int i)
        {
            return data[i];
        }
    }


}
