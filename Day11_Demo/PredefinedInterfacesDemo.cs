using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Demo
{
    internal class PredefinedInterfacesDemo
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList() { "Apple", "Guava", "Orange", "Grapes", "Mango" };

            IEnumerator enumerator = items.GetEnumerator();
            Console.WriteLine($"enumerator: {enumerator.Current}");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("n Items in ArrayList's are:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
