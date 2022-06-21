using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIODemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAllDrives();
            //GetAllFiles();

            //File.Copy()
            Directory.CreateDirectory("");
            File.Delete("");
            File.Encrypt("sdf");
            File.Decrypt("dfsd");
            File.Move("", "");
            File.Exists("");


        }


        static void GetAllFiles()
        {
            string[] files = Directory.GetFiles(@"E:\Training Materials 2020\A");
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

        }
        static void GetAllDrives()
        {

           DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                
            }
        }

    }
}
