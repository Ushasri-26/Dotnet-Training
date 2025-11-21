using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class TaskDemo
    {
        public void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1 Called");
                Thread.Sleep(1000);
            }
        }
        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method2 Called");
                Thread.Sleep(1000);
            }
        }
        public void Method3()
        {
            Task t1 = new Task(Method1);//insert record to db
            t1.Start();
            Task t2 = new Task(Method2);//update record to db
            t2.Start();
        }
    }
}
