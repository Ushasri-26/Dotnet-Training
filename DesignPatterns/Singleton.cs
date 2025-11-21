using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal sealed class Singleton
    {
        private Singleton() { }
        static Singleton s = null;
        public static Singleton GetInstance
        {
            get
            {
                if (s == null) // first request(object created)
                {
                    s = new Singleton();
                    return s;
                }
                else
                {
                    return s; // second reques(object reused)
                }
            }
        }
        public void Method()
        {
            // singleton ob = new singleton(); // run time error
            // code to interact with database
            Console.WriteLine("Database code triggered");

        }
    }
}
