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
            //ProcessManager.ShowProcessList();
            // client 2
            //ProcessManager.ShowProcessList("s");
            // client 3
            ProcessManager.ShowProcessList(50 * 1024 * 1024);


        }
    }

    class ProcessManager
    {
        // c1
        public static void ShowProcessList()
        {
            foreach (Process p in Process.GetProcesses())
            {
                Console.WriteLine(p.ProcessName);
            } 
        }
        // c2
        public static void ShowProcessList(string sw)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if(p.ProcessName.StartsWith(sw))
                    Console.WriteLine(p.ProcessName);
            }
        }
        // c3
        public static void ShowProcessList(long memSize)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.WorkingSet64 >= memSize)
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
