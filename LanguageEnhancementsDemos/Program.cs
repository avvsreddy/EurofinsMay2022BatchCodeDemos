using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEnhancementsDemos
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Local Variable type inference
            // Object Initialization Syntax
            var p1 = new  { Id = 111, Name = "aaaa" };
            //p1.Id = 222;
            // Anonymous Types
            // Extension Methods
            // Lambda
            // Automatic Properties

            string data = "some data";
            //data.ToUpper();
            data.Encrypt();
            data = StringEncrypt.Encrypt(data);
            int a = 100;
            a.Encrypt();
            Program p = new Program();
            p.Encrypt();
        }
    }

    public static class StringEncrypt
    {
        public static string Encrypt(this object input)
        {
            return "@#$@#RSDFSDFS@#$@#$@#SDFSF@#$@#$@#";
        }

        
    }


    //class Anoymous234234234
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
