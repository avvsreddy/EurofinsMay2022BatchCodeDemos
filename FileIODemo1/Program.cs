using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileIODemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            // read data from file1.txt and display
            // read lines
            // read all lines
            try
            {
                reader = new StreamReader(@"e:\file1.txt");
                //string allLines = reader.ReadToEnd();
                string line;
                while (!reader.EndOfStream)
                {
                  line = reader.ReadLine();
                  Console.WriteLine(line);
                }
            }
            finally
            {
                reader.Close();
            }
        }

        static void ReadAll()
        {
            StreamReader reader = null;
            // read data from file1.txt and display
            // read lines
            // read all lines
            try
            {
                reader = new StreamReader(@"e:\file1.txt");
                string allLines = reader.ReadToEnd();
                Console.WriteLine(allLines);
            }
            finally
            {
                reader.Close();
            }
        }
        static void WriteData()
        {
            // Write some data into a file
            StreamWriter writer = null;
            try
            {
                string someData = "This is some data line 3";
                writer = new StreamWriter(@"e:\file1.txt", true);

                writer.WriteLine(someData);
                //
                //

                //writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //writer.Close();
            }
            finally
            {
                writer.Close();
            }
        }

    }
}
