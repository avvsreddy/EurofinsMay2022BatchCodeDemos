using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDE i = new IDE();
            LangC c = new LangC();
            LangCSharp cs = new LangCSharp();
            LangJava java = new LangJava();
            LangVBNet vb = new LangVBNet();
            i.Languages.Add(c);
            i.Languages.Add(cs);
            i.Languages.Add(vb);
            i.Languages.Add(java);

            i.DoWork();

        }
    }

    public interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }

    abstract public class ObjectOriented : ILanguage
    {
        abstract public string GetName();
      

        public string GetParadigm()
        {
            return "OOP";
        }

        public string GetUnit()
        {
            return "Class";
        }
    }

    abstract public class Procedural : ILanguage
    {
        public string GetUnit()
        {
            return "Function";
        }
        public string GetParadigm()
        {
            return "Procedural";
        }

        abstract public string GetName();
        
    }

    class IDE // OCP
    {
        //public LangC C { get; set; }
        //public LangCSharp CS { get; set; }
        //public LangJava Java { get; set; }

        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();


        public void DoWork()
        {
            foreach (ILanguage language in Languages)
            {
            Console.WriteLine(language.GetName());
            Console.WriteLine(language.GetUnit());
            Console.WriteLine(language.GetParadigm());
            }
        }
    }

    class LangC :  Procedural
    {
        override public string GetName()
        {
            return "C Language";
        }
       
    }
    
    class LangCSharp : ObjectOriented
    {
        override public string GetName()
        {
            return "C# Language";
        }
       
    }

    class LangJava : ObjectOriented
    {
        override public string GetName()
        {
            return "Java Language";
        }
       
    }

    class LangVBNet : ObjectOriented
    {
        override public string GetName()
        {
            return "VB.Net";
        }

      
    }
}
