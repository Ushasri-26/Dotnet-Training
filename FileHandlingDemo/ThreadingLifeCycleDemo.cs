using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    internal class ThreadingLifeCycleDemo
    {
        static void Main()
        {
            Thread t = new Thread(WorkerMethod);
            Console.WriteLine($"State after creation: {t.ThreadState}"); //Unstarted

            t.Start();
            Console.WriteLine($"State after Start: {t.ThreadState}");

            t.Join(); // wait until it finishes
            Console.WriteLine($"State after Join: {t.ThreadState}");


        }
    }
}
