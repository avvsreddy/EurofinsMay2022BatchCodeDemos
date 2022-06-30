using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplicationDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1
            //ProcessManager.ShowProcessList(NoFilter);

            // client 2
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //ProcessManager.ShowProcessList(filter);
            // client 3
            //ProcessManager.ShowProcessList(FilterByMemSize);

            //   Anonymous Methods / Delegates
            ProcessManager.ShowProcessList( delegate
                {
                return true;
                }
            );

            ProcessManager.ShowProcessList(delegate(Process p)
                {
                return p.WorkingSet64 >= 50 * 1024 * 1024;
                }
             );

            // Lambda => Light Weight Syntax for Anonymous Delegates

            // Lambda => Statements


            ProcessManager.ShowProcessList((Process p) =>
            {
                return p.WorkingSet64 >= 50 * 1024 * 1024;
            }
             );

            // Lambda => Expressions


            ProcessManager.ShowProcessList((Process p) =>
            
                 p.WorkingSet64 >= 50 * 1024 * 1024
            
             );

            ProcessManager.ShowProcessList( p => p.WorkingSet64 >= 50 * 1024 * 1024);
            ProcessManager.ShowProcessList(p => p.ProcessName.StartsWith("S"));
        }

        // client 1
        //public static bool NoFilter(Process p)
        //{
        //    return true;
        //}
        //client3
        public static bool FilterByMemSize(Process p)
        {
            return p.WorkingSet64 >= 50 * 1024 * 1024;
        }
        // client 2
        public static bool FilterByName(Process p)
        {
            return p.ProcessName.StartsWith("S");
        }
    }

    public delegate bool FilterDelegate(Process p);
    class ProcessManager
    {
        // c1
        //public static void ShowProcessList()
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    } 
        //}
        // c2
        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if(filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
        // c3
        //public static void ShowProcessList(long memSize)
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        if (p.WorkingSet64 >= memSize)
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}
    }
}
